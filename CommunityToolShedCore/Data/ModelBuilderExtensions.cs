using CommunityToolShedCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Email = "NeoAnderson@gmail.com",
                    FirstName = "Neo",
                    LastName = "Anderson",
                },
                new ApplicationUser
                {
                    Email = "DaveWill@gmail.com",
                    FirstName = "Dave",
                    LastName = "Will",

                },
                new ApplicationUser
                {
                    Email = "SandraJosh@gmail.com",
                    FirstName = "Sandra",
                    LastName = "Josh",
                }
            );
        }
    }
}