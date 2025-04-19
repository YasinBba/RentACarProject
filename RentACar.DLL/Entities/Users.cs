using RentACar.DLL.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Entities
{
    public class Users: BaseEntity
    {
        public string UserName { get; set; }
       
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
       
        public string UserRole { get; set; } // Admin, User, etc.
        public int UserId { get; set; }



    }
}
