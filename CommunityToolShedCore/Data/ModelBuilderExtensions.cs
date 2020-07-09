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
                  UserName = "NeoAnderson@sarthakthakur.com",
                  Email = "NeoAnderson@sarthakthakur.com",
                  FirstName = "Neo",
                  LastName = "Anderson",
                  PasswordHash = "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA=="
              },
              new ApplicationUser
              {
                  UserName = "DaveWill@sarthakthakur.com",
                  Email = "DaveWill@sarthakthakur.com",
                  FirstName = "Dave",
                  LastName = "Will",
                  PasswordHash = "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA=="
              },
              new ApplicationUser
              {
                  UserName = "SandraJosh@sarthakthakur.com",
                  Email = "SandraJosh@sarthakthakur.com",
                  FirstName = "Sandra",
                  LastName = "Josh",
                  PasswordHash = "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA=="
              }
          );
        }
    }
}