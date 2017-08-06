using System.ComponentModel.DataAnnotations;

namespace FestPay.Web.Models.VendorViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string ImageURL { get; set; }
    }
}
