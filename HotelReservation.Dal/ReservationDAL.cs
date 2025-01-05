﻿using MySql.Data.MySqlClient;
using HotelReservation.Entity;

namespace HotelReservation.Dal
{
    public class ReservationDAL
    {
        private Database db = new Database();

        //Create
        public void AddReservation(Reservation reservation)
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
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservation.ReservationStatus);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Read
        public Reservation GetReservationById(int reservationId)
        {
            Reservation reservation = null;
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
                            reservation = new Reservation();
                            reservation.ReservationId = reader.GetInt32("@ReservationId");   
                            reservation.EntryDate = reader.GetDateTime("@EntryDate");
                            reservation.ReleaseDate = reader.GetDateTime("@ReleaseDate");
                            reservation.RoomId = reader.GetInt32("@RoomId");
                            reservation.BillId = reader.GetInt32("@BillId");
                            reservation.ReservationStatus = reader.GetBoolean("@ReservationStatus");
                        }
                    }
                }
            }
            return reservation;
        }
        //Update
        public void UpdateReservation(Reservation reservation)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Reservations SET EntryDate = @EntryDate, ReleaseDate = @ReleaseDate, RoomId = @RoomId, CustomerId = @CustomerId, BillId = @BillId, ReservationStatus = @ReservationStatus WHERE ReservationId = @ReservationId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReservationId", reservation.ReservationId);
                    cmd.Parameters.AddWithValue("@EntryDate", reservation.EntryDate);
                    cmd.Parameters.AddWithValue("@ReleaseDate", reservation.ReleaseDate);
                    cmd.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                    cmd.Parameters.AddWithValue("@BillId", reservation.BillId);
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservation.ReservationStatus);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Delete
        public void DeleteReservation(Reservation reservationId)
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