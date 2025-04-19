using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Interfaces
{
    public interface IRules
    {
        void save(string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive);
        void update(int id, string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive);
        void delete(int id);
        Rules GetById(int id);
        List<Rules> GetAll();

    }
}
