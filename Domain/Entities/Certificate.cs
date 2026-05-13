namespace Domain.Entities
{
    public class Certificate:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public string CertificateUrl { get; set; } = string.Empty;
        public DateTime IssuedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public User Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
