using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RentACar.BLL
{
    public class UsersManagment : IUsers
    {
        public readonly object IUsers;
        YasinRentACarEntities db = new YasinRentACarEntities();

        public string AddUser(Users user)
        {
            try
            {
                bool saveResult = ControlSameUser(user.UserName, user.UserId);

                if (saveResult)
                {
                    return "Aynı Kullanıcı adında kayıt içeride mevcut";
                }

                db.Users.Add(user);
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

        public bool ControlSameUser(string userName, int id)
        {
            if (db.Users.Any(c => c.UserName == userName && c.Id != id))
            {
                return true; // User already exists
            }
            else
            {
                return false; // User does not exist
            }

        }
        public string UpdateUser(Users user)
        {
            try
            {
                var existingUser = db.Users.Find(user.Id);
                if (existingUser != null)
                {
                    existingUser.UserName = user.UserName;
                    existingUser.UserPassword = user.UserPassword;
                    existingUser.UserEmail = user.UserEmail;
                    existingUser.UserPhone = user.UserPhone;
                    existingUser.UserRole = "User"; // Bu uygulamanın gereğine göre dinamik yapılabilir
                    existingUser.Description = user.Description;

                    // CreateDate ve CreatorId DEĞİŞTİRİLMEZ!
                    existingUser.UpdateDate = DateTime.Now;
                    existingUser.UpdatorId = 1;

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        return "Güncelleme başarılı";
                    }
                    else
                    {
                        return "Güncelleme başarısız";
                    }
                }
                else
                {
                    return "Kullanıcı bulunamadı";
                }
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message + "\n" + (ex.InnerException?.Message ?? "");
            }


        }

        public void DeleteUser(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("User not found");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Users> GetAllUsers()
        {

            return db.Users.ToList();

        }

        public Users GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Users Login(string userName, string password)
        {
            try
            {
                var getUserLogin = db.Users.Where(k => k.UserName == userName && k.UserPassword == password).FirstOrDefault();
                if (getUserLogin != null)
                {
                    return getUserLogin;
                }
                else
                {
                    return getUserLogin;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ERROR:" + ex.Message);

            }
        }
    }
}
