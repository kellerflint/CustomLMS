namespace CustomLMSAPI.Models
{
    public class BadgeSet
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Badge> Badges { get; set; }
        public virtual ICollection<GroupBadgeSet> GroupBadgeSets { get; set; }
    }
}
