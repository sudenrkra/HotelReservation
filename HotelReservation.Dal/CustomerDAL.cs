using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HotelReservation.Entity;
using System.Security.Cryptography;
using System.Data;

namespace HotelReservation.Dal
{
    public class CustomerDAL
    {
        private Database db = new Database();

        //Create(Insert)
        public void AddCustomer(Customers customer)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Customers(CustomerName,CustomerSurname,Email,Phone) VALUES (@CustomerName,@CustomerSurname,@Email,@Phone)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerName",customer.CustomerName);
                    cmd.Parameters.AddWithValue("@CustomerSurname", customer.CustomerSurname);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Read(Select)
        public Customers GetCustomersById(int CustomerId)
        {
            Customers customer = null;
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Customers WHERE CustomerId = @CustomerId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new Customers();
                            {
                                customer.SetCustomerId( reader.GetInt32("CustomerId"));
                                customer.CustomerName = reader.GetString("CustomerName");
                                customer.CustomerSurname = reader.GetString("CustomerSurname");
                                customer.Email = reader.GetString("Email");
                                customer.Phone = reader.GetString("Phone");
                            };
                        }
                    }
                }
            }
            return customer;
        }
        //Update
        public void UpdateCustomer(Customers customer)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Customers SET CustomerName = @CustomerName, CustomerSurname=@CustomerSurname, Email=@Email, Phone=@Phone WHERE CustomerId=@CustomerId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                    cmd.Parameters.AddWithValue("@CustomerSurname", customer.CustomerSurname);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                    cmd.Parameters.AddWithValue("@CustomerId", customer.GetCustomerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Delete
        public void  DeleteCustomers(int customerId)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Customers WHERE CustomerId= @CustomerId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
