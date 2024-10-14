using Microsoft.EntityFrameworkCore;
using MVCSampleApp.Models.Entity;

namespace MVCSampleApp.Data
{
    public class MVCSampleAppContext : DbContext
    {
        public MVCSampleAppContext (DbContextOptions<MVCSampleAppContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
    }
}
