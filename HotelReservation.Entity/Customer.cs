using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelReservation.Entity
{
    public class Customer
    {
        private int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //sadece getter ve setter metotları üzerinden erişim sağlamama olanak tanır,veritabanı işlemleri sırasında güvenliği ve veri bütünlüğünü korumaya yardımcı olur.
        public int GetCustomerId()
        { 
            return CustomerId; 
        }
        public void SetCustomerId(int value)
        { 
            CustomerId = value; 
        }
    }
}
