

using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RentACar.BLL
{
    public class CarManagement : ICar
    {
        YasinRentACarEntities db = new YasinRentACarEntities();
        public string  AddCar(Cars car)
        {
            try
            {
                db.Cars.Add(car);   
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return "Success";
                }
                else
                {
                   return "Failed";
                }


            }
            catch (Exception ex)
            {

                return "Error: " + ex.Message;  
            }


        }

        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAllCars()
        {
            return db.Cars.ToList();
        }

        public Cars GetCar(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Cars car)
        {
            throw new NotImplementedException();
        }
    }
}
