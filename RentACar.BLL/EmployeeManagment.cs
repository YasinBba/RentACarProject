using RentACar.DLL.Entities;
using RentACar.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class EmployeeManagment : IEmployesses
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<IEmployesses> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public void GetByDateOfBirth(DateTime dateOfBirth)
        {
            throw new NotImplementedException();
        }

        public void GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void GetByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public Employesses GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public void GetByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void Save(string firstName, string lastName, string email, string phoneNumber, string address, DateTime dateOfBirth, DateTime createdAt, int creatorId, DateTime updatedAt, int updaterId, bool isActive)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string firstName, string lastName, string email, string phoneNumber, string address, DateTime dateOfBirth, DateTime createdAt, int creatorId, DateTime updatedAt, int updaterId, bool isActive)
        {
            throw new NotImplementedException();
        }
    }
}
