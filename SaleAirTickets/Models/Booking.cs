using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SaleAirTickets.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
		public int UserId { get; set; }
		public int FlightId { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;


		[ValidateNever]
		public Flight Flight { get; set; } = null!;

        [ValidateNever]
        public Payment Payment { get; set; } = null!;

        [ValidateNever]
        public User User { get; set; } = null!;
    }
}
