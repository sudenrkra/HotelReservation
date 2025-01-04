using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HotelReservation.Entity;

namespace HotelReservation.Dal
{
    public class AdminsDAL
    {
        private Database db = new Database(); 
        public Admins GetAdminByUsernameAndPassword(string username, string password)
        {
            Admins admin = null; 
            using (var connection = db.GetConnection())
            { 
                connection.Open(); 
                string query = "SELECT * FROM Admins WHERE Email = @Email AND Password = @Password"; 
                using (var cmd = new MySqlCommand(query, connection)) 
                { 
                    cmd.Parameters.AddWithValue("@Email", username);
                    cmd.Parameters.AddWithValue("@Password", password); 
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            admin = new Admins 
                            { 
                                Email = reader.GetString("Email"),
                                Password = reader.GetString("Password")
                            }; 
                        }
                    }
                }
            }
            return admin;
        }
    }
}
