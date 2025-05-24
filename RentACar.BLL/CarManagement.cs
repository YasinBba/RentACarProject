

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

        public string DeleteCar(int id)
        {
            try
            {
                var car = db.Cars.Find(id);
                if (car != null)
                {
                    
                    car.IsActive = false; // soft delete = pasifleştirme
                    car.UpdateDate = DateTime.Now; // varsa
                    db.SaveChanges();
                    return "Araç pasif hale getirildi.";
                }
                else
                {
                    return "Araç bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }

        }

        public List<Cars> GetAllCars()
        {
            
            return db.Cars
            .Where(c => c.IsActive == true) // veya c.IsActive == "True" eğer string ise
            .ToList();
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
                    existingCar.PricePerDay = car.PricePerDay;
                    existingCar.FuelAmount = car.FuelAmount;
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