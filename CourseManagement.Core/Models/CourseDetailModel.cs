namespace CourseManagement.Core.Models
{
    public class CourseDetailModel : CourseModel
    {
        public List<UserReviewModel>? Reviews { get; set; } = new List<UserReviewModel>();


        public required List<SessionDetailModel> SessionDetails { get; set; }
    }
}
