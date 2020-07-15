using CommunityToolShedCore.Models;
using CommunityToolShedCore.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace CommunityToolShedCore
{
    public class Context: IdentityDbContext<ApplicationUser>
    {
        override public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityMember> CommunityMembers { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<ToolCommunityMember> ToolCommunityMembers { get; set; }

        public Context(DbContextOptions<Context> options) :base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Community>()
                .HasMany<CommunityMember>(c => c.CommunityMembers)
                .WithOne(cm => cm.Community)
                .HasForeignKey(fk => fk.CommunityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany<CommunityMember>(c => c.CommunityMembers)
                .WithOne(cm => cm.ApplicationUser)
                .HasForeignKey(fk => fk.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany<ApplicationUserRole>(u => u.UserRoles)
                .WithOne(ur => ur.ApplicationUser)
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
