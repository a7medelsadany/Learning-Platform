namespace Domain.Entities
{
    public class LessonProgress:BaseEntity
    {
        public Guid EnrollmentId { get; set; }
        public Guid LessonId { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime? CompletedAt { get; set; }

        // Navigation Properties
        public Enrollment Enrollment { get; set; } = null!;
        public Lesson Lesson { get; set; } = null!;
    }
}
