using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift2_codefirst.Repository.Entities
{
    public class Room
    {
       
        [Key]
        public int RoomID { get; set; }

        [Required]  
        public string RoomName { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public decimal Price { get; set; }

        
        public virtual RoomType RoomType { get; set; }
        

        public virtual List <Reservation> Reservations { get; set; }


    }
}
