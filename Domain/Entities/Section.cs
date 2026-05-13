namespace Domain.Entities
{
    public class Section:BaseEntity 
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; }=string.Empty;
        public int Order { get; set; }

        //---------------------------------------------------------
        // Navigation property
        public Course Course { get; set; }=null!;
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
