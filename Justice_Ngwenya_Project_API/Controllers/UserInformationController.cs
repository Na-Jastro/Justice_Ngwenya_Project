using Justice_Ngwenya_Project_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Justice_Ngwenya_Project_API.Controllers
{
    public class UserInformationController : ApiController
    {

        //================================Get User Data==============================================//
        //POST GetUserInformationAsync Action
        [Route("api/User/GetUserInformation")]
        [HttpPost]
        public HttpResponseMessage GetUserInformation(User userId)
        {
            uowUserInformation UserInformation = new uowUserInformation();
            return Request.CreateResponse<string>(HttpStatusCode.OK, UserInformation.LoadUser(userId.userId));
        }
        //================================Insert User Data==============================================//
        //POST UserInformation Action
        [Route("api/User/InsertUserInformation")]
        [HttpPost]
        public HttpResponseMessage UserInformation(UserInformation userInformation)
        {
            uowUserInformation UserInformation = new uowUserInformation();
            return Request.CreateResponse<string>(HttpStatusCode.OK, UserInformation.Insert(userInformation));
        }

        //================================Update User Data==============================================//
        //POST UpdateUserInformation Action
        [Route("api/User/UpdateUserInformation")]
        [HttpPost]
        public HttpResponseMessage UpdateUserInformation(UserInformation userInformation)
        {
            uowUserInformation UserInformation = new uowUserInformation();
            return Request.CreateResponse<string>(HttpStatusCode.OK, UserInformation.Update(userInformation));
        }
        //================================Delete User Data==============================================//
        //POST DeleteUserInformation Action
        [Route("api/User/DeleteUserInformation")]
        [HttpPost]
        public string DeleteUserInformation(DeleteUserData UserId)
        {
            uowUserInformation UserInformation = new uowUserInformation();
            string user = UserId.User_ID;
            UserInformation.Delete(user);
            return "Record has successfully Deleted";
        }
    }
}
