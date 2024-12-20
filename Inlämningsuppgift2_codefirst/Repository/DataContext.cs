using Inlämningsuppgift2_codefirst.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace Inlämningsuppgift2_codefirst.Repository
{
    public class DataContext:DbContext
    {
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            optionsBuilder.UseSqlServer(connString);
        }


        public virtual DbSet<Room> Rooms { get; set; }

        public virtual DbSet<Guest> Guests { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<Reservation> Reservations { get; set; }

        public virtual DbSet<RoomType> RoomTypes { get; set; }
    }
}
