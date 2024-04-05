using System.ComponentModel.DataAnnotations;

namespace Product_Management_System.Models.Admin
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public decimal Product_Price { get; set; }
        public IFormFile? Cover_Image { get; set; }
        public string? Product_Cover_Image { get; set; }
        public List<IFormFile>? Images { get; set; }
        public string? Product_Images { get; set; }
        public int? Product_Quantity { get; set; }
        public int? Product_Status { get; set; }
        public int? Is_Deleted { get; set; }
    }
}
