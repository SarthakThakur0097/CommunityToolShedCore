using CommunityToolShedCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.ViewModels
{
    public class ListToolsApplicationUserViewModel
    {
        public IList<ToolCommunityMember> ToolCommunityMembers { get; set; }
    }
}
