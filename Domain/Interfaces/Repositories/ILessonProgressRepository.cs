using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ILessonProgressRepository:IBaseRepository<LessonProgress>
    {
        Task<LessonProgress?> GetByEnrollmentAndLessonAsync(Guid enrollmentId, Guid lessonId);
        Task<int> GetCompletedLessonsCountAsync(Guid enrollmentId);
    }
}
