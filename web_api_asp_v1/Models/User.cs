using System.ComponentModel.DataAnnotations;

namespace web_api_asp_v1.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

        public DateTime? LastLogin { get; set; }

        public ICollection<Permission> Permissions { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
        public User()
        {
            Permissions = new List<Permission>();
            Carts = new List<Cart>();
            Orders = new List<Order>();
        }
        public void AddDefaultPermission(Permission permission)
        {
            if (permission != null && !Permissions.Any(p => p.Name == permission.Name))
            {
                Permissions.Add(permission);
            }
        }
    }
}
