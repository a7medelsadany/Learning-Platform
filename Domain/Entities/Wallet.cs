namespace Domain.Entities
{
    public class Wallet:BaseEntity
    {
        public Guid UserId { get; set; }
        public decimal Balance { get; set; } = 0;

        // Navigation property
        public User User { get; set; }  =null!;
        public ICollection<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}
