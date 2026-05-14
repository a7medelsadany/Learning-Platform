using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IEnrollmentRepository:IBaseRepository<Enrollment>
    {
        Task<Enrollment?> GetByStudentAndCourseAsync(Guid studentId,Guid courseId);
        Task<IEnumerable<Enrollment>> GetByStudentAsync(Guid studentId);
        Task<bool> IsEnrolledAsync(Guid studentId, Guid courseId);
    }
}
