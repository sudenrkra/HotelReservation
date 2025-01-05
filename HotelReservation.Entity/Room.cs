using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelReservation.Entity
{
    public class Room
    {
        private int RoomId { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public bool State { get; set; }
        public int GetRoomId()
        {
            return RoomId;
        }
        public void SetRoomId(int value)
        {
            RoomId = value;
        }
    }
}
