using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.DLL.Interfaces;
using RentACar.DLL.Entities;
using RentACar.DLL.Entities.Abstraction;

namespace RentACar.BLL
{
    public class CarManagement : ICar
    {
        public void Delete(int id)
        {
              /* Abstract ve Interface class türleri new lenemezler , sadece OOP de KALITIM VERMEK İÇİN oluşturulur  
            BaseEntity baseEntity = new BaseEntity();
            ICa */
            throw new NotImplementedException();
        }

        public List<Cars> GetAll()
        {
            throw new NotImplementedException();
            
        }

        public List<Cars> GetByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public void GetByColor(string color)
        {
            throw new NotImplementedException();
        }

        public Cars GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetByModel(string model)
        {
            throw new NotImplementedException();
        }

        public void GetByYear(short year)
        {
            throw new NotImplementedException();
        }

        public void Save(string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive)
        {
            throw new NotImplementedException();
        }
    }
}
