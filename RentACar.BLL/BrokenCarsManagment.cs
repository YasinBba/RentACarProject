using RentACar.DLLModel;
using RentACar.DLLModel.Dtos;
using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    public class BrokenCarsManagment : IBrokenCars
    {
        private readonly YasinRentACarEntities db = new YasinRentACarEntities();

        public string AddBrokenCar(BrokenCars brokenCar)
        {
            try
            {
                  
                db.BrokenCars.Add(brokenCar);
                int result = db.SaveChanges();
                if (result > 0 )
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

        public bool ControlSameBrokenCar(string carName, string carBrand, string carModel, int id)
        {
            if (db.BrokenCars.Any(c => c.Cars.Name == carName && c.Cars.Brand == carBrand && c.Cars.Model == carModel && c.Id != id))
            {
                return true; // Car already exists
            }
            else
            {
                return false; // Car does not exist
            }

        }

        public void DeleteBrokenCar(int id)
        {
            try
            {
                var brokenCar = db.BrokenCars.Find(id);
                if (brokenCar != null)
                {
                    db.BrokenCars.Remove(brokenCar);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw new Exception ("Error: " + ex.Message);
            }

        }

        public List<BrokenCars> GetAllBrokenCars()
        {
            return db.BrokenCars
            .Where(b => b.IsActive == "True") // veya c.IsActive == "True" eğer string ise
            .ToList();

        }

        public BrokenCars GetBrokenCar(int id)
        {
            throw new NotImplementedException();
        }

        
        public List<BrokenCarListDto> GetAllBrokenCarListDto()
        {
            //Linq ile join kodlamak
            //Linq ile join kodlamak
            

            
            var list = (from b in db.BrokenCars
                        join c in db.Cars on b.CarId equals c.Id
                        join cu in db.Customers on b.CustomerId equals cu.Id
                        join u in db.Users on b.CreatorId equals u.Id
                        
                        where b.IsActive == "True"
                        select new BrokenCarListDto
                        {
                            Id = b.Id,
                            CarName = c.Name,
                            CarBrand = c.Brand,
                            CarModel = c.Model,
                            CustomerName = cu.FirstName ,
                            UserName = u.UserName,
                            
                            
                            Description = b.Description,
                            CreateDate = b.CreateDate,
                            CreatorName = u.UserName,
                            UpdateDate = b.UpdateDate,
                            UpdatorName = u.UserName,
                            IsActive = b.IsActive
                        }).ToList();
            
            return list;
        }

        public string UpdateBrokenCar(BrokenCars brokenCar)
        {
            try
            {
                var existingBrokenCar = db.BrokenCars.Find(brokenCar.Id);
                if (existingBrokenCar != null)
                {
                    existingBrokenCar.CarId = brokenCar.CarId;
                    existingBrokenCar.CustomerId = brokenCar.CustomerId;
                    existingBrokenCar.BrokenDescription = brokenCar.BrokenDescription;
                    existingBrokenCar.UpdateDate = brokenCar.UpdateDate;
                    existingBrokenCar.UpdatorId = brokenCar.UpdatorId;
                    existingBrokenCar.IsActive = brokenCar.IsActive;

                    db.SaveChanges();
                    return "Güncelleme başarılı";
                }
                else
                {
                    return "Kayıt bulunamadı";
                }
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }
        }
    }
}
