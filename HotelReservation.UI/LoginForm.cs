using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.UI
{
    public partial class LoginForm : Form
    {
        public AdminsDAL AdminsDAL { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            AdminsDAL = new AdminsDAL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Admin model = new Admin()
            {
                Email = username, Password = password
            };


            var result = AdminsDAL.GetAdminByUsernameAndPassword(model);

            if(result != null)
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
