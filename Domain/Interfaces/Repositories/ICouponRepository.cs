using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ICouponRepository:IBaseRepository<Coupon>
    {
        Task<Coupon?> GetByCodeAsync(string code);
        Task<bool> IsValidAsync(string code);
    }
}
