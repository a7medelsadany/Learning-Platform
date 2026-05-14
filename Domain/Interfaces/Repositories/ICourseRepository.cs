using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ICourseRepository:IBaseRepository<Course>
    {
        Task<IEnumerable<Course>> GetPublishedCoursesAsync();
        Task<IEnumerable<Course>> GetCoursesByTeacherAsync(Guid teacherId);
        Task<Course?> GetCourseWithDetailsAsync(Guid courseId);
    }
}
