using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HotelReservation.Entity;

namespace HotelReservation.Dal
{
    public class BillDAL
    {
        private Database db = new Database();

        //Create
        public void AddBill(Bills bill)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Bills(TotalPrice,BillDate,ReservationId,CustomerId) VALUES (@TotalPrice,@BillDate,@ReservationId,@CustomerId)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BillDate", bill.BillDate);
                    cmd.Parameters.AddWithValue("@TotalPrice", bill.TotalPrice);
                    cmd.Parameters.AddWithValue("@CustomerId", bill.CustomerId);
                    cmd.Parameters.AddWithValue("@ReservationId", bill.ReservationId);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        //Read
        public Bills GetBillById(int billId)
        {
            Bills bill = null;
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
                            bill = new Bills();
                            bill.SetBillId(reader.GetInt32("@BillId"));
                            bill.BillDate=reader.GetDateTime("@BillDate");
                            bill.TotalPrice = reader.GetDecimal("@TotalPrice");
                            bill.ReservationId=reader.GetInt32("@ReservationId");
                            bill.CustomerId = reader.GetInt32("@CustomerId");

                        }
                    }
                }
            }
            return bill;
        }
    }
}
