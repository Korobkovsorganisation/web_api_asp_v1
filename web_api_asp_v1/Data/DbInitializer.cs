using web_api_asp_v1.Models;

namespace web_api_asp_v1.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Permissions.Any())
            {
                return; // DB has been seeded
            }

            var permissions = new Permission[]
            {
            new Permission{Name="Admin", Description="Full access"},
            new Permission{Name="Moderator", Description="Moderate content"},
            new Permission{Name="User", Description="Regular user"}
            };

            foreach (var p in permissions)
            {
                context.Permissions.Add(p);
            }
            context.SaveChanges();

            // Добавьте другие начальные данные по аналогии
        }
    }
}
