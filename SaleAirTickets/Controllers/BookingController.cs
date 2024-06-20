using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleAirTickets.DataContext;
using SaleAirTickets.Models;
using System.Net.Mail;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace SaleAirTickets.Controllers
{
    public class BookingController : Controller
    {
        private FlightContext Context { get; set; }
    

        public BookingController(FlightContext ctx)
        {
            Context = ctx;
        }


        [HttpPost]
        public IActionResult Add(int userId, int flightId, string status, int seatId)
        {
            var redirectUrl = Url.Action("GetSuccessPage", "Booking", new { userId, flightId, status, seatId });

            Booking booking = new Booking();
            booking.UserId = userId;
            booking.FlightId = flightId;
            booking.BookingDate = DateTime.Now;

            var seat = Context.Seats.Find(seatId);
            var flight = Context.Flights.Find(flightId);
            if (seat.ClassType == "Economy")
            {
                booking.TotalPrice = flight.EconomyClassPrice;
            }
            else
            {
                booking.TotalPrice = flight.BuisnessClassPrice;
            }
            
            booking.Status = status;

            Context.Bookings.Add(booking);
            Context.SaveChanges();

            // create the booking and return the created booking's Id
            return Json(new { bookingId = booking.BookingId, totalPrice = booking.TotalPrice, redirectURL = redirectUrl});
        }

        [HttpGet]
        public IActionResult GetSuccessPage(int userId, int flightId, string status, int seatId)
        {
            ViewBag.Action = "Успешно!";
            ViewBag.Status = status;
            var flights = Context.Flights
                .Where(f => f.FlightId == flightId)
                .Include(d => d.DepartureCity)
                .Include(a => a.ArrivalCity)
                .Include(a => a.Airplane)
                .ToList();
            Flight flight = flights[0];
            Seat seat = Context.Seats.Find(seatId);

            SendEmail("Ваш билет успешно забронирован!", flight, seat, userId);

            return View(new Tuple<Flight, Seat>(flight, seat));
        }

        private async void SendEmail(string subject, Flight flight, Seat seat, int userId)
        {
            EmailDto email = new EmailDto();
            email.To = Context.Users.Find(userId).Email;
            email.Subject = subject;
            email.Body = $"Город отправления: {flight.DepartureCity.Name} \nГород прибытия: {flight.ArrivalCity.Name} \nДата отправления: {flight.DepartureDate} \nДата прибытия: {flight.ArrivalDate} \nНомер самолета: {flight.Airplane.AirplaneNumber} \nНомер места: {seat.SeatNumber}";

            var json = JsonConvert.SerializeObject(email);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync("https://localhost:7157/api/Email", content);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
