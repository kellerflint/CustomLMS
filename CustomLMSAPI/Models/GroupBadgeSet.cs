namespace CustomLMSAPI.Models
{
    public class GroupBadgeSet
    {
        public int ID { get; set; }
        public int BadgeSetID { get; set; }
        public int GroupID { get; set; }
        public virtual BadgeSet BadgeSet { get; set; }
        public virtual Group Group { get; set; }
    }
}
