using Justice_Ngwenya_Project.Models;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Justice_Ngwenya_Project.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        //Get GetCustomerAsync 
        [HttpGet]
        
        public async Task<ActionResult> GetCustomerAsync()
        {
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://localhost:44312/api/Customer/CustomerInformation");
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(responseString);
                List<Customer> customerList = JsonConvert.DeserializeObject<List<Customer>>(responseString);
                return Json(new { data = customerList }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
             {
                throw ex;
            }
        }
    }
}

