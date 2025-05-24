using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IRentalCars
    {
        string AddRentalCar(RentalCars rentalCar);
        RentalCars GetRentalCar(int id);
        string UpdateRentalCar(RentalCars rentalCar);
        List<RentalCars> GetAllRentalCars();
        void DeleteRentalCar(int id);
      
        bool ControlSameRentalCar(string carName, string carBrand,string customerName, string carModel, int id);
        
    }
}
