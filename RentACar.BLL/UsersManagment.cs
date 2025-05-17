using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace RentACar.BLL
{
    public class UsersManagment:IUsers
    {
        public readonly object IUsers;
        YasinRentACarEntities db = new YasinRentACarEntities();

        public string AddUser(DLLModel.Model.Users user)
        {
            try
            {
                bool saveResult = ControlSameUser(user.UserName,user.UserId);

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
            if (db.Users.Any(c => c.UserName == userName  && c.Id != id))
            {
                return true; // User already exists
            }
            else
            {
                return false; // User does not exist
            }

        }
        public void UpdateUser(DLLModel.Model.Users user)
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
                    existingUser.UserRole = user.UserRole;
                    existingUser.Description = user.Description;
                    existingUser.IsActive = user.IsActive;
                    existingUser.CreateDate = user.CreateDate;
                    existingUser.CreatorId = user.CreatorId;
                    existingUser.Id = user.Id;
                    existingUser.UpdatorId = user.UpdatorId;
                    existingUser.UserId = user.UserId;  
                    existingUser.UpdateDate = user.UpdateDate;


                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        throw new Exception("Success");
                    }
                    else
                    {

                        throw new Exception("Failed");

                    }


                }
                else
                {

                    throw new Exception("User not found");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);


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

                throw new Exception("ERROR:"+ex.Message);

            }
        }
    }
}
