using RentACar.DLLModel.Dtos;
using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.BLL
{
    public class RentalCarManagment: IRentalCars
    {
        private readonly  YasinRentACarEntities db = new YasinRentACarEntities();

        public string AddRentalCar(RentalCars rentalCar)
        {
            try
            {
                
                db.RentalCars.Add(rentalCar);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return "Başarılı bir şekilde kaydedildi";
                }
                else
                {
                    return "Kayıt Başarısız";
                }
                
                
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message} \nDetails: {ex.InnerException?.Message}";
            }

        }

        public bool ControlSameRentalCar(string carName, string carBrand, string customerName, string carModel, int id)
        {
            if (db.RentalCars.Any(c => c.Cars.Name == carName && c.Cars.Brand == carBrand && c.Cars.Model == carModel && c.Id != id))
            {
                return true; // Car already exists
            }
            else
            {
                return false; // Car does not exist
            }

        }

        public void DeleteRentalCar(int id)
        {
            try
            {
                var rentalCar = db.RentalCars.Find(id);
                if (rentalCar != null)
                {
                    db.RentalCars.Remove(rentalCar);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }

        }

        public List<RentalCars> GetAllRentalCars()
        {
            //return db.RentalCars.ToList();
            return db.RentalCars
            .Where(c => c.IsActive == "True") // veya c.IsActive == "True" eğer string ise
            .ToList();
        }

        public RentalCars GetRentalCar(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateRentalCar(RentalCars rentalCar)
        {
            try
            {
                var existingRentalCar = db.RentalCars.Find(rentalCar.Id);
                if (existingRentalCar != null)
                {
                    existingRentalCar.CarId = rentalCar.CarId;
                    existingRentalCar.CustomerId = rentalCar.CustomerId;
                    
                    existingRentalCar.StartDate = rentalCar.StartDate;
                    existingRentalCar.EndDate = rentalCar.EndDate;
                    existingRentalCar.PricePerDay = rentalCar.PricePerDay;
                    existingRentalCar.FuelAmount = rentalCar.FuelAmount;
                    existingRentalCar.Description = rentalCar.Description;
                    
                    existingRentalCar.UpdateDate = DateTime.Now;
                    existingRentalCar.UpdatorId = rentalCar.UpdatorId;
                    existingRentalCar.IsActive = rentalCar.IsActive;

                    db.SaveChanges();
                    return "Güncelleme Başarılı";
                }
                else
                {
                    return "Kayıt Bulunamadı";
                }
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }


        }

        public List<RentalCarListDto> GetAllRentalCarListDto()
        {
            
            // Renaming the range variable to avoid conflict
            var list = (from rentalCar in db.RentalCars
                        join car in db.Cars on rentalCar.CarId equals car.Id
                        join customer in db.Customers on rentalCar.CustomerId equals customer.Id
                        join user in db.Users on rentalCar.UserId equals user.Id
                        where rentalCar.IsActive== "True" // veya rentalCar.IsActive == "True" eğer string ise

                        select new RentalCarListDto
                        {
                            Id = rentalCar.Id,
                            CarName = car.Name,
                            CustomerName = customer.FirstName + " " + customer.LastName,
                            CarBrand = car.Brand,
                            CarModel = car.Model,
                            UserName = user.UserName,
                            StartDate = rentalCar.StartDate,
                            EndDate = rentalCar.EndDate,
                            PricePerDay = (decimal)rentalCar.PricePerDay,
                            FuelAmount = (decimal)rentalCar.FuelAmount,
                            Description = rentalCar.Description,
                            CreateDate = rentalCar.CreateDate,
                            CreatorName = user.UserName,
                            UpdateDate = (DateTime)rentalCar.UpdateDate,
                            UpdatorName = user.UserName,
                            IsActive = rentalCar.IsActive
                        }).ToList();

            return list;
        }

        
    }
    
}
