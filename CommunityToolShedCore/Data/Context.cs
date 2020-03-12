using CommunityToolShedCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe"
                    }
                );
        }

        public DbSet<User> Users { get; set; }

    }
}
