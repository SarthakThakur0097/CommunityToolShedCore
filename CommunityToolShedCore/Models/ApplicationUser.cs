using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityToolShedCore.Models
{
    [NotMapped]
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }

        public ApplicationUser(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
    }
}
