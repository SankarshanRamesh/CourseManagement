using CourseManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseManagement.Data
{
    public class CourseCategoryRepository(OnlineCourseDbContext dbContext) : ICourseCategoryRepository
    {
        private readonly OnlineCourseDbContext dbContext = dbContext;

        public Task<CourseCategory?> GetById(int id)
        {
            return dbContext.CourseCategories.FindAsync(id).AsTask();
        }

        public Task<List<CourseCategory>> GetCourseCategories()
        {
            return dbContext.CourseCategories.ToListAsync();
        }
    }
}
