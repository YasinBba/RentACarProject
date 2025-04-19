using RentACar.DLL.Entities;
using RentACar.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class BrokenCarsManagment : IBrokenCars
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BrokenCars> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<BrokenCars> GetByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public BrokenCars GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(string description, DateTime brokenDate, int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string description, DateTime brokenDate, int carId)
        {
            throw new NotImplementedException();
        }
    }
}
