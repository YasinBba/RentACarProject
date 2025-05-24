
using System;
using System.Collections.Generic;
using System.Linq;

using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;



namespace RentACar.BLL
{

    public class CustomerManagement : ICustomers
    {
        public readonly object ICustomer;
        YasinRentACarEntities db = new YasinRentACarEntities();

        public string AddCustomer(Customers customers)
        {
            try
            {
                bool saveResult = ControlSameCustomer(customers.FirstName, customers.LastName, customers.Email, customers.Id);
                if (saveResult)
                {
                    return "Aynı isimde kayıt içeride mevcut";
                }
                db.Customers.Add(customers);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return "Success";
                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public bool ControlSameCustomer(string firstname, string lastname, string email, int id)
        {
            if (db.Customers.Any(c => c.FirstName == firstname && c.LastName == lastname && c.Email == email && c.Id != id))
            {
                return true; // Customer already exists
            }
            else if (db.Customers.Any(c => c.FirstName == firstname
            && c.LastName == lastname && c.Email == email && c.Id != id))
            {
                return true; // Customer already exists
            }
            else
            {
                return false; // Customer does not exist
            }

        }



        public string DeleteCustomer(int id)
        {
            try
            {
                var customer = db.Customers.Find(id);
                if (customer != null)
                {
                    customer.IsActive = false; 
                    customer.UpdateDate = DateTime.Now; 
                    db.SaveChanges();
                    return "Müşteri Silindi.";
                }
                else
                {
                    return "Müşteri bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers
              .Where(c => c.IsActive == true) 
              .ToList();
            
        }

        public Customers GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customers customer)
        {
            try
            {
                var existingCustomer = db.Customers.Find(customer.Id);
                if (existingCustomer != null)
                {
                    existingCustomer.FirstName = customer.FirstName;

                    existingCustomer.Email = customer.Email;
                    existingCustomer.PhoneNumber = customer.PhoneNumber;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.Description = customer.Description;
                    existingCustomer.DateOfBirth = customer.DateOfBirth;
                    existingCustomer.UpdateDate = DateTime.Now;
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
                    Console.WriteLine("Müşteri Bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer: " + ex.Message);
            }


        }
    }
}
