
using HotelReservation.Bll;
using HotelReservation.Entity;
using System.Windows.Forms;
namespace HotelReservation.UI
{
    public partial class RoomForm : Form
    {
        private RoomService _roomService;
        private Form previousForm;
        public RoomForm(Form previousForm)
        {
            InitializeComponent();
            _roomService = new RoomService();
            LoadRooms();
            this.previousForm = previousForm;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }
        private void LoadRooms()
        {
            List<Room> rooms = _roomService.GetAllRooms();
            dgvRooms.DataSource = rooms;
            dgvRooms.Columns["ImagePath"].Visible = false;
        }



        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Room room = new Room
                {
                    RoomType = txtRoomType.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    State = chkState.Checked,
                    Capacity = int.Parse(txtCapacity.Text),
                    ImagePath = openFileDialog.FileName
                };
                _roomService.AddRoom(room);
                LoadRooms();
                ClearForm();

            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room
                    {
                        RoomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomId"].Value),
                        RoomType = txtRoomType.Text,
                        Price = decimal.Parse(txtPrice.Text),
                        State = chkState.Checked,
                        Capacity = int.Parse(txtCapacity.Text),
                        ImagePath = openFileDialog.FileName
                    };
                    _roomService.UpdateRoom(room);
                    LoadRooms();
                    ClearForm();
                }
            }

            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir oda seçin.");
            }
        }



        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomId"].Value);
                _roomService.DeleteRoom(roomId);
                LoadRooms();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir oda seçin.");
            }
        }

        private void ClearForm()
        {
            txtRoomType.Clear();
            txtPrice.Clear();
            chkState.Checked = false;
            txtCapacity.Clear();
            picRoom.Image = null;
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                txtRoomType.Text = dgvRooms.SelectedRows[0].Cells["RoomType"].Value.ToString();
                txtPrice.Text = dgvRooms.SelectedRows[0].Cells["Price"].Value.ToString();
                chkState.Checked = Convert.ToBoolean(dgvRooms.SelectedRows[0].Cells["State"].Value);
                txtCapacity.Text = dgvRooms.SelectedRows[0].Cells["Capacity"].Value.ToString();
                string imagePath = dgvRooms.SelectedRows[0].Cells["ImagePath"].Value.ToString();
                if (File.Exists(imagePath))
                {
                    picRoom.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}

