using System.Collections.Generic;

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
