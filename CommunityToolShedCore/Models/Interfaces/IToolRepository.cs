using System.Collections.Generic;

namespace CommunityToolShedCore.Models
{
    interface IToolRepository
    {
        Tool GetById(int Id);
        IEnumerable<Tool> GetAllTools();
        Tool Add(Tool tool);
        Tool Update(Tool toolToChange);
        Tool Delete(string Id);
    }
}
