using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift2_codefirst.Repository.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [Required]  
        public bool IsPayed { get; set; }

        [Required]
        public DateOnly LastDayOfPayment { get; set; }

        // Tillåter null
        public DateOnly? DateOfPayment { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public virtual List <Reservation> Reservations { get; set; }

        
    }
}
