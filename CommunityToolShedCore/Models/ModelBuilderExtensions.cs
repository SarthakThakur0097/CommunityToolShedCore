using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe"
                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "Mary",
                        LastName = "Smith"
                    }
                    ,
                    new User
                    {
                        Id = 3,
                        FirstName = "Will",
                        LastName = "Iam"
                    }
                );
        }
    }
}
