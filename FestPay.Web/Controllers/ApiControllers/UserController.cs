using Microsoft.AspNetCore.Mvc;
using FestPay.Web.Models.AccountViewModels;
using System.Collections.Generic;
using FestPay.Repository;

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
                "admin@gmail.com",
                "denisa@gmail.com",
                "mihnea@gmail.com",
                "dan@gmail.com",
                "matei@gmail.com",
                "alex@gmail.com",
                "marius@gmail.com"
            };
            
            return accountList.Contains(user.Email) && user.Password.Equals("parola");
        }

        [Route("register")]
        [HttpPost]
        public bool Register(RegisterViewModel user)
        { 
            UserRepository userRepository = new UserRepository(new FestPayEntities());
            // User response = userRepository.Add(new User());
            // return response != null;
            return true;
        }

        [Route("passwordForgotten")]
        [HttpGet]
        public bool RequestPassword(string email)
        {
            //get from db user
            // if there is a user, send email
            // else return false
            List<string> accountList = new List<string> {
                "admin@gmail.com",
                "denisa@gmail.com",
                "mihnea@gmail.com",
                "dan@gmail.com",
                "matei@gmail.com",
                "alex@gmail.com",
                "marius@gmail.com"
            };

            return accountList.Contains(email);
        }

    }
}
