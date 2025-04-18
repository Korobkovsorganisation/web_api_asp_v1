using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class CartItems
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
