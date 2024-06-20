﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaleAirTickets.DataContext;

#nullable disable

namespace SaleAirTickets.Migrations
{
    [DbContext(typeof(FlightContext))]
    [Migration("20240531092911_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SaleAirTickets.Models.Airplane", b =>
                {
                    b.Property<int>("AirplaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AirplaneId"));

                    b.Property<string>("AirplaneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirplaneType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AirplaneId");

                    b.ToTable("Airplanes");

                    b.HasData(
                        new
                        {
                            AirplaneId = 1,
                            AirplaneNumber = "ABS123",
                            AirplaneType = "A380"
                        },
                        new
                        {
                            AirplaneId = 2,
                            AirplaneNumber = "JUR543",
                            AirplaneType = "A380"
                        },
                        new
                        {
                            AirplaneId = 3,
                            AirplaneNumber = "OPW235",
                            AirplaneType = "A380"
                        });
                });

            modelBuilder.Entity("SaleAirTickets.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("FlightId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("SaleAirTickets.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Country = "Россия",
                            Name = "Санкт-Петербург"
                        },
                        new
                        {
                            CityId = 2,
                            Country = "Россия",
                            Name = "Москва"
                        },
                        new
                        {
                            CityId = 3,
                            Country = "Россия",
                            Name = "Уфа"
                        },
                        new
                        {
                            CityId = 4,
                            Country = "Турция",
                            Name = "Анталья"
                        },
                        new
                        {
                            CityId = 5,
                            Country = "Россия",
                            Name = "Краснодар"
                        },
                        new
                        {
                            CityId = 6,
                            Country = "Россия",
                            Name = "Тольяти"
                        },
                        new
                        {
                            CityId = 7,
                            Country = "Россия",
                            Name = "Казань"
                        },
                        new
                        {
                            CityId = 8,
                            Country = "Турция",
                            Name = "Стамбул"
                        },
                        new
                        {
                            CityId = 9,
                            Country = "Белоруссия",
                            Name = "Минск"
                        },
                        new
                        {
                            CityId = 10,
                            Country = "ОАЭ",
                            Name = "Абу-Даби"
                        });
                });

            modelBuilder.Entity("SaleAirTickets.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"));

                    b.Property<int>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<int>("ArrivalCityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BuisnessClassPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DepartureCityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("EconomyClassPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FlightId");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("ArrivalCityId");

                    b.HasIndex("DepartureCityId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("SaleAirTickets.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("SaleAirTickets.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"));

                    b.Property<int>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<string>("ClassType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatId");

                    b.HasIndex("AirplaneId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("SaleAirTickets.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SaleAirTickets.Models.Booking", b =>
                {
                    b.HasOne("SaleAirTickets.Models.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleAirTickets.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SaleAirTickets.Models.Flight", b =>
                {
                    b.HasOne("SaleAirTickets.Models.Airplane", "Airplane")
                        .WithMany()
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleAirTickets.Models.City", "ArrivalCity")
                        .WithMany()
                        .HasForeignKey("ArrivalCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleAirTickets.Models.City", "DepartureCity")
                        .WithMany()
                        .HasForeignKey("DepartureCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplane");

                    b.Navigation("ArrivalCity");

                    b.Navigation("DepartureCity");
                });

            modelBuilder.Entity("SaleAirTickets.Models.Payment", b =>
                {
                    b.HasOne("SaleAirTickets.Models.Booking", "Booking")
                        .WithOne("Payment")
                        .HasForeignKey("SaleAirTickets.Models.Payment", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("SaleAirTickets.Models.Seat", b =>
                {
                    b.HasOne("SaleAirTickets.Models.Airplane", "Airplane")
                        .WithMany()
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplane");
                });

            modelBuilder.Entity("SaleAirTickets.Models.Booking", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
