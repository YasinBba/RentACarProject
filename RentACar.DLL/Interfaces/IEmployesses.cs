using RentACar.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLL.Interfaces
{
    public interface IEmployesses
    {
        void Save(string firstName, string lastName, string email, string phoneNumber, string address, DateTime dateOfBirth, DateTime createdAt, int creatorId, DateTime updatedAt, int updaterId, bool isActive);
        void Update(int id, string firstName, string lastName, string email, string phoneNumber, string address, DateTime dateOfBirth, DateTime createdAt, int creatorId, DateTime updatedAt, int updaterId, bool isActive);
        void Delete(int id);

        Employesses GetById(int id);
        List<IEmployesses> GetAll();
        void GetByFirstName(string firstName);
        void GetByLastName(string lastName);
        void GetByEmail(string email);
        void GetByPhoneNumber(string phoneNumber);
        void GetByAddress(string address);
        void GetByDateOfBirth(DateTime dateOfBirth);

    }
}
