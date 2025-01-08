using MySql.Data.MySqlClient;
using HotelReservation.Entity;

namespace HotelReservation.Dal
{
    public class AdminsDAL
    {
        private Database db = new Database(); 
        public Admin GetAdminByUsernameAndPassword(Admin model)
        {
            Admin? entity = null; 
            using (var connection = db.GetConnection())
            { 
                connection.Open(); 
                string query = "SELECT * FROM Admins WHERE Email = @Email AND Password = @Password"; 
                using (var cmd = new MySqlCommand(query, connection)) 
                {                   
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            entity = new Admin
                            { 
                                Email = reader.GetString("Email"),
                                Password = reader.GetString("Password")
                            };
                        }
                    }
                }
            }
            return entity;
        }
    }
}
