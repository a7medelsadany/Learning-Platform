using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IVideoHistoryRepository:IBaseRepository<VideoHistory>
    {
        Task<IEnumerable<VideoHistory>> GetByStudentIdAsync(Guid studentId);
        Task<VideoHistory?> GetByStudentAndLessonAsync(Guid studentId, Guid lessonId);
    }
}
