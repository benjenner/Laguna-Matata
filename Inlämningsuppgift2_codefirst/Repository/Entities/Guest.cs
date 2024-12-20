using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift2_codefirst.Repository.Entities
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }

        [Required] 
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]  
        public bool IsReservationHolder { get; set; }

        public virtual List <Reservation> Reservations { get; set; }

        public Guest(string firstName, string lastName, string email, bool isReservationHolder)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IsReservationHolder = isReservationHolder;
          
        }

        public Guest(int guestId, string firstName, string lastName, string email, bool isReservationHolder, List<Reservation> reservations)
        {
            GuestId = guestId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IsReservationHolder = isReservationHolder;
            Reservations = reservations;
        }
    }
}
