using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class Permission
    {
        public int PermissionID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
