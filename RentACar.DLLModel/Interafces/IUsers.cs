using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;



namespace RentACar.DLLModel.Interafces
{
    public interface IUsers
    {
        string AddUser(Users user);
        Users GetUser(int id);
        void UpdateUser(Users user);
        List<Users> GetAllUsers();
        void DeleteUser(int id);
        bool ControlSameUser(string userName,  int id);
    }
}
