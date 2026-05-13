namespace Domain.Entities
{
    public class Review:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }

        // Navigation Properties
        public User Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
