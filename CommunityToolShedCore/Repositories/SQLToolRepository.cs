using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CommunityToolShedCore.Models
{
    public class SQLToolRepository : IToolRepository
    {
        private readonly Context context;

        public SQLToolRepository(Context context)
        {
            this.context = context;
        }
        public Tool GetById(int Id)
        {
            return context.Tools.Find(Id);
        }

        public Tool Add(Tool tool)
        {
            context.Tools.Add(tool);
            context.SaveChanges();
            return tool;
        }

        public Tool Delete(string Id)
        {
            Tool tool = context.Tools.Find(Id);

            if (tool != null)
            {
                context.Tools.Remove(tool);
                context.SaveChanges();
            }
            return tool;
        }

        public IEnumerable<Tool> GetAllTools()
        {
            return context.Tools.ToList();
        }

        public Tool Update(Tool toolToChange)
        {
            var updatedTool = context.Tools.Attach(toolToChange);

            updatedTool.State = EntityState.Modified;
            context.SaveChanges();

            return toolToChange;
        }
    }
}
