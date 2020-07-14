using CommunityToolShedCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.ViewModels
{
    public class ToolsViewModel
    {
        public Tool Tool { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
