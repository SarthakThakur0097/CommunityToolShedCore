using System.Collections.Generic;

namespace CommunityToolShedCore.Models.Interfaces
{
    interface ICommunityMembersRepository
    {
        CommunityMember GetById(string Id);
        IEnumerable<CommunityMember> GetAllCommunities();
        CommunityMember Add(CommunityMember communityMember);
        CommunityMember Update(CommunityMember communityMemberChanges);
        CommunityMember Delete(string Id);
    }
}
