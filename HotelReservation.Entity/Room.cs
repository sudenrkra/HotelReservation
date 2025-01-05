
namespace HotelReservation.Entity
{
    public class Room
    {
        public int RoomId { get; set; }
        public bool RoomType { get; set; }
        public decimal Price { get; set; }
        public bool State { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
