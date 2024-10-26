using CourseManagement.Core.Entities;

namespace CourseManagement.Data
{
    public interface ICourseCategoryRepository
    {
        Task<CourseCategory?> GetById(int id);
        Task<List<CourseCategory>> GetCourseCategories();
    }
}
