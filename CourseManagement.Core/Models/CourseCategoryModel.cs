﻿namespace CourseManagement.Core.Models
{
    public class CourseCategoryModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }
    }
}
