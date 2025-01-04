using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; 
            string password = txtPassword.Text;
            AdminsDAL adminsDAL = new AdminsDAL(); 
            Admins admin = adminsDAL.GetAdminByUsernameAndPassword(username, password);
            if (admin != null)
            {
                MessageBox.Show("Login successful!"); 
                MainForm mainForm = new MainForm(); 
                mainForm.Show(); 
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
