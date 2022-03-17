namespace CustomLMSAPI.Models
{
    public class Group
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<GroupBadgeSet> GroupBadgeSets { get; set; }
    }
}
