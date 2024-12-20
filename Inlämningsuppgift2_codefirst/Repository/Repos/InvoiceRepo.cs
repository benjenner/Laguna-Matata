using Inlämningsuppgift2_codefirst.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inlämningsuppgift2_codefirst.Repository.Repos
{
    public class InvoiceRepo
    {
        // Instansvariabel
        private readonly DataContext _context;

        public InvoiceRepo()
        {
            // Tilldelar instansvariabeln en ny instans
            _context = new DataContext();
        }

        public Invoice CreateInvoice(Invoice invoice)
        {

            _context.Invoices.Add(invoice);
            _context.SaveChanges();
            return invoice;
        }

        public Invoice? GetInvoice(int ID)
        {
            return _context.Invoices
                           .Include(i => i.Reservations)
                           .SingleOrDefault(i => i.InvoiceID == ID);

        }

        public void UpdateInvoice(Invoice newInvoice)
        {

            Invoice? originalInvoice = GetInvoice(newInvoice.InvoiceID);

            _context.Entry(originalInvoice).CurrentValues.SetValues(newInvoice);

            _context.SaveChanges();
        }

        public List<Invoice> GetAllInvoices()
        {
            return _context.Invoices
                           .Include(i => i.Reservations) 
                           .ToList();
        }

        public void DeleteInvoice(int id)
        {
            Invoice invoice = GetInvoice(id);

            _context.Invoices.Remove(invoice);
            _context.SaveChanges();
        }


        public void CheckPayments()
        {
            var result = GetAllInvoices();

            foreach (var invoice in result)
            {
                if (!invoice.IsPayed && invoice.LastDayOfPayment < DateOnly.FromDateTime(DateTime.Now))
                {
                    ReservationRepo reservationRepo = new();
                    var reservations = reservationRepo.GetAllReservations();
                    foreach (Reservation reservation in reservations)
                    {
                        if (reservation.InvoiceID == invoice.InvoiceID)
                        {
                            reservationRepo.DeleteReservation(reservation.ReservationID);
                        }
                    }
                }
            }
        }
    }
}
