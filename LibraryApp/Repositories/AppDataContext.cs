using LibraryApp.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories
{
    /// <summary>
    /// Connecting to and creating tables in database
    /// </summary>
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Usergroup> Usergroups { get; set; }

        public DbSet<Outloan> Outloans { get; set; }

        public DbSet<Review> Reviews { get; set; }
        
        public DbSet<Recommendation> Recommendations { get; set; }
    }
}