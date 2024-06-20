using Microsoft.AspNetCore.Mvc;
using SaleAirTickets.DataContext;

namespace SaleAirTickets.Controllers
{
	public class FlightController : Controller
	{
		private FlightContext Context { get; set; }

        public FlightController(FlightContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index()
		{
			return View();
		}
	}
}
