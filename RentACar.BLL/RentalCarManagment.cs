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
    public class RentalCarManagment: IRentalCars
    {
        private readonly  YasinRentACarEntities db = new YasinRentACarEntities();

        public string AddRentalCar(RentalCars rentalCar)
        {
            throw new NotImplementedException();
        }

        public bool ControlSameRentalCar(string carName, string carBrand, string carModel, int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRentalCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<RentalCars> GetAllRentalCars()
        {
            return db.RentalCars.ToList();
        }

        public RentalCars GetRentalCar(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRentalCar(RentalCars rentalCar)
        {
            throw new NotImplementedException();
        }
    }
    
}
