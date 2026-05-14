using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Domain.Entities;

namespace Infrastructure.Persistence.Data
{
    public class LearningDbContext(DbContextOptions<LearningDbContext> options):DbContext(options)
    {
        #region DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonProgress> LessonProgresses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        #endregion

        //for Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
