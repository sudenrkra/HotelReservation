
using MySql.Data.MySqlClient;
namespace HotelReservation.Dal
{
    public class Database
    {
        private string connectionstring = "Server =172.21.54.253;Database=25_132330053;User=25_132330053;Password=!nif.ogr53KA";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionstring);
        }
    }
}
