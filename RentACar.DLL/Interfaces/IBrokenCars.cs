using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Interfaces
{
   public interface IBrokenCars
    {
        void Save(string description, DateTime brokenDate, int carId);
        void Update(int id, string description, DateTime brokenDate, int carId);
        void Delete(int id);
        BrokenCars GetById(int id);
        List<BrokenCars> GetAll();
        List<BrokenCars> GetByCarId(int carId);
    }
}
