using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.ViewModels
{
    public class CreateCommunityViewModel
    {
        [Display(Name = "Open")]
        public string Name { get; set; }
        public bool IsOpen { get; set; }
    }
}
