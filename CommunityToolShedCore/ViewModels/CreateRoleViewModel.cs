using System.ComponentModel.DataAnnotations;

namespace CommunityToolShedCore.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
