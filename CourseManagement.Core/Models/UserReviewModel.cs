﻿namespace CourseManagement.Core.Models
{
    public class UserReviewModel
    {
        public int ReviewId { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;

        public int Rating { get; set; }

        public string? Comments { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}
