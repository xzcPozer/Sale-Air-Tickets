using System.ComponentModel.DataAnnotations;

namespace SaleAirTickets.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Введите имя пользователя!")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите фамилию пользователя!")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите отчество пользователя!")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите почту для отправки билета!")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите серию и номер паспорта!")]
        public string PassportNumber { get; set; } = string.Empty;
    }
}
