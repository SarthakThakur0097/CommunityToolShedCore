using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunityToolShedCore.Models
{
    public class Community
    {
        public Community(string name, bool isOpen)
        {
            Name = name;
            IsOpen = isOpen;
        }
        public override string ToString()
        {
            return $"{Id}: {Name} ({(IsOpen ? "Open" : "Closed")})";
        }

        public int Id { get; set; }
        public string  Name { get; set; }
        [Display(Name = "Open")]
        public bool IsOpen { get; set; }
        public ICollection<CommunityMember> CommunityMembers { get; set; }
    }
}
