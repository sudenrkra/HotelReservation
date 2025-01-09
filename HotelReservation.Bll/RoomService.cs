

using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.Bll
{
    public class RoomService
    {
        private readonly RoomDAL _roomDAL;

        public RoomService()
        {
            _roomDAL = new RoomDAL();
        }

        public void AddRoom(Room room)
        {
            _roomDAL.AddRoom(room);
        }

        public void UpdateRoom(Room room)
        {
            _roomDAL.UpdateRoom(room);
        }

        public void DeleteRoom(int roomId)
        {
            _roomDAL.DeleteRoom(roomId); 
        }

        public List<Room> GetAllRooms()
        {
            return _roomDAL.GetAllRooms(); 
        }

        public Room GetRoomById(int roomId)
        {
            return _roomDAL.GetRoomById(roomId); 
        }
    }
}
