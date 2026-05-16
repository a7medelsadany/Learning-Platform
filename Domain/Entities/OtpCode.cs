using Domain.Enums;

namespace Domain.Entities
{
    public class OtpCode:BaseEntity
    {
        public Guid UserId { get; set; }
        public string Code { get; set; }=string.Empty;
        public OtpType Type { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; } = false;

        // Navigation property
        public User User { get; set; } = null!;
    }
}
