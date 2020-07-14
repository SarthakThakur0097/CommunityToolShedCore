using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Models
{
    public class Tool
    {
        public Tool() { }
        public Tool(string name, string description)
        {
            Name = name;
            Description = description;
            ToolApplicationUsers = new List<ToolCommunityMember>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ToolCommunityMember> ToolApplicationUsers { get; set; }
    }
}
