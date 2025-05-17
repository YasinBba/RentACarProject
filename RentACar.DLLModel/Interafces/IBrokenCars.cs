using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IBrokenCars
    {
        string AddBrokenCar(BrokenCars brokenCar);
        BrokenCars GetBrokenCar(int id);
        void UpdateBrokenCar(BrokenCars brokenCar);
        List<BrokenCars> GetAllBrokenCars();
        void DeleteBrokenCar(int id);
        bool ControlSameBrokenCar(string carName, string carBrand, string carModel, int id);
    }
}
