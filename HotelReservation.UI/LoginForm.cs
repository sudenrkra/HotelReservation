using HotelReservation.Bll;
using HotelReservation.Dal;
using HotelReservation.Entity;
using System.Drawing.Drawing2D;

namespace HotelReservation.UI
{
    public partial class LoginForm : Form
    {
        public AdminsDAL AdminsDAL { get; set; }
        private bool isPasswordVisible = false;

        public LoginForm()
        {
            InitializeComponent();
            AddPasswordToggle();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            AdminsDAL = new AdminsDAL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            AdminService adminService = new AdminService();
            bool isValidAdmin = adminService.ValidateAdmin(username, password);

            if (isValidAdmin)
            {
                MessageBox.Show("Giriþ baþarýlý!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ.");
            }

        }
        private void AddPasswordToggle()
        {
            PictureBox eyeIcon = new PictureBox
            {
                Size = new Size(20, 20),
                Location = new Point(txtPassword.Width - 25, txtPassword.Height / 2 - 10),
                Cursor = Cursors.Hand,
                Image = ByteArrayToImage(Properties.Resources.eye_closed_icon),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            eyeIcon.Click += new EventHandler(TogglePasswordVisibility);
            txtPassword.Controls.Add(eyeIcon); txtPassword.PasswordChar = '•';
        }
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            PictureBox eyeIcon = sender as PictureBox;
            if (isPasswordVisible)
            {
                txtPassword.PasswordChar = '•';
                eyeIcon.Image = ByteArrayToImage(Properties.Resources.eye_closed_icon);
                isPasswordVisible = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                eyeIcon.Image = ByteArrayToImage(Properties.Resources.eye_closed_icon);
                isPasswordVisible = true;
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}

        

