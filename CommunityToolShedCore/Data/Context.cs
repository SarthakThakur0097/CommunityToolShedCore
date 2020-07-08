using CommunityToolShedCore.Models;
using CommunityToolShedCore.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CommunityToolShedCore
{
    public class Context: IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options) :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<ApplicationUser>()
              .HasMany(c => c.UserRoles)
              .WithOne()
              .OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<ApplicationUser>()
            //        .HasOne(c => c.State)
            //        .WithOne()
            //        .OnDelete(DeleteBehavior.Restrict);
        }

        override public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Community> Communities { get; set; }

    }
}
