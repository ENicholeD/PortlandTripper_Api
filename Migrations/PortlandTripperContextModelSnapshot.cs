﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortlandTripper.Models;

namespace PortlandTripperApi.Migrations
{
    [DbContext(typeof(PortlandTripperContext))]
    partial class PortlandTripperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("PortlandTripper.Models.TripAdvisor", b =>
                {
                    b.Property<int>("TripAdvisorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Cost");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Hours")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("TimeOfDay")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("TripAdvisorId");

                    b.ToTable("TripAdvisor");

                    b.HasData(
                        new
                        {
                            TripAdvisorId = 1,
                            Address = "2921 NE Killingsworth St, Portland, OR 97211",
                            Cost = 8,
                            Description = "Local, award-winning coffe roaster.",
                            Hours = "6am to 6pm",
                            Name = "Extracto",
                            TimeOfDay = "Morning"
                        },
                        new
                        {
                            TripAdvisorId = 2,
                            Address = "1223 SE Powell, Portland, OR 97202",
                            Cost = 8,
                            Description = "24-hour cafe that also serves breakfast.",
                            Hours = "24 hours",
                            Name = "Southeast Grind",
                            TimeOfDay = "Morning"
                        },
                        new
                        {
                            TripAdvisorId = 3,
                            Address = "4811 SE Hawthorne Bvld., Portland, OR 97215",
                            Cost = 15,
                            Description = "Arcade games and drinks.",
                            Hours = "3pm - 1am",
                            Name = "QuarterWorld",
                            TimeOfDay = "Afternoon"
                        },
                        new
                        {
                            TripAdvisorId = 4,
                            Address = "611 SW Kingston Ave., Portland OR 97205",
                            Cost = 17,
                            Description = "Japanese-themed garden with special events.",
                            Hours = "10am-4pm",
                            Name = "Japanese Garden",
                            TimeOfDay = "Afternoon"
                        },
                        new
                        {
                            TripAdvisorId = 5,
                            Address = "1507 SE 39th Ave., Portland OR 97214",
                            Cost = 18,
                            Description = "Bands and drinks.",
                            Hours = "6:30pm-2am",
                            Name = "Hawthorne Theater and Lounge",
                            TimeOfDay = "Evening"
                        },
                        new
                        {
                            TripAdvisorId = 6,
                            Address = "1332 W Burnside, Portland OR 97209",
                            Cost = 70,
                            Description = "Bands and drinks.",
                            Hours = "6:30pm-2am",
                            Name = "Crystal Ballroom",
                            TimeOfDay = "Evening"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
