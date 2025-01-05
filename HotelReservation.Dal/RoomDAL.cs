using MySql.Data.MySqlClient;
using HotelReservation.Entity;

namespace HotelReservation.Dal
{
    public class RoomDAL
    {
        private Database db = new Database();

        //Create
        public void AddRoom(Room room)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Rooms(RoomType,Price,State) VALUES (@RoomType,@Price,@State)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomType",room.RoomType);
                    cmd.Parameters.AddWithValue("@Price",room.Price);
                    cmd.Parameters.AddWithValue("@State",room.State);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        //Read
        public Room GetRoomById(int roomId)
        {
            Room room = null;
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Rooms WHERE RoomId = @RoomId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomId", roomId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            room = new Room();
                            room.RoomId = reader.GetInt32("RoomId");
                            room.RoomType= reader.GetString("RoomType");
                            room.Price = reader.GetDecimal("Price");
                            room.State = reader.GetBoolean("State");
                        }
                    }
                }
            }
            return room;
        }
        //Update
        public void UpdateRoom(Room room)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Rooms SET RoomType=@RoomType,Price=@Price,State=@State WHERE RoomId=@RoomId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@Price", room.Price);
                    cmd.Parameters.AddWithValue("@State", room.State);
                    cmd.Parameters.AddWithValue("@RoomId", room.RoomId);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        //Delete
        public void DeleteRoom(int roomId)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Rooms WHERE RoomId= @RoomId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomId", roomId); 
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
