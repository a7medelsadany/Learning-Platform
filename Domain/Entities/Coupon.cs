using Domain.Enums;

namespace Domain.Entities
{
    public class Coupon:BaseEntity
    {
        public string Code { get; set; } = string.Empty;
        public DiscountType DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int MaxUses { get; set; }
        public int CurrentUses { get; set; } = 0;
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
