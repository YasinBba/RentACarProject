

using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
namespace RentACar.BLL
{
    public class EmployeeManagment : IEmployees
    {
        public string AddEmployee(Employess employee)
        {
            throw new NotImplementedException();
        }

        public bool ControlSameEmployee(string firstName, string lastName, string email, int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employess> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employess GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employess employee)
        {
            throw new NotImplementedException();
        }
    }
}
