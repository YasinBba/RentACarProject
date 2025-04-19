using RentACar.DLL.Entities;
using RentACar.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class RentalCarManagment: IRentalCars
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<RentalCars> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<RentalCars> GetByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public void GetByColor(string color)
        {
            throw new NotImplementedException();
        }

        public void GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public RentalCars GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id, string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive)
        {
            throw new NotImplementedException();
        }

        public void GetByModel(string model)
        {
            throw new NotImplementedException();
        }

        public void GetByPrice(decimal price)
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
