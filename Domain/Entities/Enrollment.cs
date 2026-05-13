namespace Domain.Entities
{
    public class Enrollment:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
        public decimal CompletionRate { get; set; } = 0;
        // Navigation properties
        public User Student { get; set; }= null!;
        public Course Course { get; set; }= null!;
        public ICollection<LessonProgress> lessonProgresses { get; set; }=new List<LessonProgress>();
    }
}
