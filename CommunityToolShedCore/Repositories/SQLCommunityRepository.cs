using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore.Models
{
    public class SQLCommunityRepository : ICommunityRepository
    {
        private readonly Context context;

        public SQLCommunityRepository(Context context)
        {
            this.context = context;
        }

        public Community GetById(int Id)
        {
            return context.Communities.Find(Id);
        }

        public Community Add(Community community)
        {
            context.Communities.Add(community);
            context.SaveChanges();
            return community;
        }

        public Community Delete(string Id)
        {
            Community community = context.Communities.Find(Id);

            if(community != null)
            {
                context.Communities.Remove(community);
                context.SaveChanges();
            }
            return community;
        }

        public IEnumerable<Community> GetAllCommunities()
        {
            return context.Communities;
        }

        public IList<CommunityMember> GetAllMembersByCommunityId(int id)
        {
            return context.CommunityMembers
                .Include(c => c.ApplicationUser)
                .Include(c => c.Community)
                .Where(c => c.Community.Id == id)
                .ToList();
        }
        public Community Update(Community communityChanges)
        {
            var updatedCommunity = context.Communities.Attach(communityChanges);

            updatedCommunity.State = EntityState.Modified;
            context.SaveChanges();

            return communityChanges;
        }
    }
}
