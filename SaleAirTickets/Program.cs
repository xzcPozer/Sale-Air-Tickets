global using SaleAirTickets.Services.EmailService;
global using SaleAirTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SaleAirTickets.DataContext;
using Hangfire;
using Microsoft.Extensions.DependencyInjection;
using SaleAirTickets.Controllers;
using SaleAirTickets.Services.BackgroundService.BookingCancellation;
using SaleAirTickets.Services.BackgroundService.DeleteFlight;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//add EF core Dependency 
builder.Services.AddDbContext<FlightContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlightContext")));

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IBookingCancelation, BookingCancellation>();
builder.Services.AddScoped<IDeleteFlight, DeleteFlight>();

// Add Hangfire client services
builder.Services.AddHangfire(config =>
{
	config.UseSqlServerStorage(builder.Configuration.GetConnectionString("FlightContext"));
});

builder.Services.AddHangfireServer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Add recurring jobs
app.Lifetime.ApplicationStarted.Register(() =>
{
    using (var scope = app.Services.CreateScope())
    {
        var serviceProvider = scope.ServiceProvider;
        var bookingCancellationService = serviceProvider.GetService<IBookingCancelation>();
        var deleteFlightService = serviceProvider.GetService<IDeleteFlight>();

        RecurringJob.AddOrUpdate("cancel-bookings", () => bookingCancellationService.CancelBookings(), Cron.Hourly());
        RecurringJob.AddOrUpdate("delete-flights", () => deleteFlightService.DeleteFlights(), Cron.Hourly());
    }
});



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
