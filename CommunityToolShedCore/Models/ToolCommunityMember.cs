using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Models
{
    public class ToolCommunityMember
    {
        public ToolCommunityMember(){}

        public ToolCommunityMember(int toolId, int communityMemberId, bool isBorrowed, bool isOwner)
        {
            ToolId = toolId;
            CommunityMemberId = communityMemberId;
            IsBorrowed = isBorrowed;
            IsOwner = isOwner;
        }
        public int Id { get; set; }
        public int ToolId { get; set; }
        public Tool Tool { get; set; }
        public int CommunityMemberId { get; set; }
        public CommunityMember CommunityMember { get; set; }
        public bool IsBorrowed { get; set; }
        public bool IsOwner { get; set; }
    }
}
