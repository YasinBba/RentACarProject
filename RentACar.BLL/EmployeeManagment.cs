

using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
namespace RentACar.BLL
{
    public class EmployeeManagment : IEmployees
    {
        YasinRentACarEntities db = new YasinRentACarEntities();
        public readonly object IEmployees;
        public string AddEmployee(Employess employee)
        {
            try
            {
                bool saveResult = ControlSameEmployee(employee.FirstName, employee.LastName, employee.Email, employee.Id);
                if (saveResult)
                {
                    return "Aynı İsimde kayıt içeride mevcut";
                }
                db.Employess.Add(employee);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return "Kayıt Başarılı";
                }
                else
                {
                    return "Kayıt Başarısız";
                }


            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }
        }

        public bool ControlSameEmployee(string firstName, string lastName, string email, int id)
        {
            if (db.Employess.Any(c => c.FirstName == firstName && c.LastName == lastName && c.Email == email && c.Id != id))
            {
                return true; // Employee already exists
            }
            else
            {
                return false; // Employee does not exist
            }

        }

        public void DeleteEmployee(int id)
        {
            try
            {
                var employee = db.Employess.Find(id);
                if (employee != null)
                {
                    db.Employess.Remove(employee);
                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        Console.WriteLine("Silme Başarılı.");
                    }
                    else
                    {
                        Console.WriteLine("Silme Başarısız.");
                    }
                }
                else
                {
                    Console.WriteLine("Çalışan Bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting employee: " + ex.Message);
            }

        }

        public List<Employess> GetAllEmployees()
        {
            return db.Employess.ToList();


        }

        public Employess GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employess employee)
        {
            try
            {
                var existingEmployee = db.Employess.Find(employee.Id);
                if (existingEmployee != null)
                {
                    existingEmployee.FirstName = employee.FirstName;
                    existingEmployee.LastName = employee.LastName;
                    existingEmployee.Email = employee.Email;
                    existingEmployee.PhoneNumber = employee.PhoneNumber;
                    existingEmployee.Address = employee.Address;
                    existingEmployee.Description = employee.Description;
                    existingEmployee.UpdateDate = DateTime.Now;
                    existingEmployee.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        Console.WriteLine("Güncelleme Başarılı.");
                    }
                    else
                    {
                        Console.WriteLine("Güncelleme Başarısız.");

                    }

                }
                else
                {
                    Console.WriteLine("Çalışan Bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating employee: " + ex.Message);
            }


        }
    }
}
