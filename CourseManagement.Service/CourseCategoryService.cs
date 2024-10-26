﻿using CourseManagement.Core.Models;
using CourseManagement.Data;

namespace CourseManagement.Service
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository categoryRepository;

        public CourseCategoryService(ICourseCategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<CourseCategoryModel?> GetByIdAsync(int id)
        {
            var category = await categoryRepository.GetById(id);
            if (category != null)
            {
                return new CourseCategoryModel()
                {
                    CategoryName = category.CategoryName,
                    CategoryId = category.CategoryId,
                    Description = category.Description
                };
            }
            return null;
        }

        public async Task<List<CourseCategoryModel>> GetCourseCategories()
        {
            var categories = await categoryRepository.GetCourseCategories();
            return categories.Select(c => new CourseCategoryModel()
            {
                CategoryName = c.CategoryName,
                CategoryId = c.CategoryId,
                Description = c.Description
            }).ToList();
        }
    }
}
