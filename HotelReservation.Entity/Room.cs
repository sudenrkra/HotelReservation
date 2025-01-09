
namespace HotelReservation.Entity
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public bool State { get; set; }
        public int Capacity { get; set; }
        public string ImagePath { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
