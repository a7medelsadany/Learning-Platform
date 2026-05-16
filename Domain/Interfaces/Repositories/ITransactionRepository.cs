using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ITransactionRepository:IBaseRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetByWalletIdAsync(Guid walletId);
    }
}
