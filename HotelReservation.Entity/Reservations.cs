using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entity
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public int BillId { get; set; }
        public string ReservationStatus { get; set; }
    }
}
