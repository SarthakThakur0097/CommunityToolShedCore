using CommunityToolShedCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.ViewModels
{
    public class CommunityMembersViewModel
    {
        public int CommunityId { get; set; }
        public IList<CommunityMember> CommunityMembers { get; set; }
    }
}
