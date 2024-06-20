using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;

namespace SaleAirTickets.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public void Sendemail(EmailDto request)
        {
            try
            {
				var email = new MimeMessage();
				email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
				email.To.Add(MailboxAddress.Parse(request.To));
				email.Subject = request.Subject;
				email.Body = new TextPart(TextFormat.Text) { Text = request.Body };

				using var smtp = new SmtpClient();
				smtp.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
				smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
				smtp.Send(email);
				smtp.Disconnect(true);
			}
            catch { }
        }
    }
}
