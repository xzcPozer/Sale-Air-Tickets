using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SaleAirTickets.DataContext;
using SaleAirTickets.Models;
using System.Text;

namespace SaleAirTickets.Services.BackgroundService.BookingCancellation
{
    public class BookingCancellation : IBookingCancelation
    {
        private readonly FlightContext Context;

        public BookingCancellation(FlightContext ctx)
        {
            Context = ctx;
        }

        public void CancelBookings()
        {
            var bookings = Context.Bookings
                .Include(f => f.Flight)
                .Where(b => b.Status == "Pending" && b.Flight.DepartureDate < DateTime.Now.AddMinutes(120))
                .ToList();

            foreach (var booking in bookings)
            {
                booking.Status = "Cancelled";
                SendEmail("Ваша бронь была отменена!", booking.FlightId, booking.UserId);
            }
            Context.SaveChanges();
        }

        private async void SendEmail(string subject, int flightId, int userId)
        {
            var flights = Context.Flights
                .Where(f => f.FlightId == flightId)
                .Include(d => d.DepartureCity)
                .Include(a => a.ArrivalCity)
                .Include(a => a.Airplane)
                .ToList();
            Flight flight = flights[0];

            EmailDto email = new EmailDto();
            email.To = Context.Users.Find(userId).Email;
            email.Subject = subject;
            email.Body = $"Город отправления: {flight.DepartureCity.Name} \nГород прибытия: {flight.ArrivalCity.Name} \nДата отправления: {flight.DepartureDate} \nДата прибытия: {flight.ArrivalDate} \nНомер самолета: {flight.Airplane.AirplaneNumber}";

            var json = JsonConvert.SerializeObject(email);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync("https://localhost:7157/api/Email", content);
            }
        }
    }
}