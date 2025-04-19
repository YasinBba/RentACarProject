using RentACar.DLL.Entities;
using RentACar.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class UserManagment : IUser

    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public Users GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetByUserEmail(string userEmail)
        {
            throw new NotImplementedException();
        }

        public void GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public void GetByUserPassword(string userPassword)
        {
            throw new NotImplementedException();
        }

        public void Save(string userName, string userEmail, string userPassword, string userPhone, string userRole, int userId)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string userName, string userEmail, string userPassword, string userPhone, string userRole, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
