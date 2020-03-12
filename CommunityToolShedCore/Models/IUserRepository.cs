using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Models
{
    interface IUserRepository
    {
        User GetById(int Id);
        IEnumerable<User> GetAllUsers();
        User Add(User user);
        User Update(User userChanges);
        User Delete(int Id);
    }
}
