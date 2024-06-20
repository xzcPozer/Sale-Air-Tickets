using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaleAirTickets.Migrations
{
    /// <inheritdoc />
    public partial class AddTestDataFlightAndSeat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirplaneId", "ArrivalCityId", "ArrivalDate", "BuisnessClassPrice", "DepartureCityId", "DepartureDate", "EconomyClassPrice" },
                values: new object[,]
                {
                    { 1, 2, 3, new DateTime(2024, 7, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), 20000m, 1, new DateTime(2024, 7, 15, 5, 30, 0, 0, DateTimeKind.Unspecified), 9000m },
                    { 2, 1, 5, new DateTime(2024, 7, 24, 14, 35, 0, 0, DateTimeKind.Unspecified), 52000m, 4, new DateTime(2024, 7, 24, 7, 30, 0, 0, DateTimeKind.Unspecified), 17000m },
                    { 3, 3, 2, new DateTime(2024, 7, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 35000m, 1, new DateTime(2024, 7, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 13000m },
                    { 4, 1, 7, new DateTime(2024, 7, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 25000m, 3, new DateTime(2024, 7, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), 11000m },
                    { 5, 3, 3, new DateTime(2024, 7, 15, 13, 55, 0, 0, DateTimeKind.Unspecified), 42000m, 1, new DateTime(2024, 7, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), 14000m }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "ClassType", "FlightId", "IsAvailable", "SeatNumber" },
                values: new object[,]
                {
                    { 1, "Business", 1, true, 1 },
                    { 2, "Economy", 1, true, 2 },
                    { 3, "Economy", 1, true, 3 },
                    { 4, "Economy", 1, true, 4 },
                    { 5, "Economy", 1, true, 5 },
                    { 6, "Economy", 1, true, 6 },
                    { 7, "Economy", 1, true, 7 },
                    { 8, "Economy", 1, true, 8 },
                    { 9, "Economy", 1, true, 9 },
                    { 10, "Economy", 1, true, 10 },
                    { 11, "Business", 1, true, 11 },
                    { 12, "Economy", 1, true, 12 },
                    { 13, "Economy", 1, true, 13 },
                    { 14, "Economy", 1, true, 14 },
                    { 15, "Economy", 1, true, 15 },
                    { 16, "Economy", 1, true, 16 },
                    { 17, "Economy", 1, true, 17 },
                    { 18, "Economy", 1, true, 18 },
                    { 19, "Economy", 1, true, 19 },
                    { 20, "Economy", 1, true, 20 },
                    { 21, "Business", 1, true, 21 },
                    { 22, "Economy", 1, true, 22 },
                    { 23, "Economy", 1, true, 23 },
                    { 24, "Economy", 1, true, 24 },
                    { 25, "Economy", 1, true, 25 },
                    { 26, "Economy", 1, true, 26 },
                    { 27, "Economy", 1, true, 27 },
                    { 28, "Economy", 1, true, 28 },
                    { 29, "Economy", 1, true, 29 },
                    { 30, "Economy", 1, true, 30 },
                    { 31, "Business", 2, true, 1 },
                    { 32, "Economy", 2, true, 2 },
                    { 33, "Economy", 2, true, 3 },
                    { 34, "Economy", 2, true, 4 },
                    { 35, "Economy", 2, true, 5 },
                    { 36, "Economy", 2, true, 6 },
                    { 37, "Economy", 2, true, 7 },
                    { 38, "Economy", 2, true, 8 },
                    { 39, "Economy", 2, true, 9 },
                    { 40, "Economy", 2, true, 10 },
                    { 41, "Business", 2, true, 11 },
                    { 42, "Economy", 2, true, 12 },
                    { 43, "Economy", 2, true, 13 },
                    { 44, "Economy", 2, true, 14 },
                    { 45, "Economy", 2, true, 15 },
                    { 46, "Economy", 2, true, 16 },
                    { 47, "Economy", 2, true, 17 },
                    { 48, "Economy", 2, true, 18 },
                    { 49, "Economy", 2, true, 19 },
                    { 50, "Economy", 2, true, 20 },
                    { 51, "Business", 2, true, 21 },
                    { 52, "Economy", 2, true, 22 },
                    { 53, "Economy", 2, true, 23 },
                    { 54, "Economy", 2, true, 24 },
                    { 55, "Economy", 2, true, 25 },
                    { 56, "Economy", 2, true, 26 },
                    { 57, "Economy", 2, true, 27 },
                    { 58, "Economy", 2, true, 28 },
                    { 59, "Economy", 2, true, 29 },
                    { 60, "Economy", 2, true, 30 },
                    { 61, "Business", 3, true, 1 },
                    { 62, "Economy", 3, true, 2 },
                    { 63, "Economy", 3, true, 3 },
                    { 64, "Economy", 3, true, 4 },
                    { 65, "Economy", 3, true, 5 },
                    { 66, "Economy", 3, true, 6 },
                    { 67, "Economy", 3, true, 7 },
                    { 68, "Economy", 3, true, 8 },
                    { 69, "Economy", 3, true, 9 },
                    { 70, "Economy", 3, true, 10 },
                    { 71, "Business", 3, true, 11 },
                    { 72, "Economy", 3, true, 12 },
                    { 73, "Economy", 3, true, 13 },
                    { 74, "Economy", 3, true, 14 },
                    { 75, "Economy", 3, true, 15 },
                    { 76, "Economy", 3, true, 16 },
                    { 77, "Economy", 3, true, 17 },
                    { 78, "Economy", 3, true, 18 },
                    { 79, "Economy", 3, true, 19 },
                    { 80, "Economy", 3, true, 20 },
                    { 81, "Business", 3, true, 21 },
                    { 82, "Economy", 3, true, 22 },
                    { 83, "Economy", 3, true, 23 },
                    { 84, "Economy", 3, true, 24 },
                    { 85, "Economy", 3, true, 25 },
                    { 86, "Economy", 3, true, 26 },
                    { 87, "Economy", 3, true, 27 },
                    { 88, "Economy", 3, true, 28 },
                    { 89, "Economy", 3, true, 29 },
                    { 90, "Economy", 3, true, 30 },
                    { 91, "Business", 4, true, 1 },
                    { 92, "Economy", 4, true, 2 },
                    { 93, "Economy", 4, true, 3 },
                    { 94, "Economy", 4, true, 4 },
                    { 95, "Economy", 4, true, 5 },
                    { 96, "Economy", 4, true, 6 },
                    { 97, "Economy", 4, true, 7 },
                    { 98, "Economy", 4, true, 8 },
                    { 99, "Economy", 4, true, 9 },
                    { 100, "Economy", 4, true, 10 },
                    { 101, "Business", 4, true, 11 },
                    { 102, "Economy", 4, true, 12 },
                    { 103, "Economy", 4, true, 13 },
                    { 104, "Economy", 4, true, 14 },
                    { 105, "Economy", 4, true, 15 },
                    { 106, "Economy", 4, true, 16 },
                    { 107, "Economy", 4, true, 17 },
                    { 108, "Economy", 4, true, 18 },
                    { 109, "Economy", 4, true, 19 },
                    { 110, "Economy", 4, true, 20 },
                    { 111, "Business", 4, true, 21 },
                    { 112, "Economy", 4, true, 22 },
                    { 113, "Economy", 4, true, 23 },
                    { 114, "Economy", 4, true, 24 },
                    { 115, "Economy", 4, true, 25 },
                    { 116, "Economy", 4, true, 26 },
                    { 117, "Economy", 4, true, 27 },
                    { 118, "Economy", 4, true, 28 },
                    { 119, "Economy", 4, true, 29 },
                    { 120, "Economy", 4, true, 30 },
                    { 121, "Business", 5, true, 1 },
                    { 122, "Economy", 5, true, 2 },
                    { 123, "Economy", 5, true, 3 },
                    { 124, "Economy", 5, true, 4 },
                    { 125, "Economy", 5, true, 5 },
                    { 126, "Economy", 5, true, 6 },
                    { 127, "Economy", 5, true, 7 },
                    { 128, "Economy", 5, true, 8 },
                    { 129, "Economy", 5, true, 9 },
                    { 130, "Economy", 5, true, 10 },
                    { 131, "Business", 5, true, 11 },
                    { 132, "Economy", 5, true, 12 },
                    { 133, "Economy", 5, true, 13 },
                    { 134, "Economy", 5, true, 14 },
                    { 135, "Economy", 5, true, 15 },
                    { 136, "Economy", 5, true, 16 },
                    { 137, "Economy", 5, true, 17 },
                    { 138, "Economy", 5, true, 18 },
                    { 139, "Economy", 5, true, 19 },
                    { 140, "Economy", 5, true, 20 },
                    { 141, "Business", 5, true, 21 },
                    { 142, "Economy", 5, true, 22 },
                    { 143, "Economy", 5, true, 23 },
                    { 144, "Economy", 5, true, 24 },
                    { 145, "Economy", 5, true, 25 },
                    { 146, "Economy", 5, true, 26 },
                    { 147, "Economy", 5, true, 27 },
                    { 148, "Economy", 5, true, 28 },
                    { 149, "Economy", 5, true, 29 },
                    { 150, "Economy", 5, true, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5);
        }
    }
}
