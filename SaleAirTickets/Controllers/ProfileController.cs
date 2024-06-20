using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using SaleAirTickets.DataContext;
using SaleAirTickets.Models;

namespace SaleAirTickets.Controllers
{
    public class ProfileController : Controller
    {
        private FlightContext Context { get; set; }

        public ProfileController(FlightContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult EnterTheProfile()
        {
            ViewBag.Action = "Вход в профиль";
            return View("LogIn", new User());
        }

        [HttpPost]
        public IActionResult LogIn(User user)
        {
            if (ModelState["LastName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["FirstName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["UserName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["PassportNumber"].ValidationState == ModelValidationState.Invalid)
            {
                return View(user);
            }

            //проверка наличия пользователя по полю серия и номер паспорта
            var existingUser = Context.Users.FirstOrDefault(u => u.PassportNumber == user.PassportNumber);
            if (existingUser != null && existingUser.UserName == user.UserName && existingUser.FirstName == user.FirstName && existingUser.LastName == user.LastName)
            {
                //открываем страницу профиля с данными для текущего пользователя (поиск по id)
                return RedirectToAction("ShowProfile", new { userId = existingUser.UserId });
            }
            else
            {
                ModelState.AddModelError("", "Пользователь с такими данными не найден");
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult ShowProfile(int userId)
        {
            User user = Context.Users.FirstOrDefault(u => u.UserId == userId);
            ViewBag.Bookings = Context.Bookings
                .Where(s => s.UserId == userId)
                .Include(f => f.Flight.Airplane)
                .ToList();

            ViewBag.Action = "Профиль";
            return View(user);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
