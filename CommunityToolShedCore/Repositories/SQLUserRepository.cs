using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly Context context;

        public SQLUserRepository(Context context)
        {
            this.context = context;
        }
        public ApplicationUser Add(ApplicationUser user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public ApplicationUser Delete(string Id)
        {
            ApplicationUser user = context.Users.Find(Id);
            if(user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            return user;
        }

        public IList<ApplicationUser> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public ApplicationUser GetById(string Id)
        {
            return context.Users.Find(Id);
        }

        //public IList<ApplicationUser> GetAllMembersByCommunityId(int Id)
        //{
        //    return context.Users.Find(Id).;
        //}

        public ApplicationUser Update(ApplicationUser userChanges)
        {
            var updatedUser = context.Users.Attach(userChanges);
            updatedUser.State = EntityState.Modified;
            context.SaveChanges();
            return userChanges;
        }
    }
}
