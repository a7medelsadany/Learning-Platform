using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IPaymentRepository:IBaseRepository<Payment>
    {
        Task<Payment?> GetByStripePaymentIdAsync(string stripePaymentId);
        Task<IEnumerable<Payment>> GetByStudentIdAsync(Guid studentId);
    }
}
