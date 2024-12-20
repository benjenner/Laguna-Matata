using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift2_codefirst.Repository.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [Required]  
        public DateOnly CheckIn { get; set; }

        [Required]
        public DateOnly CheckOut { get; set; }

        [Required]
        public int NoExtraBeds { get; set; }
            
            
        [Required]
        [StringLength(50)]
        public string ReservationHolder { get; set; }

        public virtual List <Guest> Guests { get; set; }

        
        public int RoomID { get; set; }
      
        public virtual Room Room { get; set; }


        public int InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }


     
    }
}
