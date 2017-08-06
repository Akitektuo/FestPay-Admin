using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FestPay.Web.Models.VendorViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FestPay.Web.Controllers.ApiControllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        [Route("products")]
        [HttpGet]
        public List<ProductViewModel> GetProducts()
        {
            var result = new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Id = 1,
                    Name = "stuff",
                    Price = 17,
                    Description = "detailed stuff",
                    ImageURL = ""
                },
                new ProductViewModel
                {
                    Id = 1,
                    Name = "stuff",
                    Price = 17,
                    Description = "detailed stuff",
                    ImageURL = ""
                }
            };
            return result;
        }
    }
}
