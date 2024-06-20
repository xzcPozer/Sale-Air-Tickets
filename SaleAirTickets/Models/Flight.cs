using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SaleAirTickets.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public int DepartureCityId { get; set; }
        public int ArrivalCityId { get; set; }
		public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int AirplaneId { get; set; }
        public decimal EconomyClassPrice { get; set; }
        public decimal BuisnessClassPrice { get; set; }


        [ValidateNever]
        public City DepartureCity { get; set; } = null!;

		[ValidateNever]
		public City ArrivalCity { get; set; } = null!;

        [ValidateNever]
        public Airplane Airplane { get; set; } = null!;
    }
}
