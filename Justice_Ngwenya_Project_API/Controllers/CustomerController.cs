using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;
using Justice_Ngwenya_Project_API;
using Justice_Ngwenya_Project_API.Models;

namespace Justice_Ngwenya_Project_API.Controllers
{
    public class CustomerController : ApiController
    {
        //================================Get Customer Data==============================================//
        //POST GetUserInformationAsync Action
        [Route("api/Customer/CustomerInformation")]
        [HttpGet]
        public HttpResponseMessage CustomerInformation()
        {
            uowCustomer customer = new uowCustomer();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(customer.getAllCustomers(), Encoding.UTF8, "application/json");
            return response ;
        }

        //[Route("api/Customer/CustomerInformation")]
        //[HttpGet]
        //public string CustomerInformation()
        //{
        //    uowCustomer customer = new uowCustomer();
        //    var response = Request.CreateResponse(HttpStatusCode.OK);
        //    response.Content = new StringContent(customer.getAllCustomers(), Encoding.UTF8, "application/json");
        //    return response.ToString();
        //    //return "[{\"Name\":\"ABC\"},[{\"A\":\"1\"},{\"B\":\"2\"},{\"C\":\"3\"}]]";
        //}
    }
}//