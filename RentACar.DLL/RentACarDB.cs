using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL
{
    internal class RentACarDB:DbContext
    {


        DbSet<Cars> Cars { get; set; }
        DbSet<Customers> Customers { get; set; }
    }
}
