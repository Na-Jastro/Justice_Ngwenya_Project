using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Justice_Ngwenya_Project.Models
{
    public class UserInformation
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

    }
}