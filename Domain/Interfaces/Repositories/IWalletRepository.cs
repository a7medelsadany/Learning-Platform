using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IWalletRepository:IBaseRepository<Wallet>
    {
        Task<Wallet?> GetByUserIdAsync(Guid userId);
        Task<Wallet?> GetWithTransactionsAsync(Guid userId);
    }
}
