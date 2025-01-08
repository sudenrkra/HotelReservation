using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.Bll
{
    public class ReservationService
    {
        private readonly ReservationDAL _reservationDAL;
        private readonly RoomDAL _roomDAL;

        public ReservationService()
        {
            _reservationDAL = new ReservationDAL();
            _roomDAL = new RoomDAL();
        }

        public bool MakeReservation(Reservation reservation)
        {
            if (IsRoomAvailable(reservation.RoomId, reservation.EntryDate, reservation.ReleaseDate))
            {
                _reservationDAL.AddReservation(reservation);
                return true;
            }
            return false;
        }
        private bool IsRoomAvailable(int roomId, DateTime startDate, DateTime endDate)
        {
            var reservations = _reservationDAL.GetReservationsByRoom(roomId); 
            return !reservations.Any(r => r.EntryDate < endDate && r.ReleaseDate > startDate);
        }
    }
}
