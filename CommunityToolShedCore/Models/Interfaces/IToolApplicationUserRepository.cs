using System.Collections.Generic;

namespace CommunityToolShedCore.Models.Interfaces
{
    interface IToolApplicationUserRepository
    {
        ToolCommunityMember GetById(int Id);
        IEnumerable<ToolCommunityMember> GetAllTools();
        ToolCommunityMember Add(ToolCommunityMember tool);
        ToolCommunityMember Update(ToolCommunityMember toolToChange);
        ToolCommunityMember Delete(string Id);
    }
}
