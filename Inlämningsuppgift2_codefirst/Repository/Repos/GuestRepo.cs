using Inlämningsuppgift2_codefirst.Repository.Entities;

namespace Inlämningsuppgift2_codefirst.Repository.Repos
{
    public class GuestRepo
    {
        // Instansvariabel
        private readonly DataContext _context;

        public GuestRepo()
        {
            // Tilldelar instansvariabeln en ny instans
            _context = new DataContext();
        }

        ReservationRepo reservationRepo = new();
        public List<Guest> GetAllGuests()
        {
            return _context.Guests.ToList();
        }

        public Guest GetGuest(int id)
        {
            return _context.Guests.SingleOrDefault(g => g.GuestId == id);

        }

        public void CreateGuest(Guest guest)
        {
            _context.Guests.Add(guest);
            _context.SaveChanges();
        }

        public int CreateGuestReturnID(Guest guest)
        {
            _context.Guests.Add(guest);
            _context.SaveChanges();
            return guest.GuestId;
        }

        public void DeleteGuest(int id)
        {
            Guest guest = GetGuest(id);
            List <Reservation> reservations = reservationRepo.GetAllReservations();

            bool deleteGuest = true;

            foreach (var reservation in reservations)
            {
                foreach (var resGuest in reservation.Guests)
                {
                    if (resGuest.GuestId == id)
                    {
                        deleteGuest = false;
                        break;
                    }
                }
            }

            if (deleteGuest)
            {
                _context.Guests.Remove(guest);
                _context.SaveChanges();
                MessageBox.Show("Guest deleted");
            }
            else
            {
                MessageBox.Show("Guest has an existing reservation, " +
                                "delete reservation first.");
            }
        }
          
                                     
       
        

        public void UpdateGuest(Guest newGuest)
        {
            Guest originalGuest = GetGuest(newGuest.GuestId);

            _context.Entry(originalGuest).CurrentValues.SetValues(newGuest);

            _context.SaveChanges();

        }
    }
}
