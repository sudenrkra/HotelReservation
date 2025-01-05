using MySql.Data.MySqlClient;

namespace HotelReservation.Dal
{
    public class Database
    {
        //private string connectionString = "Server =172.21.54.253;Database=25_132330053;User=25_132330053;Password=!nif.ogr53KA";
        private string connectionString = "Server =localhost;Port=3306;Database=hotelreservationdb;Uid=root;Pwd=;";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
