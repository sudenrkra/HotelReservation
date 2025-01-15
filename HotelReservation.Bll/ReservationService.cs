using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.Bll
{
    public class ReservationService
    {
        private Database _database;

        private readonly ReservationDAL _reservationDAL;
        private readonly RoomDAL _roomDAL;
        private readonly BillService _billService;

        public ReservationService()
        {
            _reservationDAL = new ReservationDAL();
            _roomDAL = new RoomDAL();
            _database = new Database();
            _billService = new BillService();
        }

        public List<Reservation> GetAllReservations()
        {
            return _reservationDAL.GetAllReservations();
        }
        public Bill GetBillByReservationId(int reservationId) 
        {
            BillService billService = new BillService(); 
            return billService.GetBillByReservationId(reservationId); 
        }

        public bool MakeReservation(Reservation reservation)
        {
            if (IsRoomAvailable(reservation.RoomId, reservation.EntryDate, reservation.ReleaseDate))
            {
                int reservationId = _reservationDAL.AddReservation(reservation);
                decimal totalPrice = _billService.CalculateTotalPrice(reservation); 
                _billService.CreateBill(reservationId, totalPrice);
                Console.WriteLine("Reservation ID: " + reservationId + " - Total Price: " + totalPrice);
                return true;
            }
            return false;
        }
        private bool IsRoomAvailable(int roomId, DateTime startDate, DateTime endDate)
        {
            var reservations = _reservationDAL.GetReservationsByRoom(roomId); 
            return !reservations.Any(r => r.EntryDate < endDate && r.ReleaseDate > startDate);
        }
        public void CancelReservation(int reservationId) 
        {
            _database.CancelReservation(reservationId); 
        }
        public List<Reservation> GetReservationsWithBills()
        {
            return _reservationDAL.GetReservationsWithBills();
        }
    }
}
