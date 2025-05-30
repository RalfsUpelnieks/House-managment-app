﻿// <auto-generated />
using System;
using HousingManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HousingManagementAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HousingManagementAPI.Models.Apartment", b =>
                {
                    b.Property<int>("ApartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApartmentId"));

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<double>("LivingArea")
                        .HasColumnType("float");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidentCount")
                        .HasColumnType("int");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.Property<double>("TotalArea")
                        .HasColumnType("float");

                    b.HasKey("ApartmentId");

                    b.HasIndex("HouseId");

                    b.ToTable("Apartment");

                    b.HasData(
                        new
                        {
                            ApartmentId = 1,
                            Floor = 1,
                            HouseId = 1,
                            LivingArea = 60.0,
                            Number = "1A",
                            ResidentCount = 2,
                            RoomCount = 3,
                            TotalArea = 80.0
                        },
                        new
                        {
                            ApartmentId = 2,
                            Floor = 2,
                            HouseId = 1,
                            LivingArea = 40.0,
                            Number = "2A",
                            ResidentCount = 1,
                            RoomCount = 2,
                            TotalArea = 50.0
                        },
                        new
                        {
                            ApartmentId = 3,
                            Floor = 1,
                            HouseId = 2,
                            LivingArea = 70.0,
                            Number = "1B",
                            ResidentCount = 1,
                            RoomCount = 4,
                            TotalArea = 90.0
                        },
                        new
                        {
                            ApartmentId = 4,
                            Floor = 2,
                            HouseId = 2,
                            LivingArea = 45.0,
                            Number = "2B",
                            ResidentCount = 1,
                            RoomCount = 2,
                            TotalArea = 60.0
                        },
                        new
                        {
                            ApartmentId = 5,
                            Floor = 3,
                            HouseId = 2,
                            LivingArea = 100.0,
                            Number = "3B",
                            ResidentCount = 1,
                            RoomCount = 5,
                            TotalArea = 120.0
                        });
                });

            modelBuilder.Entity("HousingManagementAPI.Models.ApartmentResident", b =>
                {
                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.HasKey("ApartmentId", "ResidentId");

                    b.HasIndex("ResidentId");

                    b.ToTable("ApartmentResident");

                    b.HasData(
                        new
                        {
                            ApartmentId = 1,
                            ResidentId = 1,
                            IsOwner = true
                        },
                        new
                        {
                            ApartmentId = 1,
                            ResidentId = 2,
                            IsOwner = false
                        },
                        new
                        {
                            ApartmentId = 2,
                            ResidentId = 2,
                            IsOwner = false
                        },
                        new
                        {
                            ApartmentId = 3,
                            ResidentId = 3,
                            IsOwner = false
                        },
                        new
                        {
                            ApartmentId = 4,
                            ResidentId = 4,
                            IsOwner = false
                        },
                        new
                        {
                            ApartmentId = 5,
                            ResidentId = 1,
                            IsOwner = true
                        });
                });

            modelBuilder.Entity("HousingManagementAPI.Models.House", b =>
                {
                    b.Property<int>("HouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HouseId");

                    b.ToTable("House");

                    b.HasData(
                        new
                        {
                            HouseId = 1,
                            City = "Riga",
                            Country = "Latvia",
                            Number = "1",
                            PostalCode = "LV-1010",
                            Street = "Main St"
                        },
                        new
                        {
                            HouseId = 2,
                            City = "Riga",
                            Country = "Latvia",
                            Number = "2",
                            PostalCode = "LV-1020",
                            Street = "Second St"
                        });
                });

            modelBuilder.Entity("HousingManagementAPI.Models.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResidentId");

                    b.ToTable("Resident");

                    b.HasData(
                        new
                        {
                            ResidentId = 1,
                            BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PersonalCode = "010101-12345",
                            Phone = "12345678"
                        },
                        new
                        {
                            ResidentId = 2,
                            BirthDate = new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PersonalCode = "020202-67890",
                            Phone = "87654321"
                        },
                        new
                        {
                            ResidentId = 3,
                            BirthDate = new DateTime(2000, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            PersonalCode = "030303-54321",
                            Phone = "12312312"
                        },
                        new
                        {
                            ResidentId = 4,
                            BirthDate = new DateTime(1995, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob.brown@example.com",
                            FirstName = "Bob",
                            LastName = "Brown",
                            PersonalCode = "040404-98765",
                            Phone = "32132132"
                        });
                });

            modelBuilder.Entity("HousingManagementAPI.Models.Apartment", b =>
                {
                    b.HasOne("HousingManagementAPI.Models.House", "House")
                        .WithMany("Apartments")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");
                });

            modelBuilder.Entity("HousingManagementAPI.Models.ApartmentResident", b =>
                {
                    b.HasOne("HousingManagementAPI.Models.Apartment", "Apartment")
                        .WithMany("ApartmentResidents")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingManagementAPI.Models.Resident", "Resident")
                        .WithMany("ApartmentResidents")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("HousingManagementAPI.Models.Apartment", b =>
                {
                    b.Navigation("ApartmentResidents");
                });

            modelBuilder.Entity("HousingManagementAPI.Models.House", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("HousingManagementAPI.Models.Resident", b =>
                {
                    b.Navigation("ApartmentResidents");
                });
#pragma warning restore 612, 618
        }
    }
}
