using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelReservation.Entity
{
    public class Rooms
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public string State { get; set; } 
    }
}
