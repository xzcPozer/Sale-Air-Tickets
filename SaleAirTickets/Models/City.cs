using System.ComponentModel.DataAnnotations;

namespace SaleAirTickets.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
     }
}
