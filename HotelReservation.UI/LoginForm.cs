using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.UI
{
    public partial class LoginForm : Form
    {
        public Admin admin = new();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            admin.Email = "admin@mail.com";
            admin.Password = "12345";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == admin.Email && password == admin.Password)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                label1.Text = "Eposta ve/veya þifre hatalý";
                label1.BackColor = Color.MediumVioletRed;
            }
        }
    }
}
