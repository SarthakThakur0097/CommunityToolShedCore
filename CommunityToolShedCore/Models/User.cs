using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CommunityToolShedCore.Models
{
    public class User
    { 
        public User(){}

        public User(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
        public User(int id, string lastName, string firstName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
    }
}
