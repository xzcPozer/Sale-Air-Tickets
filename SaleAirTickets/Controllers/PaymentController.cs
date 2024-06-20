using Microsoft.AspNetCore.Mvc;
using SaleAirTickets.DataContext;
using SaleAirTickets.Models;

namespace SaleAirTickets.Controllers
{
    public class PaymentController : Controller
    {
        private FlightContext Context { get; set; }

        public PaymentController(FlightContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int bookingId, decimal totalPrice)
        {
            Payment payment = new Payment();
            payment.BookingId = bookingId;
            payment.PaymentDate = DateTime.Now;
            payment.PaymentAmount = totalPrice;
            
            Context.Payments.Add(payment);
            Context.SaveChanges();
            return SuccessPendingPaid(Context.Bookings.Find(bookingId));
        }

        [HttpGet]
        public IActionResult SuccessPendingPaid(Booking booking)
        {
            booking.Status = "Paid";
            Context.Bookings.Update(booking);
            Context.SaveChanges();

            ViewBag.Action = "Успешно!";

            return View("SuccessPendingPaid");
        }
    }
}
