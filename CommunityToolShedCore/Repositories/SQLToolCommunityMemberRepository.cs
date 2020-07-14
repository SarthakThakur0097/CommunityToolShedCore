using System.Collections.Generic;
using System.Linq;
using CommunityToolShedCore.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore.Models
{
    public class SQLToolCommunityMemberRepository : IToolApplicationUserRepository
    {
        private readonly Context context;

        public SQLToolCommunityMemberRepository(Context context)
        {
            this.context = context;
        }

        public IList<ToolCommunityMember> GetAllToolsByUserId(int id)
        {
            return context.ToolCommunityMembers
                    .Include(t => t.Tool)
                    .Include(t => t.CommunityMember)
                    .Where(t => t.CommunityMemberId == id)
                    .ToList();
        }
        public IList<ToolCommunityMember> GetAllToolsByCommunityId(int id)
        {
            return context.ToolCommunityMembers
                    .Include(t => t.Tool)
                    .Include(t => t.CommunityMember)
                    .Where(t => t.CommunityMemberId == id)
                    .ToList();
        }
        public ToolCommunityMember Add(ToolCommunityMember tool)
        {
            context.ToolCommunityMembers.Add(tool);
            context.SaveChanges();
            return tool;
        }

        public ToolCommunityMember Delete(string Id)
        {
            ToolCommunityMember toolApplicationUsers = context.ToolCommunityMembers.Find(Id);

            if (toolApplicationUsers != null)
            {
                context.ToolCommunityMembers.Remove(toolApplicationUsers);
                context.SaveChanges();
            }
            return toolApplicationUsers;
        }

        public IEnumerable<ToolCommunityMember> GetAllTools()
        {
            return context.ToolCommunityMembers.ToList();
        }

        public ToolCommunityMember GetById(int Id)
        {
            return context.ToolCommunityMembers.Find(Id);
        }

        public ToolCommunityMember Update(ToolCommunityMember toolToChange)
        {
            var updatedToolApplicationUser = context.ToolCommunityMembers.Attach(toolToChange);

            updatedToolApplicationUser.State = EntityState.Modified;
            context.SaveChanges();

            return toolToChange;
        }
    }
}
