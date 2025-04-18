using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class Migrations
    {
        public int MigrationID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public DateTime AppliedAt { get; set; }

    }   
}
