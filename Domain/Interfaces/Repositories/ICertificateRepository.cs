using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public  interface ICertificateRepository:IBaseRepository<Certificate>
    {
        Task<Certificate?> GetByStudentAndCourseAsync(Guid studentId, Guid courseId);
        Task<IEnumerable<Certificate>> GetByStudentIdAsync(Guid studentId);
    }
}
