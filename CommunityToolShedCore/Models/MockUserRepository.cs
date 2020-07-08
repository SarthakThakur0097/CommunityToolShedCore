using System.Collections.Generic;
using System.Linq;

namespace CommunityToolShedCore.Models
{
    public class MockUserRepository : IUserRepository
    {
        private List<ApplicationUser> _userList;

        public MockUserRepository()
        {
            _userList = new List<ApplicationUser>()
            {
                new ApplicationUser() {FirstName = "Joan", LastName = "Deb"},
                new ApplicationUser() {FirstName = "Dave", LastName = "Joe"},
                new ApplicationUser() {FirstName = "Clyde", LastName = "Will"}
            };
        }

        public ApplicationUser GetById(string Id)
        {
            return _userList.FirstOrDefault(u => u.Id.Equals(Id));
        }

        public ApplicationUser Add(ApplicationUser user)
        {
            user.Id = _userList.Max(u => u.Id) + 1;
            _userList.Add(user);
            return user;
        }

        public ApplicationUser Delete(string Id)
        {
            ApplicationUser user = _userList.FirstOrDefault(u => u.Id.Equals(Id));
            if(user!=null)
            {
                _userList.Remove(user);
            }
            return user;
        }

        public IList<ApplicationUser> GetAllUsers()
        {
            return _userList;
        }

        public ApplicationUser Update(ApplicationUser userChanges)
        {
            ApplicationUser user = _userList.FirstOrDefault(u => u.Id == userChanges.Id);
            if (user != null)
            {
                user.FirstName = userChanges.FirstName;
                user.LastName = userChanges.LastName;
            }
            return user;
        }
    }
}
