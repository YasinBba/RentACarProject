using RentACar.DLLModel.Model;
using System.Collections.Generic;

namespace RentACar.DLLModel.Interafces
{
    public interface ICar
    {

        string AddCar(Cars car);
        Cars GetCar(int id);
        void UpdateCar(Cars car);
        List<Cars> GetAllCars();
        void DeleteCar(int id);
        

    }
}
