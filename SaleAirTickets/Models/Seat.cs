using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SaleAirTickets.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int FlightId { get; set; }
        public int SeatNumber { get; set; }
        public string ClassType { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;

        [ValidateNever]
        public Flight Flight { get; set; } = null!;
    }
}
