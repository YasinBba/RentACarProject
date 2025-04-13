using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Interfaces
{
    public interface ICustomer
    {
        void Save(string name,string lastName,string email,string phone, string address,DateTime createDate,DateTime updateDate);
        void Update(int id,string name, string lastName, string email, string phone, string address, DateTime createDate, DateTime updateDate);    
        List<Customers> GetAll();

    }
}
