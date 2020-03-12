using CommunityToolShedCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Data
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Database.Migrate();
            User user = new User("Bob", "Smith");
            context.Add(user);
            context.SaveChanges();
        }
    }
}