using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IReviewRepository:IBaseRepository<Review>
    {
        Task<Review?> GetByStudentAndCourseAsync(Guid studentId, Guid courseId);
        Task<IEnumerable<Review>> GetByCourseIdAsync(Guid courseId);
        Task<double> GetAverageRatingAsync(Guid courseId);
    }
}
