using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Interfaces
{
    public interface ICar
    {
        //Interface normal bir class gibi çalışmaz, methodlar sadece gövdelerini (imzalarını) tutar.

        void Save();
        void Update();
        void Delete();
        Cars GetById(int id);
        List<Cars> GetAll();
        List<Cars> GetByBrand(string brand);
        void GetByModel(string model);
        void GetByColor(string color);

        void GetByYear(int year);

    }
}
