using SaleAirTickets.DataContext;

namespace SaleAirTickets.Services.BackgroundService.DeleteFlight
{
    public class DeleteFlight: IDeleteFlight
    {

        private readonly FlightContext Context;

        public DeleteFlight(FlightContext ctx)
        {
            Context = ctx;
        }

        public void DeleteFlights()
        {
            var flightsToDelete = Context.Flights
            .Where(f => f.DepartureDate < DateTime.Now.AddMinutes(60)).ToList();

            if(flightsToDelete.Count > 0)
            {
                Context.Flights.RemoveRange(flightsToDelete);
                Context.SaveChanges();
            }
        }
    }
}
