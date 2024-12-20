using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift2_codefirst.Repository.Entities
{
    public class RoomType
    {
  
        [Key]
        public int RoomTypeID { get; set; }

        [Required]
        [StringLength(70)]  
        public string RoomTypeName { get; set; }

        [Required]
        public int NoExtraBeds { get; set; }

        [Required]
        public int MaxCapacity { get; set; }

        public virtual List <Room> Rooms { get; set; }

    }
}
