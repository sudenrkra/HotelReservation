using MySql.Data.MySqlClient;
using HotelReservation.Entity;

namespace HotelReservation.Dal
{
    public class BillDAL
    {
        private Database db = new Database();

        //Create
        public void AddBill(Bill bill)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Bills(TotalPrice,BillDate,ReservationId,CustomerId) VALUES (@TotalPrice,@BillDate,@ReservationId,@CustomerId)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BillDate", bill.BillDate);
                    cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                    cmd.Parameters.AddWithValue("@ReservationId", bill.ReservationId);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        //Read
        public Bill GetBillById(int billId)
        {
            Bill bill = null;
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Bills WHERE BillId = @BillId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BillId", billId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bill = new Bill();
                            bill.BillDate=reader.GetDateTime("@BillDate");
                            bill.TotalPrice = reader.GetDecimal("@TotalPrice");
                            bill.ReservationId=reader.GetInt32("@ReservationId");
                        }
                    }
                }
            }
            return bill;
        }
        //Update
        public void UpdateBill(Bill bill)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Bills SET BillDate=@BillDate,TotalPrice=@TotalPrice,ReservationId=@ReservationId,CustomerId=@CustomerId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BillDate", bill.BillDate);
                    cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                    cmd.Parameters.AddWithValue("@ReservationId", bill.ReservationId);
                    cmd.Parameters.AddWithValue("@BillId", bill.BillId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Delete
        public void DeleteBill(Bill billId)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Bills WHERE BillId = @BillId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BillId", billId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
