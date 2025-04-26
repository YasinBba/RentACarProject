using RentACar.DLL.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Entities
{
    public class Employesses:BaseEntity
    {
        public Employesses() { }
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        
        //public DateTime CreatedAt { get; set; } = DateTime.Now;
        //public int CreatorId { get; set; }
        // public DateTime UpdatedAt { get; set; } = DateTime.Now;
        //public int UpdaterId { get; set; }

        //public bool IsActive { get; set; } = true;

    }
}
