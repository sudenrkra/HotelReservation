using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entity
{
    public class Bills
    {
        private int BillId { get; set;}
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }

        public DateTime BillDate { get; set; }


    }
}
