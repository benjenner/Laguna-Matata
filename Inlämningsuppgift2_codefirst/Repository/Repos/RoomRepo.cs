using Inlämningsuppgift2_codefirst.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inlämningsuppgift2_codefirst.Repository.Repos
{
    public class RoomRepo
    {
        // Instansvariabel
        private readonly DataContext _context;

        public RoomRepo()
        {
            // Tilldelar instansvariabeln en ny instans
            _context = new DataContext();
        }

        ReservationRepo reservationRepo = new();

        public List<Room> GetAllRooms()
        {
            return _context.Rooms
                           .Include(r => r.RoomType)
                           .Include(r => r.Reservations)
                           .ToList();
        }


        // Ny metod som inte include'ar ID 
        public Room? GetRoomWithoutNavProp(int id)
        {
            return _context.Rooms
                           .SingleOrDefault(r => r.RoomID == id);
        }


        public Room? GetRoom(int id)
        {
            return _context.Rooms
                           .Include(r => r.RoomType)
                           .Include(r => r.Reservations)
                           .SingleOrDefault(r => r.RoomID == id);

        }

      

        public List<Room> GetAvailableRoom(DateOnly checkIn, DateOnly checkOut, int noGuests)
        {

            List<Reservation> reservations = reservationRepo.GetAllReservations();

            // Lista över alla reservationer med överlappande in- och utcheckning
            var unavailableRooms = reservations
                         .Where(r => r.CheckIn < checkOut && r.CheckOut > checkIn)
                         .ToList();


            List<Room> rooms = GetAllRooms();

            // Lista med alla otillgängliga rums-ID'n
            var unavailableRoomIDs = unavailableRooms
                                       .Select(r => r.Room.RoomID)
                                       .ToList();

            // Tar bort alla rum som överrenstämmer med IDn från unavailableRoomIDs
            rooms.RemoveAll(r => unavailableRoomIDs.Contains(r.RoomID));

            List<Room> availableRooms = new();

            // Selektion för antal gäster
            foreach (Room room in rooms)
            {
                if (room.RoomType.MaxCapacity >= noGuests)
                {
                    availableRooms.Add(room);
                }
            }

            return availableRooms;
        }


        public List<Room> GetAvailableRoomUpdate(DateOnly checkIn, DateOnly checkOut,
                                                 int noGuests, int reservationID)
        {

            List<Reservation> reservations = reservationRepo.GetAllReservations();

            // Lista över alla reservationer med överlappande in- och utcheckning
            var unavailableRooms = reservations
                         .Where(r => r.CheckIn < checkOut && r.CheckOut > checkIn
                          && r.ReservationID != reservationID)
                         .ToList();


            List<Room> rooms = GetAllRooms();

            // Lista med alla otillgängliga rums-ID'n
            var unavailableRoomIDs = unavailableRooms
                                       .Select(r => r.Room.RoomID)
                                       .ToList();

            // Tar bort alla rum som överrenstämmer med IDn från unavailableRoomIDs
            rooms.RemoveAll(r => unavailableRoomIDs.Contains(r.RoomID));

            List<Room> availableRooms = new();

            // Selektion för antal gäster
            foreach (Room room in rooms)
            {
                if (room.RoomType.MaxCapacity >= noGuests)
                {
                    availableRooms.Add(room);
                }
            }

            return availableRooms;
        }
    }
}
