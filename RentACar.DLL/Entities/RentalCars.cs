using RentACar.DLL.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Entities
{
    public class RentalCars:BaseEntity
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarBrand { get; set; }
        public string CarColor { get; set; }
        public decimal PricePerDay { get; set; }
        public int YearOfManufacture { get; set; }
      
    }
}
