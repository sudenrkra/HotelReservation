
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
            dgvReservations.DataSource = null;
            dgvReservations.DataSource = reservations;
        }

        private void ShowBillDetails(int reservationId)
        {
            ReservationService reservationService = new ReservationService();
            Bill bill = reservationService.GetBillByReservationId(reservationId);

            if (bill != null && bill.BillId != 0)
            {
                string billDetails = $"Fatura ID: {bill.BillId}\nToplam Fiyat: {bill.TotalPrice:C}\nFatura Tarihi: {bill.BillDate}";
                MessageBox.Show(billDetails, "Fatura Detayları");
            }
            else
            {
                MessageBox.Show("Bu rezervasyon için fatura bulunamadı.", "Fatura Detayları");
            }
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
            if (e.ColumnIndex == dgvReservations.Columns["BillDetailsColumn"].Index)
            {
                int reservationId = Convert.ToInt32(dgvReservations.Rows[e.RowIndex].Cells["ReservationId"].Value);
                ShowBillDetails(reservationId);
            }
            else if (e.ColumnIndex == dgvReservations.Columns["DownloadBillColumn"].Index)
            {
                int reservationId = Convert.ToInt32(dgvReservations.Rows[e.RowIndex].Cells["ReservationId"].Value);
                DownloadBill(reservationId);
            }
        }
        private void DownloadBill(int reservationId)
        {
            ReservationService reservationService = new ReservationService();
            Bill bill = reservationService.GetBillByReservationId(reservationId);
            if (bill != null && bill.BillId != 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF dosyası|*.pdf";
                    saveFileDialog.Title = "Faturayı Kaydet";
                    saveFileDialog.FileName = $"Fatura_{bill.BillId}.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                    }
                }
            }
            else
            {
                MessageBox.Show("Bu rezervasyon için fatura bulunamadı.", "Fatura İndir");
            }
        }
    }
}
                   

    

