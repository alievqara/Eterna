using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DAL
{
    public class AppDBC : DbContext
    {
        public AppDBC(DbContextOptions<AppDBC> options) : base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<About> About { get; set; }
    }
}
