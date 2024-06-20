using Microsoft.AspNetCore.Mvc;
using SaleAirTickets.DataContext;
using SaleAirTickets.Models;

namespace SaleAirTickets.Controllers
{
    public class SeatController : Controller
    {
        private FlightContext Context { get; set; }

        public SeatController(FlightContext ctx)
        {
            Context = ctx;
        }

        [HttpPost]
        public IActionResult ChangeStatus(int seatId)
        {
            var seat = Context.Seats.Find(seatId);

            if (seat!=null)
            {
                seat.IsAvailable = false;
            }
            else
            {
                return NotFound();
            }

            Context.Seats.Update(seat);
            Context.SaveChanges();

            return Ok();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
