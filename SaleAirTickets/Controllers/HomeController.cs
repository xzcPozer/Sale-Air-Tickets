using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleAirTickets.DataContext;
using SaleAirTickets.Models;
using System.Diagnostics;

namespace SaleAirTickets.Controllers
{
    public class HomeController : Controller
    {
		private FlightContext Context { get; set; }

		public HomeController(FlightContext ctx)
        {
			Context = ctx;
		}

		public IActionResult Privacy()
		{
			return View();
		}


		public IActionResult Index()
        {
			ViewBag.Cities = Context.Cities.OrderBy(c => c.Name).ToList();
			var flight = Context.Flights
				.Include(m => m.DepartureCity)
				.Include(m => m.ArrivalCity)
				.Include(m => m.Airplane).OrderBy(m => m.DepartureDate).ToList();
			return View("Index", flight);
		}

		[HttpGet]
		public IActionResult Search(int departureCityId, int arrivalCityId, DateTime departureDate)
		{
			if (departureCityId == 0 || arrivalCityId == 0 || departureDate == DateTime.MinValue)
			{
				ModelState.AddModelError("", "Пожалуйста, выберите все поля для поиска.");
				return Index();
			}

			try
			{
				ViewBag.Cities = Context.Cities.OrderBy(c => c.Name).ToList();
				var flight = Context.Flights
					.Include(m => m.DepartureCity)
					.Include(m => m.ArrivalCity)
					.Include(m => m.Airplane)
					.Where(m => m.DepartureCityId == departureCityId && m.ArrivalCityId == arrivalCityId 
					&& m.DepartureDate.Day == departureDate.Day
					&& m.DepartureDate.Month == departureDate.Month
					&& m.DepartureDate.Year == departureDate.Year)
					.OrderBy(m => m.DepartureDate).ToList();

				return View("Index", flight);
			}
			catch(Exception)
			{
				return Index();
			}	
        }
    }
}
