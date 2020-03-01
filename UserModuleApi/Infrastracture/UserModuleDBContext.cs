using Microsoft.EntityFrameworkCore;
using UserModuleApi.Models;

namespace UserModuleApi.Infrastracture
{
    public class UserModuleDBContext : DbContext
    {
        public UserModuleDBContext(DbContextOptions<UserModuleDBContext> options)
          : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}