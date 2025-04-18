using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        [Required]
        public int UserID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

