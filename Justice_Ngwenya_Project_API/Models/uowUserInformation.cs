using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Justice_Ngwenya_Project_API.Models
{
    public class uowUserInformation
    {
        public int ID { get; set; }
        public string User_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Gender { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Organization { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Postal_Code { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }

        //=========================================Get User Information Function=======================================================
        public string LoadUser(string userId)
        {
            using (Justice_Ngwenya_Project_API_DBEntities dBEntities = new Justice_Ngwenya_Project_API_DBEntities())
            {
                try
                {
                    var user = (from a in dBEntities.UserInformation
                                           where a.User_ID == userId
                                           select a).FirstOrDefault();

                    UserInformation uowUserInformation = new UserInformation
                    {
                        User_ID = user.User_ID,
                        First_Name = user.First_Name,
                        Last_Name = user.Last_Name,
                        Gender = user.Gender,
                        Organization = user.Organization,
                        Phone_Number = user.Phone_Number,
                        Postal_Code = user.Postal_Code,
                        Province = user.Province,
                        Email = user.Email,
                        Date_Of_Birth = user.Date_Of_Birth,
                        Country = user.Country,
                        City = user.City,
                        Age = user.Age,
                        Address = user.Address
                    };
                    return new JavaScriptSerializer().Serialize(uowUserInformation);
                }
                catch (Exception)
                {
                    return "Failed";
                }
            }
        }

        /////////////////////////////Insert Data To DataBase Function///////////////////////////////////////////////
        public string Insert(UserInformation userInformation)
        {
            using (Justice_Ngwenya_Project_API_DBEntities dBEntities = new Justice_Ngwenya_Project_API_DBEntities())
            {
                try
                {
                    UserInformation uowUserInformation = new UserInformation();
                    uowUserInformation.User_ID = userInformation.User_ID;
                    uowUserInformation.First_Name = userInformation.First_Name;
                    uowUserInformation.Last_Name = userInformation.Last_Name;
                    uowUserInformation.Gender = userInformation.Gender;
                    uowUserInformation.Organization = userInformation.Organization;
                    uowUserInformation.Phone_Number = userInformation.Phone_Number;
                    uowUserInformation.Postal_Code = userInformation.Postal_Code;
                    uowUserInformation.Province = userInformation.Province;
                    uowUserInformation.Email = userInformation.Email;
                    uowUserInformation.Date_Of_Birth = userInformation.Date_Of_Birth;
                    uowUserInformation.Country = userInformation.Country;
                    uowUserInformation.City = userInformation.City;
                    uowUserInformation.Age = userInformation.Age;
                    uowUserInformation.Address = userInformation.Address;
                    dBEntities.UserInformation.Add(uowUserInformation);
                    dBEntities.SaveChanges();
                    return "Success";
                }
                catch (Exception)
                {
                    return "Failed";
                }
            }
        }

        //===========================================Update UserInformation Function ===========================================================
        public string Update(UserInformation userInformation)
        {
            using (Justice_Ngwenya_Project_API_DBEntities dBEntities = new Justice_Ngwenya_Project_API_DBEntities())
            {
                try
                {
                    var user = (from a in dBEntities.UserInformation
                                where a.User_ID == userInformation.User_ID
                                select a).FirstOrDefault();
                    user.First_Name = userInformation.First_Name;
                    user.Last_Name = userInformation.Last_Name;
                    user.Gender = userInformation.Gender;
                    user.Organization = userInformation.Organization;
                    user.Phone_Number = userInformation.Phone_Number;
                    user.Postal_Code = userInformation.Postal_Code;
                    user.Province = userInformation.Province;
                    user.Email = userInformation.Email;
                    user.Date_Of_Birth = userInformation.Date_Of_Birth;
                    user.Country = userInformation.Country;
                    user.City = userInformation.City;
                    user.Age = userInformation.Age;
                    user.Address = userInformation.Address;
                    dBEntities.SaveChanges();
                    return "Success";
                }
                catch (Exception)
                {
                    return "Failed";
                }
            }
        }
        //=======================================Delete User Function============================================
        public string Delete(string userID)
        {
            using (Justice_Ngwenya_Project_API_DBEntities dBEntities = new Justice_Ngwenya_Project_API_DBEntities())
            {
                try
                {
                    UserInformation info = dBEntities.UserInformation.Single(a => a.User_ID == userID);
                    dBEntities.UserInformation.Remove(info);
                    dBEntities.SaveChanges();
                    return "Success";
                }
                catch (Exception)
                {
                    return "Failed";
                }
            }
        }
    }
}
