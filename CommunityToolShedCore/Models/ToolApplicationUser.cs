using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Models
{
    public class ToolApplicationUser
    {
        public ToolApplicationUser(){}

        public ToolApplicationUser(int toolId, string userId)
        {
            ToolId = toolId;
            ApplicationUserId = userId;
        }
        public int Id { get; set; }
        public int ToolId { get; set; }
        public Tool Tool { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
