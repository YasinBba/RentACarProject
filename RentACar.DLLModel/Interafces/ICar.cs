using RentACar.DLLModel.Model;
using System.Collections.Generic;

namespace RentACar.DLLModel.Interafces
{
    public interface ICar
    {

        string AddCar(Cars car);
        Cars GetCar(int id);
        string UpdateCar(Cars car);
        List<Cars> GetAllCars();
        string DeleteCar(int id);
        bool ControlSameCar(string carName, string carBrand, string carModel);


    }
}
