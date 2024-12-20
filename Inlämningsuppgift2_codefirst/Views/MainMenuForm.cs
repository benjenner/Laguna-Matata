using Inlämningsuppgift2_codefirst.Repository.Repos;

namespace Inlämningsuppgift2_codefirst.Views
{
    public partial class MainMenuForm : Form
    {
        private readonly InvoiceRepo _invoiceRepo;
        public MainMenuForm()
        {
            InitializeComponent();

            _invoiceRepo = new();
            _invoiceRepo.CheckPayments();

        }

        private void buttonCreateReservation_Click(object sender, EventArgs e)
        {
            CreateReservationForm createReservation = new();
            createReservation.ShowDialog();
        }

        private void buttonEditGuest_Click(object sender, EventArgs e)
        {
            EditGuestForm editGuest = new();
            editGuest.ShowDialog();
        }

        private void buttonEditReservation_Click(object sender, EventArgs e)
        {
            EditReservationForm editReservation = new();
            editReservation.ShowDialog();
        }

        private void buttonViewInvoices_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new();
            invoiceForm.ShowDialog();   
        }
    }
}
