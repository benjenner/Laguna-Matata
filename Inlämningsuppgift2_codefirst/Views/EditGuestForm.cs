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
    public partial class EditGuestForm : Form
    {

        private readonly GuestRepo _guestRepo;
        public EditGuestForm()
        {
            InitializeComponent();

            _guestRepo = new GuestRepo();

            FillGuestList();
        }

        private void FillGuestList()
        {
            // Den här ordningen måste gälla, annars fungerar det inte 
            listBoxGuests.DisplayMember = "LastName";
            listBoxGuests.ValueMember = "GuestId";
            listBoxGuests.DataSource = _guestRepo.GetAllGuests();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Guest guest = new Guest(textBoxFirstName.Text, textBoxLastName.Text,
                                    textBoxEmail.Text, false);
            _guestRepo.CreateGuest(guest);
            FillGuestList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest(textBoxFirstName.Text, textBoxLastName.Text,
                                    textBoxEmail.Text, false);

            guest.GuestId = (int)listBoxGuests.SelectedValue;
            guest.FirstName = textBoxFirstName.Text;
            guest.LastName = textBoxLastName.Text;
            guest.Email = textBoxEmail.Text;

            _guestRepo.UpdateGuest(guest);
            FillGuestList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID = (int)listBoxGuests.SelectedValue;
            _guestRepo.DeleteGuest(ID);
            FillGuestList();

        }

        private void listBoxGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listBoxGuests.SelectedValue;

            Guest guest = _guestRepo.GetGuest(id);

            textBoxFirstName.Text = guest.FirstName;    
            textBoxLastName.Text = guest.LastName;  
            textBoxEmail.Text = guest.Email;
        }
    }
}
