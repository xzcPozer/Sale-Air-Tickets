using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleAirTickets.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Airplanes_AirplaneId",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "AirplaneId",
                table: "Seats",
                newName: "FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_AirplaneId",
                table: "Seats",
                newName: "IX_Seats_FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Flights_FlightId",
                table: "Seats",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Flights_FlightId",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "Seats",
                newName: "AirplaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_FlightId",
                table: "Seats",
                newName: "IX_Seats_AirplaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Airplanes_AirplaneId",
                table: "Seats",
                column: "AirplaneId",
                principalTable: "Airplanes",
                principalColumn: "AirplaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
