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

        //"Global" variables go here

        private static string shop = "Pancake House";

        private static List<ProductViewModel> products = new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Id = 1,
                    Name = "Con-Carne",
                    Price = 13,
                    Description = "300g Piept de pui, ardei gras, morcov, ceapa, vin, sos Pancake House, clatita.",
                    Category = "Clatite aperitiv",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/83d849b5-a4a4-4a2c-9119-724a0891d7e7_20x"
                },
                new ProductViewModel
                {
                    Id = 2,
                    Name = "Carni-Vora",
                    Price = 15,
                    Description = "350g Piept de pui, ardei gras, morcov, ciuperci, ceapa, vin, sos Pancake House, clatita.",
                    Category = "Clatite aperitiv",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/96322be9-747b-41da-a5f4-5b566d7425b8_20x"
                },
                new ProductViewModel
                {
                    Id = 3,
                    Name = "Ierbi-Vora",
                    Price = 12,
                    Description = "350g Ciuperci, dovlecel, morcov, ardei gras, ceapa, praf de usturoi, sos Pancake House, clatita.",
                    Category = "Clatite aperitiv",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/b9513a05-f6c6-439b-8e25-a6a7418f89b3_20x"
                },
                new ProductViewModel
                {
                    Id = 4,
                    Name = "Dolofana",
                    Price = 8,
                    Description = "240g Sunca presata, mozzarella, ardei gras, piper, sos Pancake House.",
                    Category = "Clatite aperitiv",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/8af8add5-ecc2-42f4-a6ec-a3ec50c8bcec_20x"
                },
                new ProductViewModel
                {
                    Id = 5,
                    Name = "Miorita",
                    Price = 5,
                    Description = "140g Urda sarata, smantana, marar.",
                    Category = "Clatite aperitiv",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/5ef1d89f-336a-414c-b8df-d89824dd93ca_20x"
                },
                new ProductViewModel
                {
                    Id = 6,
                    Name = "Romaneasca",
                    Price = 5,
                    Description = "140g Telemea, smantana, patrunjel, boia dulce.",
                    Category = "Clatite aperitiv",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/5d3debaf-8015-4952-9ed7-91adcf0ee80a_20x"
                },
                new ProductViewModel
                {
                    Id = 7,
                    Name = "Salata Te \"PUI\" bine",
                    Price = 13,
                    Description = "400g Piept de pui aromat, rosii, castraveti, branza Feta, masline, ceapa rosie.",
                    Category = "Salate fresh",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/659bbbf5-b9a4-4bf6-b4b3-8ad056aa48e8_20x"
                },
                new ProductViewModel
                {
                    Id = 8,
                    Name = "Salata Pui crispy strip-tease",
                    Price = 13,
                    Description = "400g Piept de pui crispy, rosii, castraveti, ardei gras, porumb, masline, ceapa rosie.",
                    Category = "Salate fresh",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/acba110a-93d6-44eb-b2bc-03a1adfa5c6d_20x"
                },
                new ProductViewModel
                {
                    Id = 9,
                    Name = "Salata Ton-ificata",
                    Price = 14,
                    Description = "400g Ton maruntit in suc propriu, porumb, masline, rosii, ceapa rosie, lamaie.",
                    Category = "Salate fresh",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/cd1ad492-9c58-4abd-9a9c-c2b356191117_20x"
                },
                new ProductViewModel
                {
                    Id = 10,
                    Name = "Salata Somon-tam",
                    Price = 17,
                    Description = "400g Somon afumat, rosii, castraveti, masline, porumb, lamaie.",
                    Category = "Salate fresh",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/7dbe925a-6e5b-4328-a34d-f17f5586b675_20x"
                },
                new ProductViewModel
                {
                    Id = 11,
                    Name = "Salata Hot-News",
                    Price = 13,
                    Description = "400g Sunca presata, branza Feta, rosii, castraveti murati, ardei iute murat, fulgi de peperoncino.",
                    Category = "Salate fresh",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/9910cdc8-a498-4a98-8bc4-30d69e572e26_20x"
                },
                new ProductViewModel
                {
                    Id = 12,
                    Name = "Salata Legumioasa",
                    Price = 10,
                    Description = "400g Roșii, castraveți, ardei gras, măsline, porumb, ceapă roșie.",
                    Category = "Salate fresh",
                    Shop = shop,
                    ImageURL = "https://d1pvbaglzn4ury.cloudfront.net/r/i/d908b7c0-1cf1-4aff-b4be-d321917ac643_20x"
                }
            };

        [Route("products")]
        [HttpGet]
        public List<ProductViewModel> GetProducts()
        {
            return products;
        }

        [Route("vendor")]
        [HttpGet]
        public List<ProductViewModel> GetProducts(string vendor)
        {
            return products.Where(p => p.Shop.Contains(vendor)).ToList();
        }

        [Route("search")]
        [HttpGet]
        public List<ProductViewModel> GetProducts(string vendor, string search)
        {
            return products.Where(p => p.Shop.Contains(vendor) && (p.Name.ToLower().Contains(search.ToLower()) || p.Description.ToLower().Contains(search.ToLower()))).ToList();
        }

        [Route("category")]
        [HttpGet]
        public List<ProductViewModel> GetProducts(string vendor, string search, string category)
        {
            return products.Where(p =>
                p.Shop.Contains(vendor) && p.Category.Equals(category) && (p.Name.ToLower().Contains(search.ToLower()) || p.Description.ToLower().Contains(search.ToLower()))).ToList();
        }

        [Route("pay")]
        [HttpPost]
        public bool Pay(PayViewModel pay)
        {
            return true;
        }

    }
}
