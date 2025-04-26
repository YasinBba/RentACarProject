using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IRentalCars
    {
        string AddRentalCar(IRentalCars rentalCar);
        IRentalCars GetRentalCar(int id);
        void UpdateRentalCar(IRentalCars rentalCar);
        List<IRentalCars> GetAllRentalCars();
        void DeleteRentalCar(int id);
      
        bool ControlSameRentalCar(string carName, string carBrand, string carModel, int id);
    }
}
