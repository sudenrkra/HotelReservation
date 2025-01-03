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
    }
}
