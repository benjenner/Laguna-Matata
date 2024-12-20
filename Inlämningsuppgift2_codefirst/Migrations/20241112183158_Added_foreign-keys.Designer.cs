﻿// <auto-generated />
using System;
using Inlämningsuppgift2_codefirst.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inlämningsuppgift2_codefirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241112183158_Added_foreign-keys")]
    partial class Added_foreignkeys
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GuestReservation", b =>
                {
                    b.Property<int>("GuestsGuestId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationsReservationID")
                        .HasColumnType("int");

                    b.HasKey("GuestsGuestId", "ReservationsReservationID");

                    b.HasIndex("ReservationsReservationID");

                    b.ToTable("GuestReservation");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuestId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsReservationHolder")
                        .HasMaxLength(50)
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly>("DateOfPayment")
                        .HasColumnType("date");

                    b.Property<bool>("IsPayed")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("LastDayOfPayment")
                        .HasColumnType("date");

                    b.HasKey("InvoiceID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Reservation", b =>
                {
                    b.Property<int>("ReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationID"));

                    b.Property<DateOnly>("CheckIn")
                        .HasColumnType("date");

                    b.Property<DateOnly>("CheckOut")
                        .HasColumnType("date");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("int");

                    b.Property<int>("NoExtraBeds")
                        .HasColumnType("int");

                    b.Property<string>("ReservationHolder")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("ReservationID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("RoomID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeID")
                        .HasColumnType("int");

                    b.HasKey("RoomID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.RoomType", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeID"));

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<int>("NoExtraBeds")
                        .HasColumnType("int");

                    b.Property<string>("RoomTypeName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("RoomTypeID");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("GuestReservation", b =>
                {
                    b.HasOne("Inlämningsuppgift2_codefirst.Repository.Entities.Guest", null)
                        .WithMany()
                        .HasForeignKey("GuestsGuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inlämningsuppgift2_codefirst.Repository.Entities.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsReservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Reservation", b =>
                {
                    b.HasOne("Inlämningsuppgift2_codefirst.Repository.Entities.Invoice", "Invoice")
                        .WithMany("Reservations")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inlämningsuppgift2_codefirst.Repository.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Room", b =>
                {
                    b.HasOne("Inlämningsuppgift2_codefirst.Repository.Entities.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Invoice", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.Room", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Inlämningsuppgift2_codefirst.Repository.Entities.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
