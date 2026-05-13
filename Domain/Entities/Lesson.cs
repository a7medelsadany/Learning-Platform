namespace Domain.Entities
{
    public class Lesson: BaseEntity
    {
        public Guid SectionId { get; set; }
        public string Title { get; set; } = null!;
        public string VideoUrl { get; set; }= null!;
        public int Duration { get; set; }
        public int Order { get; set; }
        public bool IsFreePreview { get; set; } = false;

        // Navigation property
        public Section Section { get; set; }= null!;
        public ICollection<LessonProgress> lessonProgresses { get; set; } = new List<LessonProgress>();
    }
}
