namespace CustomLMSAPI.Models
{
    public class EnrollmentBadge
    {
        public int ID { get; set; }
        public int EnrollmentID { get; set; }
        public int BadgeID { get; set; }
        public virtual Enrollment Enrollment { get; set; }
        public virtual Badge Badge { get; set; }
    }
}
