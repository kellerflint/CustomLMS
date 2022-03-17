namespace CustomLMSAPI.Models
{
    public class Badge
    {
        public int ID { get; set; }
        public int BadgeSetID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual BadgeSet BadgeSet { get; set; }
        public virtual ICollection<EnrollmentBadge> EnrollmentBadges { get; set; }
    }
}
