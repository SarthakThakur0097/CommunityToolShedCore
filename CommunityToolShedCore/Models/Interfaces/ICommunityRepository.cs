using System.Collections.Generic;

namespace CommunityToolShedCore.Models
{
    interface ICommunityRepository
    {
        Community GetById(int Id);
        IList<Community> GetAllCommunities();
        Community Add(Community community);
        Community Update(Community communityChanges);
        Community Delete(string Id);
    }
}
