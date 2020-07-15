using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunityToolShedCore.Models
{
    public class Community
    {
        public Community(string name, bool isOpen, string photoPath)
        {
            Name = name;
            IsOpen = isOpen;
            PhotoPath = photoPath;
        }
        public override string ToString()
        {
            return $"{Id}: {Name} ({(IsOpen ? "Open" : "Closed")})";
        }

        public int Id { get; set; }
        public string  Name { get; set; }
        [Display(Name = "Open")]
        public bool IsOpen { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<CommunityMember> CommunityMembers { get; set; }
    }
}
