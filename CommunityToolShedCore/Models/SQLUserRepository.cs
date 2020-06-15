using System.Collections.Generic;
using System.Linq;

namespace CommunityToolShedCore.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly Context context;

        public SQLUserRepository(Context context)
        {
            this.context = context;
        }
        public User Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User Delete(int Id)
        {
            User user = context.Users.Find(Id);
            if(user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            return user;
        }


        public IEnumerable<User> GetAllUsers()
        {
            return context.Users;
        }

        public User GetById(int Id)
        {
            return context.Users.Find(Id);
        }

        public User Update(User userChanges)
        {
            var updatedUser = context.Users.Attach(userChanges);
            updatedUser.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return userChanges;
        }
    }
}
