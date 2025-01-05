using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entity
{
    public class Bill
    {
        private int BillId { get; set;}
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }

        public DateTime BillDate { get; set; }
        public int GetBillId()
        {
            return BillId;
        }
        public void SetBillId(int value)
        {
            BillId = value;
        }

    }
}
