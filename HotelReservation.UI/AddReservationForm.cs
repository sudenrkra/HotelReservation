using HotelReservation.Entity;
using HotelReservation.Bll;
using HotelReservation.Dal;
using System.Windows.Forms;

namespace HotelReservation.UI
{
    public partial class AddReservationForm : Form
    {
        private MainForm mainForm;
        public AddReservationForm()
        {
            InitializeComponent(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reservation newReservation = new Reservation
            {
                RoomId = int.Parse(txtRoomId.Text),
                EntryDate = dtpEntryDate.Value,
                ReleaseDate = dtpReleaseDate.Value,
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                Phone = txtPhone.Text.Length > 0 ? txtPhone.Text[0] : '\0',
            };

            ReservationService reservationService = new ReservationService();
            bool success = reservationService.MakeReservation(newReservation);

            if (success)
            {
                MessageBox.Show("Rezervasyon başarıyla eklendi!");
                mainForm.AddReservation(newReservation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Rezervasyon eklenirken bir hata oluştu.");
            }
        }

        private void AddReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
           
      
     
