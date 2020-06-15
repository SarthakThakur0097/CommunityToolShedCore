using CommunityToolShedCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Mary",
                    LastName = "Yessir"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Mary",
                    LastName = "Yessir"

                },
                new User
                {
                    Id = 3,
                    FirstName = "Mary",
                    LastName = "Yessir"
                }
            );
        }
    }
}