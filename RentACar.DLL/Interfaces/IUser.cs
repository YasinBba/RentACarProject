using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Interfaces
{
    public interface IUser
    {
        void Save(string userName, string userEmail, string userPassword, string userPhone, string userRole, int userId);
        void Update(int id, string userName, string userEmail, string userPassword, string userPhone, string userRole, int userId);
        void Delete(int id);
        Users GetById(int id);
        List<Users> GetAll();
        void GetByUserName(string userName);
        void GetByUserEmail(string userEmail);
        void GetByUserPassword(string userPassword);




    }
}
