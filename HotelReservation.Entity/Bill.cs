
namespace HotelReservation.Entity
{
    public class Bill
    {
        public int BillId { get; set;}
        public int ReservationId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BillDate { get; set; }
        public Reservation Reservation { get; set; }
    }
}
