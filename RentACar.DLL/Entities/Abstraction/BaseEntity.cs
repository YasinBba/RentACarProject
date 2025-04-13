using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Entities.Abstraction
{
    public abstract class BaseEntity
    {

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int CreatorId { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int UpdaterId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
