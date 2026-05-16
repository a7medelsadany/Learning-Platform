using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ILessonProgressRepository:IBaseRepository<LessonProgress>
    {
        Task<LessonProgress?> GetByEnrollmentAndLessonAsync(Guid enrollmentId, Guid lessonId);
        Task<int> GetCompletedLessonsCountAsync(Guid enrollmentId);
        Task<int> GetTotalLessonsCountAsync(Guid enrollmentId);
    }
}
