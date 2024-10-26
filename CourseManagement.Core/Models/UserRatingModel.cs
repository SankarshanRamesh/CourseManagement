namespace CourseManagement.Core.Models
{
    public class UserRatingModel
    {
        public int CourseId { get; set; }

        public decimal AverageRating { get; set; }

        public int TotalRating { get; set; }
    }
}
