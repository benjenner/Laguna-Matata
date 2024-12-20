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
    public partial class CreateReservationForm : Form
    {
        public CreateReservationForm()
        {
            InitializeComponent();
            comboBoxExtraBeds.Items.Add(1);
            comboBoxExtraBeds.Items.Add(2);
        }

        private int roomID;
       
        private List<Guest> guests = new();

        ReservationRepo reservationRepo = new();
        RoomRepo roomRepo = new();
        InvoiceRepo invoiceRepo = new();

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            
            bool reservationHolder = false;
            if (checkBoxReservationHolder.Checked)
            {
                reservationHolder = true;
            }

            Guest guest = new Guest(textBoxFirstName.Text, textBoxLastName.Text, 
                                    textBoxEmail.Text, reservationHolder);
            guests.Add(guest);

            textBoxEmail.Clear();
            textBoxFirstName.Clear();   
            textBoxLastName.Clear();
            checkBoxReservationHolder.Checked = false;

            string guestFullName = $"{guest.LastName}, {guest.FirstName}";
            listBoxGuests.Items.Add(guestFullName.ToString());
        }

        private void buttonChooseRoom_Click(object sender, EventArgs e)
        {
            roomID = (int)listBoxAvailableRooms.SelectedValue;
            
            Room room = roomRepo.GetRoom(roomID);
            MessageBox.Show($"{room.RoomName} chosen.");
        }

        private void buttonCreateReservation_Click(object sender, EventArgs e)
        {

            Invoice invoice = GenerateInvoice();

         
            string reservationHolder = "";

            foreach (Guest guest in guests)
            {
                if (guest.IsReservationHolder)
                {
                    reservationHolder = guest.LastName;
                }
            }

            Reservation reservation = new();

            reservation.CheckIn = DateOnly.FromDateTime(dateTimePickerCheckIn.Value);
            reservation.CheckOut = DateOnly.FromDateTime(dateTimePickerCheckOut.Value);
            reservation.ReservationHolder = reservationHolder;
            reservation.NoExtraBeds = GetNoExtraBeds();
            reservation.Guests = guests;
            reservation.InvoiceID = invoice.InvoiceID;
            reservation.RoomID = roomID;

            reservationRepo.CreateReservation(reservation);

            this.Close();
        }

        private void buttonFindRoom_Click(object sender, EventArgs e)
        {
            
            DateOnly checkIn = DateOnly.FromDateTime(dateTimePickerCheckIn.Value);
            DateOnly checkOut = DateOnly.FromDateTime(dateTimePickerCheckOut.Value);
        

            if (comboBoxNoGuests.Text == "")
            {
                MessageBox.Show("Please fill in number of guests.");
            }
            else
            {
                int noGuests = int.Parse(comboBoxNoGuests.Text);

                var result = roomRepo.GetAvailableRoom(checkIn, checkOut, noGuests);

                listBoxAvailableRooms.DataSource = result;
                listBoxAvailableRooms.DisplayMember = "RoomName";
                listBoxAvailableRooms.ValueMember = "RoomID";
            }
        }

        private void listBoxAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAvailableRooms.ValueMember != "")
            {
                // Dolt ID för valt rum
                int roomID = (int)listBoxAvailableRooms.SelectedValue;

                Room room = roomRepo.GetRoom(roomID);    

                if (roomID != 0)
                {
                    textBoxPrice.Text = room.Price.ToString() + " $"; 
                    textBoxExtraBeds.Text = room.RoomType.NoExtraBeds.ToString();
                    textBoxRoomType.Text = room.RoomType.RoomTypeName;
                }
            }
        }

        public Invoice GenerateInvoice()
        {

            Room room = roomRepo.GetRoom(roomID);

            DateOnly checkIn = DateOnly.FromDateTime(dateTimePickerCheckIn.Value);
            DateOnly checkOut = DateOnly.FromDateTime(dateTimePickerCheckOut.Value);

            int noDays = checkOut.DayNumber - checkIn.DayNumber;

            decimal amount;

            int noExtraBeds = GetNoExtraBeds();

            if (noExtraBeds == 1)
            {
                amount = (room.Price + 20) * noDays;
            }
            if (noExtraBeds == 2)
            {
                amount = (room.Price + 40) * noDays;
            }
            else
            {
                amount = room.Price * noDays;
            }

            Invoice invoice = new();
            invoice.IsPayed = false;
            invoice.Amount = amount;
            invoice.LastDayOfPayment = DateOnly.FromDateTime(DateTime.Now).AddDays(10);

            // Genererar fakturan i databasen och får tillbaka det genererade ID't
            Invoice invoiceID = invoiceRepo.CreateInvoice(invoice);

            return invoiceID;
        }

        public int GetNoExtraBeds()
        {
            int NoExtraBeds = 0;

            if (comboBoxExtraBeds.SelectedItem != null)
            {
                NoExtraBeds = (int)comboBoxExtraBeds.SelectedItem;
                return NoExtraBeds; 
            }
            return NoExtraBeds;
        }

       
    }
}
