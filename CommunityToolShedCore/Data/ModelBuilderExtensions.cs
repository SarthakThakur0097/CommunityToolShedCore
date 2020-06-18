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
                  UserName = "NeoAnderson@gmail.com",
                  Email = "NeoAnderson@gmail.com",
                  FirstName = "Neo",
                  LastName = "Anderson",
                  PasswordHash = "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg=="
              },
              new ApplicationUser
              {
                  UserName = "DaveWill@gmail.com",
                  Email = "DaveWill@gmail.com",
                  FirstName = "Dave",
                  LastName = "Will",
                  PasswordHash = "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg=="
              },
              new ApplicationUser
              {
                  UserName = "SandraJosh@gmail.com",
                  Email = "SandraJosh@gmail.com",
                  FirstName = "Sandra",
                  LastName = "Josh",
                  PasswordHash = "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg=="
              }
          );
        }

        //public static async Task Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        //{
        //    await SeedUsers(userManager);
        //    await SeedRolesAsync(roleManager);
        //}
        //public static async Task SeedUsers(UserManager<ApplicationUser> userManager)
        //{
        //    ApplicationUser admin = new ApplicationUser
        //    {
        //        UserName = "NeoAnderson@sarthakthakur.com",
        //        Email = "NeoAnderson@sarthakthakur.com",
        //        FirstName = "Neo",
        //        LastName = "Anderson"
        //    };
        //    ApplicationUser person1 = new ApplicationUser
        //    {
        //        UserName = "DaveWill@sarthakthakur.com",
        //        Email = "DaveWill@sarthakthakur.com",
        //        FirstName = "Dave",
        //        LastName = "Will"
        //    };
        //    ApplicationUser person2 = new ApplicationUser
        //    {
        //        UserName = "SandraJosh@sarthakthakur.com",
        //        Email = "SandraJosh@sarthakthakur.com",
        //        FirstName = "Sandra",
        //        LastName = "Josh"
        //    };

        //    var adminResult = await userManager.CreateAsync(admin, "Dapoadsl908");

        //    var person1Result = userManager.CreateAsync(person1, "Dapoadsl908");

        //    var person2Result = userManager.CreateAsync(person2, "Dapoadsl908");
        //}
        //public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        //{
        //    IdentityRole role = new IdentityRole();
        //    role.Name = "Administrator";
        //    IdentityResult roleResult = await roleManager.CreateAsync(role);
        //}
    }
}