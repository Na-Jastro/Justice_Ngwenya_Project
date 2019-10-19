using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Justice_Ngwenya_Project_API.Models
{
    public class uowAdmin
    {
        public int EmpID { get; set; }
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }
        public string DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }


        /////////////////////////////Save Data To DataBase///////////////////////////////////////////////
        //public string saveAdmin(Admin admin)
        //{
            
        //    using (Justice_Ngwenya_Project_API_DBEntities dBEntities = new Justice_Ngwenya_Project_API_DBEntities())
        //    {
        //        try
        //        {
        //            Admin uowAdmin = new Admin();
        //            uowAdmin.UserID = admin.UserID;
        //            uowAdmin.FirstName = admin.FirstName;
        //            uowAdmin.LastName = admin.LastName;
        //            uowAdmin.Age = admin.Age;
        //            uowAdmin.DateofBirth = admin.DateofBirth;
        //            uowAdmin.Email = admin.Email;
        //            uowAdmin.Gender = admin.Gender;
        //            uowAdmin.Phone = admin.Phone;
        //            uowAdmin.Mobile = admin.Mobile;
        //            uowAdmin.Address = admin.Address;
        //            dBEntities.Admin.Add(uowAdmin);
        //            dBEntities.SaveChanges();
        //            return "Success";
        //        }
        //        catch (Exception)
        //        {
        //            return "Failed";
        //        }
        //    }
        //}
        //public string GetUser()
        //{
        //    try
        //    {
        //        FreeBeMartEntities freeBeMartEntities = new FreeBeMartEntities();
        //        var userInformation = (from a in freeBeMartEntities.tblUser
        //                               where a.UserName == "6852"
        //                               select a).FirstOrDefault();
        //        tblUser user = new tblUser
        //        {
        //            Id = userInformation.Id,
        //            UserName = userInformation.UserName,
        //            Email = userInformation.Email,
        //            Image = userInformation.Image,
        //            Status = userInformation.Status,
        //            Name = userInformation.Name,
        //            Surname = userInformation.Surname,
        //            DateOfBirth = userInformation.DateOfBirth,
        //            Age = userInformation.Age,
        //            PhoneNo = userInformation.PhoneNo,
        //            Country = userInformation.Country,
        //            Province = userInformation.Province,
        //            City = userInformation.City,
        //            Suburb = userInformation.Suburb,
        //            PostalCode = userInformation.PostalCode,
        //            StreetName = userInformation.StreetName,
        //            ExtraFeaturesAccess = userInformation.ExtraFeaturesAccess
        //        };
        //        return new JavaScriptSerializer().Serialize(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}