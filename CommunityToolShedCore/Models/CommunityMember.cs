using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace CommunityToolShedCore.Models
{
    public class CommunityMember
    {
        public CommunityMember() { }
        public CommunityMember(string userId, int communityId)
        {
            ApplicationUserId = userId;
            CommunityId = communityId;
        }
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int CommunityId { get; set; }
        public Community Community { get; set; }
    }
}