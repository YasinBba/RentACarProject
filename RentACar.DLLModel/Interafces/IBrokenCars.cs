using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IBrokenCars
    {
        string AddBrokenCar(IBrokenCars brokenCar);
        IBrokenCars GetBrokenCar(int id);
        void UpdateBrokenCar(IBrokenCars brokenCar);
        List<IBrokenCars> GetAllBrokenCars();
        void DeleteBrokenCar(int id);
        bool ControlSameBrokenCar(string carName, string carBrand, string carModel, int id);
    }
}
