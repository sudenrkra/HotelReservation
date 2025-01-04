using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HotelReservation.Entity;

namespace HotelReservation.Dal
{
    public class ReservationDAL
    {
        private Database db = new Database();

        //Create
        public void AddReservation(Reservations reservation)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Reservations(EntryDate,ReleaseDate,RoomId,CustomerId,BillId,ReservationStatus) VALUES (@EntryDate,@ReleaseDate,@RoomId,@CustomerId,@BillId,@ReservationStatus)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EntryDate", reservation.EntryDate);
                    cmd.Parameters.AddWithValue("@ReleaseDate", reservation.ReleaseDate);
                    cmd.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                    cmd.Parameters.AddWithValue("@BillId", reservation.BillId);
                    cmd.Parameters.AddWithValue("@CustomerId", reservation.CustomerId);
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservation.ReservationStatus);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Read
        public Reservations GetReservationById(int reservationId)
        {
            Reservations reservation = null;
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Reservations WHERE ReservationId =@ReservationId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReservationId", reservationId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reservation = new Reservations();
                            reservation.SetReservationId(reader.GetInt32("@ReservationId"));
                            reservation.EntryDate = reader.GetDateTime("@EntryDate");
                            reservation.ReleaseDate = reader.GetDateTime("@ReleaseDate");
                            reservation.RoomId = reader.GetInt32("@RoomId");
                            reservation.CustomerId = reader.GetInt32("@CustomerId");
                            reservation.BillId = reader.GetInt32("@BillId");
                            reservation.ReservationStatus = reader.GetString("@ReservationStatus");

                        }
                    }
                }
            }
            return reservation;
        }
        //Update
        public void UpdateReservation(Reservations reservation)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Reservations SET EntryDate = @EntryDate, ReleaseDate = @ReleaseDate, RoomId = @RoomId, CustomerId = @CustomerId, BillId = @BillId, ReservationStatus = @ReservationStatus WHERE ReservationId = @ReservationId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EntryDate", reservation.EntryDate);
                    cmd.Parameters.AddWithValue("@ReleaseDate", reservation.ReleaseDate);
                    cmd.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                    cmd.Parameters.AddWithValue("@CustomerId", reservation.CustomerId);
                    cmd.Parameters.AddWithValue("@BillId", reservation.BillId);
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservation.ReservationStatus);
                    cmd.Parameters.AddWithValue("@ReservationId", reservation.GetReservationId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Delete
        public void DeleteReservation(Reservations reservationId)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Reservations WHERE ReservationId = @ReservationId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReservationId", reservationId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}