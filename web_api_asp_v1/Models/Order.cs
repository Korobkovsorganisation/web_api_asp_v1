using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public DateTime OrderAt { get; set; }
        public string Status { get; set; }
        [Required]
        public int TotalAmount { get; set; }   
    }
}
