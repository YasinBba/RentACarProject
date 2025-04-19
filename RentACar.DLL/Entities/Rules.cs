using RentACar.DLL.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Entities
{
    public class Rules:BaseEntity
    {
        public string RuleName { get; set; }
        public string RuleDescription { get; set; }
        public int RuleDuration { get; set; } // in days
        public decimal RulePrice { get; set; } // price per day
        public int RentalCarId { get; set; }


    }
}
