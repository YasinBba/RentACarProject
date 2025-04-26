

using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RentACar.BLL
{
    public class CarManagement : ICar
    {
        public readonly object ICar;
        YasinRentACarEntities db = new YasinRentACarEntities();
        public string AddCar(Cars car)
        {
            try
            {
                bool saveResult = ControlSameCar(car.Name, car.Brand, car.Model);

                if (saveResult)
                {
                    return "Aynı Model,Marka ve İsimde kayıt içeride mevcut";
                }

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


        public bool ControlSameCar(string carName, string carBrand, string carModel)
        {
            if (db.Cars.Any(c => c.Name == carName && c.Brand == carBrand && c.Model == carModel))
            {
                return true; // Car already exists
            }
            else
            {
                return false; // Car does not exist
            }
        }

        public void DeleteCar(int id)
        {
            try
            {
                var car = db.Cars.Find(id);
                if (car != null)
                {
                    db.Cars.Remove(car);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

        }

        public List<Cars> GetAllCars()
        {
            return db.Cars.ToList();
        }

        public Cars GetCar(int id)
        {
            throw new NotImplementedException();
        }




        public string UpdateCar(Cars car)
        {
            try
            {
                var existingCar = db.Cars.Find(car.Id);
                if (existingCar != null)
                {
                    existingCar.Name = car.Name;
                    existingCar.Brand = car.Brand;
                    existingCar.Model = car.Model;
                    existingCar.Descrpton = car.Descrpton;
                    existingCar.UpdateDate = DateTime.Now;
                    existingCar.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        return "Güncelleme Başarılı";
                    }
                    else
                    {
                        return "Güncelleme Başarısız";
                    }
                }
                else
                {
                    return "Araç Bulunamadı";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }
        
    }
}