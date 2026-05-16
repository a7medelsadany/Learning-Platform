using Domain.Enums;

namespace Domain.Entities
{
    public class Transaction:BaseEntity
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type  { get; set; }
        public string Description { get; set; }=string.Empty;

        // Navigation property
        public Wallet Wallet { get; set; }=null!;
    }
}
