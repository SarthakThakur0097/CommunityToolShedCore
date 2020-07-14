using System.Collections.Generic;

namespace CommunityToolShedCore.Models.Interfaces
{
    interface IToolApplicationUserRepository
    {
        ToolApplicationUser GetById(int Id);
        IEnumerable<ToolApplicationUser> GetAllTools();
        ToolApplicationUser Add(ToolApplicationUser tool);
        ToolApplicationUser Update(ToolApplicationUser toolToChange);
        ToolApplicationUser Delete(string Id);
    }
}
