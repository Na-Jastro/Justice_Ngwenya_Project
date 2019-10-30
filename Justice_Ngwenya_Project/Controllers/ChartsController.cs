using Justice_Ngwenya_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Justice_Ngwenya_Project.Controllers
{
    public class ChartsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult GetData()
        //{
        //    int lastName = dBEntities.Users.Where(x => x.LastName == "Ngwenya").Count();
        //    Ratio ob = new Ratio();
        //    ob.LastName = lastName;

        //    return Json(ob, JsonRequestBehavior.AllowGet);
        //}
        [HttpGet]
        public async Task<ActionResult> GetDataAsync()
        {
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://justicengwenyaprojectapi.azurewebsites.net/api/Customer/CustomerInformation");
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(responseString);
                List<Customer> customerList = JsonConvert.DeserializeObject<List<Customer>>(responseString);
                int lowEarner = customerList.Where(a => a.Salary < 100000).Count();
                int middleEarner = customerList.Where(a => a.Salary > 100000 && a.Salary < 500000).Count();
                int highEarner = customerList.Where(a => a.Salary > 500000).Count();
                SalaryRange salaryRange = new SalaryRange();
                salaryRange.LowEarner = lowEarner;
                salaryRange.MiddleEarner = middleEarner;
                salaryRange.HighEarner = highEarner;
                return Json(salaryRange, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class SalaryRange
    {
        public int LowEarner { get; set; }
        public int MiddleEarner { get; set; }
        public int HighEarner { get; set; }
    }
}