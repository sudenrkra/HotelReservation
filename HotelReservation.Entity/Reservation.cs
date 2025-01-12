
namespace HotelReservation.Entity
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BillId { get; set; }
        public int RoomId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerSurname { get; set; }
        public char Phone { get; set; }
        public bool ReservationStatus { get; set; }
        public Bill Bill { get; set; }

    }
}
