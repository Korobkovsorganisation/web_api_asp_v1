using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public DateTime ExpiresAt { get; set; }
    }
}


