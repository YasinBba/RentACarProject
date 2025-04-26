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

        public List<RentalCarListDto> GetAllRentalCarListDto()
        {
            //Linq ile join kodlamak
            var list = (from rc in db.RentalCars
                        join c in db.Cars on rc.CarId equals c.Id
                        join cu in db.Customers on rc.CustomerId equals cu.Id
                        join u in db.Users on rc.UserId equals u.Id
                        select new RentalCarListDto
                        {
                            Id = rc.Id,
                            CarName = c.Name,
                            CarBrand = c.Brand,
                            CarModel = c.Model,
                            CustomerName = cu.FirstName+" "+cu.LastName,
                            UserName = u.UserName,
                            StartDate = rc.StartDate,
                            EndDate = rc.EndDate,
                            PricePerDay = rc.PricePerDay,
                            FuelAmount = rc.FuelAmount,
                            Description = rc.Description,
                            CreateDate = rc.CreateDate,
                            CreatorName = u.UserName,
                            UpdateDate = rc.UpdateDate,
                            UpdatorName = u.UserName,
                            IsActive = rc.IsActive
                        }).ToList();

            return list;
        }
    }
    
}
