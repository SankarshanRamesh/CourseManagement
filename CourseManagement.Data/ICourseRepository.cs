using CourseManagement.Core.Entities;
using CourseManagement.Core.Models;

namespace CourseManagement.Data
{
    public interface ICourseRepository
    {
        Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null);
        Task<CourseDetailModel?> GetCourseDetailAsync(int courseId);
        Task AddCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(int courseId);
        Task<Course?> GetCourseByIdAsync(int courseId);
        void RemoveSessionDetail(SessionDetail sessionDetail);
        Task<List<Instructor>> GetAllInstructorsAsync();

        Task<bool> UpdateCourseThumbnail(string courseThumbnailUrl, int courseId);
    }
}
