using CommunityToolShedCore.Models;
using CommunityToolShedCore.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CommunityToolShedCore
{
    public class Context: IdentityDbContext<ApplicationUser>
    {
        override public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityMember> CommunityMembers { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<ToolApplicationUser> ToolApplicationUsers { get; set; }

        public Context(DbContextOptions<Context> options) :base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

    }
}
