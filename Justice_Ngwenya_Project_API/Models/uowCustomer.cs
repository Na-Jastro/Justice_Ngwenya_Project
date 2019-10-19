using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Justice_Ngwenya_Project_API.Models
{
    public class uowCustomer
    {
        //Get all Customers
        public string getAllCustomers()
        {
            try
            {
                List<Customer> customerList = new List<Customer>();
                using (Justice_Ngwenya_Project_API_DBEntities db = new Justice_Ngwenya_Project_API_DBEntities())
                {
                    customerList = db.Customer.ToList<Customer>();
                    return JsonConvert.SerializeObject(customerList);
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}