using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public int Price { get; set; }
        public int StockQuantity { get; set; } = 0;
    }
}
