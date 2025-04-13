using RentACar.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.DLL.Entities;


namespace RentACar.BLL
{
    public class CustomerManagement : ICustomer
    {
        

        public List<Customers> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(string name, string lastName, string email, string phone, string address, DateTime createDate, DateTime updateDate)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string name, string lastName, string email, string phone, string address, DateTime createDate, DateTime updateDate)
        {
            throw new NotImplementedException();
        }
    }
}
