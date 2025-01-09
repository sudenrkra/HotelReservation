using HotelReservation.Dal;
using HotelReservation.Entity;

namespace HotelReservation.Bll
{
    public class AdminService
    {
        private readonly AdminsDAL _adminDAL;
        public AdminService()
        { 
            _adminDAL = new AdminsDAL();
        }

        public bool ValidateAdmin(string username, string password)
        {
            Admin model = new Admin { Email = username, Password = password };
            Admin admin = _adminDAL.GetAdminByUsernameAndPassword(model);
            return admin != null;
        }
    }
}
