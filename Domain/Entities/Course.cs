namespace Domain.Entities
{
    public class Course:BaseEntity
    {
        public Guid TeacherId { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? ThumbnailUrl { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        //--------------------------------------------------------
        // Navigation properties
        public User Teacher { get; set; } = null!;
        public ICollection<Section> Sections { get; set; } = new List<Section>();
        public ICollection<Enrollment> Enrollments { get; set; }= new List<Enrollment>();
        public ICollection<Payment> Payments { get; set; }= new List<Payment>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
    }
}
