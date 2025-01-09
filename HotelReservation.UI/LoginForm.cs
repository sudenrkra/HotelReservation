using HotelReservation.Bll;
using HotelReservation.Dal;
using HotelReservation.Entity;
using System.Drawing.Drawing2D;

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
                /*  Admin model = new Admin()
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
                */
            }
    }
}
