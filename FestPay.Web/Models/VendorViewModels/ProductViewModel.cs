using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FestPay.Web.Models.VendorViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public List<string> Shops { get; set; }
        public string Image { get; set; }
        public string ImageURL { get; set; }
    }

    public class FilterViewModel
    {
        public string Vendor { get; set; }
        public string Search { get; set; }
        public string Category { get; set; }
    }
}
