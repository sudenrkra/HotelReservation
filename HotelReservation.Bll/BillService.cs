
using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.Bll
{
    public class BillService
    {
        private BillDAL _billDAL; 
        public BillService() 
        {
            _billDAL = new BillDAL(); 
        }
        public void CreateBill(int reservationId, decimal totalPrice) 
        {
            Bill bill = new Bill
            {
                ReservationId = reservationId, TotalPrice = totalPrice, BillDate = DateTime.Now 
            };
            _billDAL.AddBill(bill);
        }
        public List<Bill> GetBills()
        {
            return _billDAL.GetBills();
        }
        public Bill GetBillByReservationId(int reservationId) 
        {
            return _billDAL.GetBillByReservationId(reservationId);
        }
        public decimal CalculateTotalPrice(Reservation reservation)
        {
            decimal price = GetRoomPrice(reservation.RoomId);
            TimeSpan stayDuration = reservation.ReleaseDate - reservation.EntryDate; 
            int totalNights = stayDuration.Days;
            decimal totalPrice = price * totalNights;
            return totalPrice;
        }
        private decimal GetRoomPrice(int roomId)
        { 
            var room = new RoomDAL().GetRoomById(roomId); 
            return room.Price;
        }
    }
}
