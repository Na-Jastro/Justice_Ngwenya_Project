using Justice_Ngwenya_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Justice_Ngwenya_Project.Controllers
{
    public class UserInformationController : Controller
    {
        // GET: Index Action
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        //POST GetUserInformationAsync Action
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> GetUserInformationAsync(User userId)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(userId);
            var client = new HttpClient();
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://justicengwenyaprojectapi.azurewebsites.net/api/User/GetUserInformation", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return Json(responseString);
        }

        //POST UserInformationApplyAsync Action
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> UserInformationApplyAsync(UserInformation data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(data);
            var client = new HttpClient();
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://justicengwenyaprojectapi.azurewebsites.net/api/User/InsertUserInformation", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return Json(responseString);
        }

        //POST UpdateUserInformationAsync Action
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> UpdateUserInformationAsync(UserInformation data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(data);
            var client = new HttpClient();
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://justicengwenyaprojectapi.azurewebsites.net//api/User/UpdateUserInformation", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return Json(responseString);
        }
        //POST DeleteUserInformationAsync Action
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> DeleteUserInformationAsync(DeleteUserData data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(data);
            var client = new HttpClient();
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://justicengwenyaprojectapi.azurewebsites.net/api/User/DeleteUserInformation", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return Json(responseString);
        }
    }
    public class User
    {
        public string userId { get; set; }
    }

    public class DeleteUserData
    {
        public string User_ID { get; set; }
    }
}