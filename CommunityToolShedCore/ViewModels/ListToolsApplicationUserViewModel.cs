using CommunityToolShedCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.ViewModels
{
    public class ListToolsApplicationUserViewModel
    {
        public Tool Tool { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
