using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface ICustomers
    {
        string AddCustomer(Customers customer);
        Customers GetCustomer(int id);
        void UpdateCustomer(Customers customer);
        List<Customers> GetAllCustomers();
        void DeleteCustomer(int id);
       
        bool ControlSameCustomer(string firstName, string lastName, string email, int id);


    }
}
