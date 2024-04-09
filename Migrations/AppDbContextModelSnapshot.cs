﻿// <auto-generated />
using System;
using Backend.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.DataAccess.Models.Maker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Makers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "TATA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Maruti Suzuki"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Nissan"
                        });
                });

            modelBuilder.Entity("Backend.DataAccess.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MakerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MakerId = 1,
                            Name = "Nexon"
                        },
                        new
                        {
                            Id = 2,
                            MakerId = 2,
                            Name = "Swift"
                        },
                        new
                        {
                            Id = 3,
                            MakerId = 3,
                            Name = "i20"
                        },
                        new
                        {
                            Id = 4,
                            MakerId = 4,
                            Name = "Magnite"
                        },
                        new
                        {
                            Id = 5,
                            MakerId = 3,
                            Name = "Aura"
                        });
                });

            modelBuilder.Entity("Backend.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            EndDate = new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CarId = 2,
                            EndDate = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CarId = 3,
                            EndDate = new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CarId = 4,
                            EndDate = new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Backend.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://media.zigcdn.com/media/model/2023/Sep/front-1-4-left-1008362956_930x620.jpg",
                            Maker = "TATA",
                            Model = "Nexon",
                            Price = 2000m,
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://media.zigcdn.com/media/model/2023/Feb/swift_930x620.jpg",
                            Maker = "Maruti Suzuki",
                            Model = "Swift",
                            Price = 1500m,
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://media.zigcdn.com/media/model/2023/Sep/i20_930x620.jpg",
                            Maker = "Hyundai",
                            Model = "i20",
                            Price = 1700m,
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://media.zigcdn.com/media/model/2020/Oct/magnite3_930x620.jpg",
                            Maker = "Nissan",
                            Model = "Magnite",
                            Price = 2500m,
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://media.zigcdn.com/media/model/2023/Mar/front-1-4-left-1573690002_930x620.jpg",
                            Maker = "Hyundai",
                            Model = "Aura",
                            Price = 3000m,
                            Status = true
                        });
                });

            modelBuilder.Entity("Backend.DataAccess.Models.Model", b =>
                {
                    b.HasOne("Backend.DataAccess.Models.Maker", "Maker")
                        .WithMany("Models")
                        .HasForeignKey("MakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Maker");
                });

            modelBuilder.Entity("Backend.Models.Booking", b =>
                {
                    b.HasOne("Backend.Models.Car", null)
                        .WithMany("Bookings")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.DataAccess.Models.Maker", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Backend.Models.Car", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}