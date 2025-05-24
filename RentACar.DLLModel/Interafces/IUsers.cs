using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;



namespace RentACar.DLLModel.Interafces
{
    public interface IUsers
    {
        string AddUser(Users user);
        Users GetUser(int id);
        string UpdateUser(Users user);
        List<Users> GetAllUsers();
        void DeleteUser(int id);
        bool ControlSameUser(string userName,  int id);

         Users Login(string userName, string password);
      
    }
}
