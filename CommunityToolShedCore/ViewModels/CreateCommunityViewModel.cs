using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.ViewModels
{
    public class CreateCommunityViewModel
    {
        public string Name { get; set; }
        [Display(Name = "Open")]
        public bool IsOpen { get; set; }
        public IFormFile Photo { get; set; }
    }
}
