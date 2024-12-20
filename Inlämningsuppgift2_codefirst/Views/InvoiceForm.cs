using Inlämningsuppgift2_codefirst.Repository.Entities;
using Inlämningsuppgift2_codefirst.Repository.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2_codefirst.Views
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();

            FillForm();
        }

        InvoiceRepo invoiceRepo = new();
        ReservationRepo reservationRepo = new();
        public void FillForm()
        {
            listBoxInvoiceHolders.DataSource = reservationRepo.GetAllReservations();
            listBoxInvoiceHolders.DisplayMember = "ReservationHolder";
            listBoxInvoiceHolders.ValueMember = "ReservationID";

        }

        private void listBoxInvoiceHolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxInvoiceHolders.ValueMember != "")
            {
                labelDateOfPaymentLabel.Visible = false;
                labelDateOfPayment.Visible = false;
                // Dolt ID för valt rum
                int reservationID = (int)listBoxInvoiceHolders.SelectedValue;

                Reservation reservation = reservationRepo.GetReservation(reservationID);

                Invoice invoice = invoiceRepo.GetInvoice(reservation.InvoiceID);

                if (invoice.InvoiceID != 0)
                {
                    labelAmount.Text = invoice.Amount.ToString() + " $";
                    labelLastDayOfPayment.Text = invoice.LastDayOfPayment.ToString();

                    if (invoice.IsPayed)
                    {
                        labelPaymentStatus.Text = "Payed";
                        labelDateOfPaymentLabel.Visible = true;
                        labelDateOfPayment.Visible = true;  
                        labelDateOfPayment.Text = invoice.DateOfPayment.ToString();
                    }
                    else
                    {
                        labelPaymentStatus.Text = "Pending";
                    }

                }
            }
        }

        private void buttonRoyPayment_Click(object sender, EventArgs e)
        {
            Invoice invoice = invoiceRepo.GetInvoice(1024);
            Invoice updatedInvoice = new();

            updatedInvoice.InvoiceID = invoice.InvoiceID;
            updatedInvoice.Amount = invoice.Amount;
            updatedInvoice.LastDayOfPayment = invoice.LastDayOfPayment;
            updatedInvoice.Reservations = invoice.Reservations;

            updatedInvoice.IsPayed = true;
            updatedInvoice.DateOfPayment = DateOnly.FromDateTime(DateTime.Now);

            invoiceRepo.UpdateInvoice(updatedInvoice);

            this.Close();

        }
    }
}
