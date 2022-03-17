namespace CustomLMSAPI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
