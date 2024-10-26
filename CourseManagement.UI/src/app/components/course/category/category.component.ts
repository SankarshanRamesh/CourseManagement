import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CourseCategory } from '../../../models/coursecategory';
import { RouterModule } from '@angular/router';
import { MOCK_COURSE_CATEGORIES } from '../../mock-data/mock-course-categories';

@Component({
  selector: 'app-category',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './category.component.html',
  styleUrl: './category.component.css',
})
export class CategoryComponent {
  @Input() categories: CourseCategory[] = [];
  @Input() viewType: 'tabs' | 'list' = 'list';

  constructor() {
    this.categories = MOCK_COURSE_CATEGORIES;
  }
}
