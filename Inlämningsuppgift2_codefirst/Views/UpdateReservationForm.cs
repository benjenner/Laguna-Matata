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
    public partial class UpdateReservationForm : Form
    {
        public UpdateReservationForm()
        {
            InitializeComponent();
            comboBoxExtraBeds.Items.Add(1);
            comboBoxExtraBeds.Items.Add(2);
        }

        private int invoiceID;
        private int reservationID;
        private string reservationHolder;
        private int roomID;
        private DateOnly lastDayOfPayment;

        private List<Guest> guests = new();
        private List<Reservation> reservations = new();

        GuestRepo guestRepo = new();
        RoomRepo roomRepo = new();
        ReservationRepo reservationRepo = new();
        InvoiceRepo invoiceRepo = new();
        public void FillForm(int id)
        {
            var reservation = reservationRepo.GetReservation(id);

            reservationID = reservation.ReservationID;
            roomID = reservation.RoomID;
            reservationHolder = reservation.ReservationHolder;
            lastDayOfPayment = reservation.Invoice.LastDayOfPayment;
            invoiceID = reservation.InvoiceID;  

            reservations.Add(reservation);

            DateOnly checkIn = reservation.CheckIn;
            DateOnly checkOut = reservation.CheckOut;

            DateTime checkInConverted = checkIn.ToDateTime(TimeOnly.MinValue);
            DateTime checkoutConverted = checkOut.ToDateTime(TimeOnly.MinValue);
            dateTimePickerCheckIn.Value = checkInConverted;
            dateTimePickerCheckOut.Value = checkoutConverted;
            comboBoxExtraBeds.SelectedItem = reservation.NoExtraBeds;

            listBoxAvailableRooms.Items.Add(reservation.Room.RoomName);

            foreach (Guest guest in reservation.Guests)
            {
                guests.Add(guest);
                listBoxGuests.Items.Add(guest.LastName + "," + guest.FirstName);
            }

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

                var result = roomRepo.GetAvailableRoomUpdate(checkIn, checkOut, noGuests, reservationID);

                listBoxAvailableRooms.DataSource = result;
                listBoxAvailableRooms.DisplayMember = "RoomName";
                listBoxAvailableRooms.ValueMember = "RoomID";
            }
        
        }

        private void buttonChooseRoom_Click(object sender, EventArgs e)
        {
            roomID = (int)listBoxAvailableRooms.SelectedValue;

            Room room = roomRepo.GetRoom(roomID);
            MessageBox.Show($"{room.RoomName} chosen.");
        }

        private void buttonRemoveGuest_Click(object sender, EventArgs e)
        {
            string fullName = listBoxGuests.SelectedItem.ToString();
            int pos = fullName.IndexOf(",");
            string firstName = fullName.Substring(pos + 1);
            foreach (Guest guest in guests)
            {
                if (guest.FirstName == firstName)
                {
                    if (guest.IsReservationHolder)
                    {
                        MessageBox.Show("Unable to remove guest. Guest is reservation holder.");
                    }
                    else
                    {
                        guests.Remove(guest);
                        listBoxGuests.Items.Remove(listBoxGuests.SelectedItem);
                        break;
                    }
                }
            }
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            
            Guest guestNoID = new Guest(textBoxFirstName.Text, textBoxLastName.Text,
                                    textBoxEmail.Text, false);

            int guestID = guestRepo.CreateGuestReturnID(guestNoID);

            Guest guest = new Guest(guestID,textBoxFirstName.Text, textBoxLastName.Text,
                                    textBoxEmail.Text, false, reservations);
            guests.Add(guest);

            textBoxEmail.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();


            string guestFullName = $"{guest.LastName}, {guest.FirstName}";
            listBoxGuests.Items.Add(guestFullName.ToString());

        }

        public void GenerateUpdatedInvoice()
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
            invoice.LastDayOfPayment = lastDayOfPayment;
            invoice.InvoiceID = invoiceID;  

            invoiceRepo.UpdateInvoice(invoice);
        }

        private void buttonUpdateReservation_Click(object sender, EventArgs e)
        {
            GenerateUpdatedInvoice();

            Reservation reservation = new();

            reservation.ReservationID = reservationID;
            reservation.CheckIn = DateOnly.FromDateTime(dateTimePickerCheckIn.Value);
            reservation.CheckOut = DateOnly.FromDateTime(dateTimePickerCheckOut.Value);
            reservation.ReservationHolder = reservationHolder;
            reservation.NoExtraBeds = GetNoExtraBeds();
            reservation.Guests = guests;
            reservation.InvoiceID = invoiceID;
            reservation.RoomID = roomID;

            reservationRepo.UpdateReservation(reservation);

            this.Close();
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
