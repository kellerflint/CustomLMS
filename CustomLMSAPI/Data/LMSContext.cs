using CustomLMSAPI.Models;
using System.Data.Entity;

namespace CustomLMSAPI.Data
{
    public class LMSContext : DbContext
    {
        public LMSContext() : base("LMSContext") 
        {
        }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<BadgeSet> BadgeSets { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<EnrollmentBadge> EnrollmentBadges { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupBadgeSet> GroupBadgeSets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
