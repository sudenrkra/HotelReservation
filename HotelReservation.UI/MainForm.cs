
using HotelReservation.Bll;
using HotelReservation.Dal;
using HotelReservation.Entity;
using MySql.Data.MySqlClient;
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
            SetColumnHeaders();
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
            dgvReservations.AutoGenerateColumns = true;
            dgvReservations.DataSource = null;
            dgvReservations.DataSource = reservations;
            SetColumnHeaders();
        }
        private void SetColumnHeaders()
        {
            if (dgvReservations.Columns["ReservationId"] != null)
                dgvReservations.Columns["ReservationId"].HeaderText = "Rezervasyon ID";

            if (dgvReservations.Columns["CustomerName"] != null)
                dgvReservations.Columns["CustomerName"].HeaderText = "Müşteri Adı";

            if (dgvReservations.Columns["EntryDate"] != null)
                dgvReservations.Columns["EntryDate"].HeaderText = "Giriş Tarihi";

            if (dgvReservations.Columns["ReleaseDate"] != null)
                dgvReservations.Columns["ReleaseDate"].HeaderText = "Çıkış Tarihi";

            if (dgvReservations.Columns["RoomId"] != null)
                dgvReservations.Columns["RoomId"].HeaderText = "Oda Numarası";

            if (dgvReservations.Columns["CustomerSurname"] != null)
                dgvReservations.Columns["CustomerSurname"].HeaderText = "Müşteri Soyadı";

            if (dgvReservations.Columns["Phone"] != null)
                dgvReservations.Columns["Phone"].HeaderText = "Telefon";

            if (dgvReservations.Columns["BillId"] != null)
                dgvReservations.Columns["BillId"].HeaderText = "Fatura ID";

            if (dgvReservations.Columns["ReservationStatus"] != null)
                dgvReservations.Columns["ReservationStatus"].HeaderText = "Rezervasyon Durumu";
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
        private void dgvReservations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetColumnHeaders();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = !pnlChangePassword.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            Database db = new Database();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Eski şifre doğrulama
                    string queryCheck = "SELECT COUNT(*) FROM Admins WHERE Email = @Email AND Password = @OldPassword";
                    using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@Email", email);
                        cmdCheck.Parameters.AddWithValue("@OldPassword", oldPassword);

                        int userExists = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        if (userExists == 0)
                        {
                            MessageBox.Show("E-posta veya eski şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Yeni şifre güncelleme
                    string queryUpdate = "UPDATE Admins SET Password = @NewPassword WHERE Email = @Email";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmdUpdate.Parameters.AddWithValue("@Email", email);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Şifre başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formdaki alanları temizle ve paneli gizle
                    txtEmail.Clear();
                    txtOldPassword.Clear();
                    txtNewPassword.Clear();
                    pnlChangePassword.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    


                   

    

