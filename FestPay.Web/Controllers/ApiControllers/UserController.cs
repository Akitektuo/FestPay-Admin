using Microsoft.AspNetCore.Mvc;
using FestPay.Web.Models.AccountViewModels;

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
            //Question: how do you connect the db with this?
            return true;
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
