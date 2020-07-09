using CommunityToolShedCore.Models;
using CommunityToolShedCore.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Repositories
{
    public class SQLCommunityMembersRepository : ICommunityMembersRepository
    {
        private readonly Context context;

        public SQLCommunityMembersRepository(Context context)
        {
            this.context = context;
        }


        CommunityMember ICommunityMembersRepository.GetById(string Id)
        {
            return context.CommunityMembers.Find(Id);
        }

        public CommunityMember Add(CommunityMember communityMember)
        {
            context.CommunityMembers.Add(communityMember);
            context.SaveChanges();

            return communityMember;
        }

        public CommunityMember Delete(string Id)
        {
            CommunityMember community = context.CommunityMembers.Find(Id);

            if (community != null)
            {
                context.CommunityMembers.Remove(community);
                context.SaveChanges();
            }
            return community;
        }

        public IEnumerable<CommunityMember> GetAllCommunities()
        {
            return context.CommunityMembers;
        }

        public Community GetById(string Id)
        {
            return context.Communities.Find(Id);
        }

        public IList<CommunityMember> GetAllMembersByCommunityId(int id)
        {
            return context.CommunityMembers
                .Include(c => c.ApplicationUser)
                .Include(c => c.Community)
                .Where(c => c.Id == id)
                .ToList();
        }
        public CommunityMember Update(CommunityMember communityChanges)
        {
            var updatedCommunity = context.CommunityMembers.Attach(communityChanges);

            updatedCommunity.State = EntityState.Modified;
            context.SaveChanges();

            return communityChanges;
        }
    }
}
