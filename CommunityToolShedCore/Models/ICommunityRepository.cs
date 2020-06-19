using System.Collections.Generic;

namespace CommunityToolShedCore.Models
{
    interface ICommunityRepository
    {
        Community GetById(string Id);
        IEnumerable<Community> GetAllCommunities();
        Community Add(Community community);
        Community Update(Community communityChanges);
        Community Delete(string Id);
    }
}
