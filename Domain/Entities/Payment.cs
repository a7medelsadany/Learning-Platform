using Domain.Enums;

namespace Domain.Entities
{
    public class Payment:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public decimal Amount { get; set; }
        public string StripePaymentId { get; set; } = string.Empty;
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public DateTime? PaidAt { get; set; }

        // Navigation Properties
        public User Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
