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
                if (true )
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
            return db.BrokenCars.ToList();

        }

        public BrokenCars GetBrokenCar(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBrokenCar(BrokenCars brokenCar)
        {
            try
            {
                var existingBrokenCar = db.BrokenCars.Find(brokenCar.Id);
                if (existingBrokenCar != null)
                {
                    existingBrokenCar.CarId = brokenCar.CarId;
                    existingBrokenCar.CustomerId = brokenCar.CustomerId;
                    existingBrokenCar.BrokenDescription = brokenCar.BrokenDescription;
                    existingBrokenCar.CreateDate = brokenCar.CreateDate;
                    existingBrokenCar.CreatorId = brokenCar.CreatorId;
                    existingBrokenCar.UpdateDate = brokenCar.UpdateDate;
                    existingBrokenCar.UpdatorId = brokenCar.UpdatorId;
                    existingBrokenCar.Description = brokenCar.Description;
                    existingBrokenCar.IsActive = brokenCar.IsActive;
                    existingBrokenCar.Cars = brokenCar.Cars;
                    existingBrokenCar.Customers = brokenCar.Customers;
                    existingBrokenCar.Users = brokenCar.Users;

                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

               throw new Exception   ("Error: " + ex.Message);
            }
            
        }
        public List<BrokenCarListDto> GetAllBrokenCarListDto()
        {
            //Linq ile join kodlamak
            //Linq ile join kodlamak
            

            
            var list = (from bc in db.BrokenCars
                        join c in db.Cars on bc.CarId equals c.Id
                        join cu in db.Customers on bc.CustomerId equals cu.Id
                        join u in db.Users on bc.CreatorId equals u.Id
                        join rc in db.RentalCars on bc.CustomerId equals rc.Id
                        select new BrokenCarListDto
                        {
                            Id = bc.Id,
                            CarName = c.Name,
                            CarBrand = c.Brand,
                            CarModel = c.Model,
                            CustomerName = cu.FirstName ,
                            UserName = u.UserName,
                            StartDate = rc.StartDate,
                            EndDate = rc.EndDate,
                            
                            Description = bc.Description,
                            CreateDate = bc.CreateDate,
                            CreatorName = u.UserName,
                            UpdateDate = bc.UpdateDate,
                            UpdatorName = u.UserName,
                            IsActive = bc.IsActive
                        }).ToList();
            return list;
        }
    }
}
