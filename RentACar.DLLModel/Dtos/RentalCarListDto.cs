using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Dtos
{
    public class RentalCarListDto
    {
        public int Id { get; set; }//RentalCar Tablosu
        //public int CarId { get; set; }
        public string CarName { get; set; }//Cars Tablosu
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        //public int CustomerId { get; set; }
        public string CustomerName { get; set; }//Customers Tablosu
        //public int UserId { get; set; }
        public string UserName { get; set; }//Users Tablosu
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal FuelAmount { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        //public int CreatorId { get; set; }
        public string CreatorName { get; set; }//Users Tablosu
        public System.DateTime UpdateDate { get; set; }
        //public int UpdatorId { get; set; }
        public string UpdatorName { get; set; }//Users Tablosu
        public string IsActive { get; set; }
    }
}
