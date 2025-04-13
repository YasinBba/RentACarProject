using RentACar.DLL.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Entities
{
    public class Cars:BaseEntity
    {
        //public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal PricePerDay { get; set; }
        //public DateTime CreatedAt { get; set; } = DateTime.Now;
        //public int CreatorId { get; set; }
        // public DateTime UpdatedAt { get; set; } = DateTime.Now;
        //public int UpdaterId { get; set; }

        //public bool IsActive { get; set; } = true;

    }
}
