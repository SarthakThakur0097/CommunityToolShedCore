using CommunityToolShedCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.ViewModels
{
    public class AddMemberViewModel
    {
        public int CommunityId { get; set; }
        public IList<ApplicationUser> AllUsers { get; set; }
    }
}
