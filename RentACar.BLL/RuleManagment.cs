using RentACar.DLL.Entities;
using RentACar.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class RuleManagment : IRules
    {
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rules> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rules GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void save(string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive)
        {
            throw new NotImplementedException();
        }

        public void update(int id, string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive)
        {
            throw new NotImplementedException();
        }
    }
}
