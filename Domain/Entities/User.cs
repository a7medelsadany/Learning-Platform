using Domain.Enums;

namespace Domain.Entities
{
    public class User:BaseEntity
    {
        public string FullName { get; set; }= string.Empty;
        public string Email { get; set; }=string.Empty;
        public string PasswordHash { get; set; }=string.Empty;
        public UserRole Role  { get; set; }
        public string? Bio { get; set; }
        public string? ProfilePicture { get; set; }

        //=------------------------------------------
        // Navigation properties
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
    }
}
