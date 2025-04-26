using RentACar.DLLModel;
using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class BrokenCarsManagment : IBrokenCars
    {
        public string AddBrokenCar(BrokenCars brokenCar)
        {
            throw new NotImplementedException();
        }

        public bool ControlSameBrokenCar(string carName, string carBrand, string carModel, int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteBrokenCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<BrokenCars> GetAllBrokenCars()
        {
            throw new NotImplementedException();
        }

        public BrokenCars GetBrokenCar(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBrokenCar(BrokenCars brokenCar)
        {
            throw new NotImplementedException();
        }
    }
}
