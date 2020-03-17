using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Models
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _userList;

        public MockUserRepository()
        {
            _userList = new List<User>()
            {
                new User() {FirstName = "Joan", LastName = "Deb"},
                new User() {FirstName = "Dave", LastName = "Joe"},
                new User() {FirstName = "Clyde", LastName = "Will"}
            };
        }
        public User Add(User user)
        {
            user.Id = _userList.Max(u => u.Id) + 1;
            _userList.Add(user);
            return user;
        }

        public User Delete(int Id)
        {
            User user = _userList.FirstOrDefault(u => u.Id == Id);
            if(user!=null)
            {
                _userList.Remove(user);
            }
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetById(int Id)
        {
            return _userList.FirstOrDefault(u => u.Id == Id);
        }

        public User Update(User userChanges)
        {
            User user = _userList.FirstOrDefault(u => u.Id == userChanges.Id);
            if (user != null)
            {
                user.FirstName = userChanges.FirstName;
                user.LastName = userChanges.LastName;
            }
            return user;
        }
    }
}
