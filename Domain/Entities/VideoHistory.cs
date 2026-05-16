namespace Domain.Entities
{
    public class VideoHistory:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid LessonId { get; set; }
        public DateTime WatchedAt { get; set; } = DateTime.UtcNow;
        public int WatchDuration { get; set; }

        // Navigation Properties
        public User Student { get; set; } = null!;
        public Lesson Lesson { get; set; } = null!;
    }
}
