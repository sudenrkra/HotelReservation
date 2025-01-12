
using HotelReservation.Bll;
using HotelReservation.Entity;
using System.Drawing.Text;
using System.Windows.Forms;

namespace HotelReservation.UI
{
    public partial class MainForm : Form
    {
        private List<Reservation> reservations = new List<Reservation>();
        public MainForm()
        {
            InitializeComponent();
            reservations = new List<Reservation>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateReservationGrid();
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm(this);
            roomForm.Show();

        }

        private void odaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm(this);
            roomForm.Show();
        }

        private void odaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm(this);
            roomForm.Show();
        }

        private void rezervasyonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rezervasyonSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReservationForm addReservationForm = new AddReservationForm(this);
            addReservationForm.Show();
        }


        public void UpdateReservationGrid()
        {
            ReservationService reservationService = new ReservationService();
            List<Reservation> reservations = reservationService.GetAllReservations();
            dgvReservations.DataSource = reservations;
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int reservationId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationId"].Value);
                ReservationService reservationService = new ReservationService();
                reservationService.CancelReservation(reservationId);

                UpdateReservationGrid();
            }
            else
            {
                MessageBox.Show("Lütfen iptal etmek için bir rezervasyon seçin.");
            }
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
