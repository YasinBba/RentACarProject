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

        void Save(string brand, string model,string color,short year,decimal pricePerDay,DateTime createsAt,int creatorId,DateTime updateDate,int updateId,bool isActive);
        void Update(int id,string brand, string model, string color, short year, decimal pricePerDay, DateTime createsAt, int creatorId, DateTime updateDate, int updateId, bool isActive);
        void Delete(int id);
        Cars GetById(int id);
        List<Cars> GetAll();
        List<Cars> GetByBrand(string brand);
        void GetByModel(string model);
        void GetByColor(string color);

        void GetByYear(short year);

    }
}
