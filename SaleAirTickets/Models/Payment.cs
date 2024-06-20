using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SaleAirTickets.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public decimal PaymentAmount { get; set; }

        [ValidateNever]
        public Booking Booking { get; set; } = null!;
    }
}
