using Microsoft.AspNetCore.Mvc;
using FestPay.Web.Models.AccountViewModels;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FestPay.Web.Controllers.ApiControllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [Route("logIn")]
        [HttpPost]
        public bool Login(UserViewModel user)
        {
            List<string> accountList = new List<string> {
                "email1",
                "email2"
            };
            //Question: how do you connect the db with this?
            return accountList.Contains(user.Email);
        }

        [Route("register")]
        [HttpGet]
        public bool Register(RegisterViewModel user)
        {
            return true;
        }

        [Route("passwordForgotten")]
        [HttpGet]
        public string RequestPassword(string email)
        {
            return email;
        }

    }
}
