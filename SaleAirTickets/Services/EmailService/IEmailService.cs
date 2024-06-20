using SaleAirTickets.Models;

namespace SaleAirTickets.Services.EmailService
{
    public interface IEmailService
    {
        void Sendemail(EmailDto request);
    }
}
