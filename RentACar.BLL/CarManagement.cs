using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.DLL.Interfaces;
using RentACar.DLL.Entities;
using RentACar.DLL.Entities.Abstraction;

namespace RentACar.BLL
{
    public class CarManagement : ICar
    {
        public void Delete()
        {
            /* Abstract ve Interface class türleri new lenemezler , sadece OOP de KALITIM VERMEK İÇİN oluşturulur  
            BaseEntity baseEntity = new BaseEntity();
            ICar car = new ICar();
            */
            throw new NotImplementedException();
        }

        public void GetByColor(string color)
        {
            throw new NotImplementedException();
        }

        public void GetByModel(string model)
        {
            throw new NotImplementedException();
        }

        public void GetByYear(int year)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public List<Cars>  GetAll()
        {
            throw new NotImplementedException();
        }

        List<Cars> ICar.GetByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        Cars ICar.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
