using Microsoft.AspNetCore.Mvc;
using SaleAirTickets.DataContext;
using SaleAirTickets.Models;
using System;



namespace SaleAirTickets.Controllers
{
	public class UserController : Controller
	{
		private FlightContext Context { get; set; }

		public UserController(FlightContext ctx)
		{
			Context = ctx;
		}

        [HttpGet]
        public IActionResult BuyTicket(int flightId)
        {
            ViewBag.Seats = Context.Seats
                .Where(s => s.FlightId == flightId)
                .OrderBy(n => n.SeatNumber)
                .ToList();

            ViewBag.FlightId = flightId;

            ViewBag.Action = "Покупка/бронирование билета";
            return View("Add", new User());
        }

        [HttpPost]
        public IActionResult Add(User user, int flightId)//добавляет пользователя, если не было добавления
		{
            if (!DepartureTimeCheck(flightId))
                return Json(new { error = "Ошибка бронирования, можно только оплатить рейс!" });

            if (ModelState.IsValid)
			{
                var existingUser = Context.Users.FirstOrDefault(u => u.PassportNumber == user.PassportNumber);
                if (existingUser != null) //проверка на наличие пользователя в БД
                {
                    if(Context.Bookings.Any(b => b.UserId == existingUser.UserId && b.FlightId == flightId))//проверка на существование брони на этот же рейс
                    {
                        return Json(new { error = "У вас уже есть бронь на этот рейс!" });
                    }
                    else if(existingUser.UserName == user.UserName && existingUser.FirstName == user.FirstName && existingUser.LastName == user.LastName && existingUser.Email == user.Email)
                    {
                        return Json(new { userId = existingUser.UserId });
                    }
                    else
                    {
                        return Json(new { error = "Некорректный ввод данных!" });
                    }

                }
                else
                {
                    Context.Users.Add(user);
                    Context.SaveChanges();

                    return Json(new { userId = user.UserId });
                }
            }
			else
			{
                return View(user);
			}
		}

        //проверка на время
        private bool DepartureTimeCheck(int id)
        {
            var flight = Context.Flights.Find(id);
            TimeSpan timeSpan = flight.DepartureDate - DateTime.Now;

            if (timeSpan.TotalHours < 2)
                return false;
            else
                return true;
        }

		public IActionResult Index()
		{
            return View();
		}
	}
}
