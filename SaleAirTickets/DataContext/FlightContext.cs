using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using SaleAirTickets.Models;
using System.Linq.Expressions;

namespace SaleAirTickets.DataContext
{
    public class FlightContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Seat> Seats { get; set; }
       
        public FlightContext(DbContextOptions<FlightContext> options): base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City() { CityId = 1, Name = "Санкт-Петербург", Country = "Россия" },
                new City() { CityId = 2, Name = "Москва", Country = "Россия" },
                new City() { CityId = 3, Name = "Уфа", Country = "Россия" },
                new City() { CityId = 4, Name = "Анталья", Country = "Турция" },
                new City() { CityId = 5, Name = "Краснодар", Country = "Россия" },
                new City() { CityId = 6, Name = "Тольяти", Country = "Россия" },
                new City() { CityId = 7, Name = "Казань", Country = "Россия" },
                new City() { CityId = 8, Name = "Стамбул", Country = "Турция" },
                new City() { CityId = 9, Name = "Минск", Country = "Белоруссия" },
                new City() { CityId = 10, Name = "Абу-Даби", Country = "ОАЭ" }
            );

            modelBuilder.Entity<Airplane>().HasData(
                new Airplane() { AirplaneId = 1, AirplaneNumber = "ABS123", AirplaneType = "A380" },
                new Airplane() { AirplaneId = 2, AirplaneNumber = "JUR543", AirplaneType = "A380" },
                new Airplane() { AirplaneId = 3, AirplaneNumber = "OPW235", AirplaneType = "A380" }
            );

            modelBuilder.Entity<Flight>().HasData(
                new Flight() {FlightId = 1, DepartureCityId=1, ArrivalCityId = 3, DepartureDate = new DateTime(2024, 7, 15, 5, 30, 0 ), ArrivalDate = new DateTime(2024, 7, 15, 10, 30, 0), AirplaneId = 2, EconomyClassPrice = 9000, BuisnessClassPrice=20000 },
				new Flight() { FlightId = 2, DepartureCityId = 4, ArrivalCityId = 5, DepartureDate = new DateTime(2024, 7, 24, 7, 30, 0), ArrivalDate = new DateTime(2024, 7, 24, 14, 35, 0), AirplaneId = 1, EconomyClassPrice = 17000, BuisnessClassPrice = 52000 },
				new Flight() { FlightId = 3, DepartureCityId = 1, ArrivalCityId = 2, DepartureDate = new DateTime(2024, 7, 1, 4, 30, 0), ArrivalDate = new DateTime(2024, 7, 1, 6, 30, 0), AirplaneId = 3, EconomyClassPrice = 13000, BuisnessClassPrice = 35000 },
				new Flight() { FlightId = 4, DepartureCityId = 3, ArrivalCityId = 7, DepartureDate = new DateTime(2024, 7, 1, 8, 15, 0), ArrivalDate = new DateTime(2024, 7, 1, 10, 15, 0), AirplaneId = 1, EconomyClassPrice = 11000, BuisnessClassPrice = 25000 },
				new Flight() { FlightId = 5, DepartureCityId = 1, ArrivalCityId = 3, DepartureDate = new DateTime(2024, 7, 15, 10, 30, 0), ArrivalDate = new DateTime(2024, 7, 15, 13, 55, 0), AirplaneId = 3, EconomyClassPrice = 14000, BuisnessClassPrice = 42000 }
				);

            List<Seat> seats = new List<Seat>();

            int k = 1;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 30; j++)
                {
                    if (j % 10 == 0)
                        seats.Add(new Seat() { SeatId = k++, FlightId = i + 1, SeatNumber = j + 1, ClassType = "Business", IsAvailable = true });
                    else
						seats.Add(new Seat() { SeatId = k++, FlightId = i + 1, SeatNumber = j + 1, ClassType = "Economy", IsAvailable = true });
				}
            }

            modelBuilder.Entity<Seat>().HasData(seats);
		}
    }
}
