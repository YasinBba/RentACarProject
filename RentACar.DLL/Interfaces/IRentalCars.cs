using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Interfaces
{
    public interface IRentalCars
    {
        void Save(string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive);
        void Update(int id, string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive);
        void Delete(int id);
        RentalCars GetById(int id);
        List<RentalCars> GetAll();
        List<RentalCars> GetByBrand(string brand);
        void GetByModel(string model);
        void GetByColor(string color);
        void GetByYear(short year);
        void GetByPrice(decimal price);
        void GetByDate(DateTime date);
        void GetById(int id, string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive);

    }
}
