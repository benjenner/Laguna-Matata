using Inlämningsuppgift2_codefirst.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inlämningsuppgift2_codefirst.Repository.Repos
{
    public class ReservationRepo
    {
        // Instansvariabel
        private readonly DataContext _context;

        public ReservationRepo()
        {
            // Tilldelar instansvariabeln en ny instans
            _context = new DataContext();
        }


        public List<Reservation>? GetAllReservations()
        {
            return _context.Reservations
                           .Include(r => r.Guests)
                           .Include(r => r.Room)
                           .Include(r => r.Invoice)
                           // lägg till as no tracking
                           .ToList();
        }

        public Reservation? GetReservation(int id)
        {
            return _context.Reservations
                           .Include(r => r.Guests)
                           .Include(r => r.Room)
                           .Include(r => r.Invoice)
                           .SingleOrDefault(r => r.ReservationID == id);

        }

        public void CreateReservation(Reservation reservation)
        {

            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public void DeleteReservation(int id)
        {
            try
            {
                Reservation reservation = GetReservation(id);

                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
            catch
            {

            }
        }

        public void UpdateReservation(Reservation newReservation)
        {
            
            Reservation? originalReservation = GetReservation(newReservation.ReservationID);

            _context.Entry(originalReservation).CurrentValues.SetValues(newReservation);

            _context.SaveChanges();
            

         
        }
    }
}
