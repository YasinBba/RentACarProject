using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IUsers
    {
        string AddUser(IUsers user);
        IUsers GetUser(int id);
        void UpdateUser(IUsers user);
        List<IUsers> GetAllUsers();
        void DeleteUser(int id);
        bool ControlSameUser(string firstName, string lastName, string email, int id);
    }
}
