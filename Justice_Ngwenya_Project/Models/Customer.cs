using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Justice_Ngwenya_Project.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}