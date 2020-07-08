namespace CommunityToolShedCore.Models
{
    public class CommunityMember
    {
        public int Id { get; set; }
        public ApplicationUser Member { get; set; }
        public Community Community { get; set; }
    }
}
