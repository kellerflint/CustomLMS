namespace CustomLMSAPI.Models
{
    public class Enrollment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int GroupID { get; set; }
        public virtual User User { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<EnrollmentBadge> EnrollmentBadges { get; set; }
    }
}
