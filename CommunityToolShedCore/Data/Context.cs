using CommunityToolShedCore.Models;
using CommunityToolShedCore.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore
{
    public class Context: IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options) :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<ApplicationUser> Users { get; set; }

    }
}
