using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IEmployees
    {
        string AddEmployee(Employess employee);
        Employess GetEmployee(int id);
        void UpdateEmployee(Employess employee);
        List<Employess> GetAllEmployees();
        void DeleteEmployee(int id);

        bool ControlSameEmployee(string firstName, string lastName, string email, int id);

    }
}
