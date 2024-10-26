import { Component, Input, SimpleChanges } from '@angular/core';
import { Course } from '../../../models/course';
import { MOCK_COURSES } from '../../mock-data/mock-course';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-browse-course',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './browse-course.component.html',
  styleUrl: './browse-course.component.css',
})
export class BrowseCourseComponent {
  courses: Course[] = [];

  @Input() categoryId: number = 0;
  @Input() browseAllCourse: boolean = false;

  constructor() {
    this.courses = MOCK_COURSES;
  }

  ngOnInit(): void {
    this.processCourse();
  }

  ngOnChanges(changes: SimpleChanges): void {
    this.processCourse();
  }

  processCourse() {
    if (this.browseAllCourse) {
      this.getCourses();
    } else {
      this.getCourseByCategory(this.categoryId);
    }
  }

  formatPrice(price: number): string {
    return `$${price.toFixed(2)}`;
  }

  getCourseByCategory(categoryId: number) {
    // this.courseService.getCoursesByCategoryId(categoryId).subscribe((data) => {
    //   this.courses = data;
    // });
    this.courses = MOCK_COURSES.filter((f) => f.categoryId == categoryId);
  }

  getCourses() {
    // this.courseService.getAllCourses().subscribe((data) => {
    //   this.courses = data;
    // });
    this.courses = MOCK_COURSES;
  }
}
