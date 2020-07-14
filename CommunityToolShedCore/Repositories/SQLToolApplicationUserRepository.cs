using System.Collections.Generic;
using System.Linq;
using CommunityToolShedCore.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore.Models
{
    public class SQLToolApplicationUserRepository : IToolApplicationUserRepository
    {
        private readonly Context context;

        public SQLToolApplicationUserRepository(Context context)
        {
            this.context = context;
        }

        public ToolApplicationUser Add(ToolApplicationUser tool)
        {
            context.ToolApplicationUsers.Add(tool);
            context.SaveChanges();
            return tool;
        }

        public ToolApplicationUser Delete(string Id)
        {
            ToolApplicationUser toolApplicationUsers = context.ToolApplicationUsers.Find(Id);

            if (toolApplicationUsers != null)
            {
                context.ToolApplicationUsers.Remove(toolApplicationUsers);
                context.SaveChanges();
            }
            return toolApplicationUsers;
        }

        public IEnumerable<ToolApplicationUser> GetAllTools()
        {
            return context.ToolApplicationUsers.ToList();
        }

        public ToolApplicationUser GetById(int Id)
        {
            return context.ToolApplicationUsers.Find(Id);
        }

        public ToolApplicationUser Update(ToolApplicationUser toolToChange)
        {
            var updatedToolApplicationUser = context.ToolApplicationUsers.Attach(toolToChange);

            updatedToolApplicationUser.State = EntityState.Modified;
            context.SaveChanges();

            return toolToChange;
        }
    }
}
