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
    public partial class EditReservationForm : Form
    {
        private readonly ReservationRepo _reservationRepo;

        public EditReservationForm()
        {
            InitializeComponent();

            _reservationRepo = new();

            FillReservationList();
        }

        InvoiceRepo invoiceRepo = new();
        public void FillReservationList()
        {
            listBoxReservationResults.DisplayMember = "ReservationHolder";
            listBoxReservationResults.ValueMember = "ReservationID";
            listBoxReservationResults.DataSource = _reservationRepo.GetAllReservations();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID = (int)listBoxReservationResults.SelectedValue;

            Reservation reservation = _reservationRepo.GetReservation(ID);
            invoiceRepo.DeleteInvoice(reservation.InvoiceID);

            _reservationRepo.DeleteReservation(ID);

          

            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            if (listBoxReservationResults.ValueMember != "")
            {
                int id = (int)listBoxReservationResults.SelectedValue;  

                if (id != 0)
                {
                    UpdateReservationForm updateReservation = new UpdateReservationForm();
                    updateReservation.FillForm(id);
                    updateReservation.ShowDialog();
                }
            }
        }
    }
}
