import { Component, OnInit } from '@angular/core';
import { BrowseCourseComponent } from '../browse-course/browse-course.component';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-course-by-category',
  standalone: true,
  imports: [BrowseCourseComponent],
  templateUrl: './course-by-category.component.html',
  styleUrl: './course-by-category.component.css'
})
export class CourseByCategoryComponent implements OnInit{
  categoryId: number = 0;

  constructor(private route: ActivatedRoute, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.categoryId = Number(params.get('categoryId')); // or 'categoryId' depending on your route configuration           
    });
  }
}
