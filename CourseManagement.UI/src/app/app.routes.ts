import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { PlansAndPricingComponent } from './components/plans-and-pricing/plans-and-pricing.component';
import { AboutUsComponent } from './components/core/about-us/about-us.component';
import { CategoryComponent } from './components/course/category/category.component';
import { CourseByCategoryComponent } from './components/course/course-by-category/course-by-category.component';
import { BrowseCourseComponent } from './components/course/browse-course/browse-course.component';
import { ContactUsComponent } from './components/core/contact-us/contact-us.component';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'course/category', component: CategoryComponent },
  { path: 'about-us', component: AboutUsComponent },
  { path: 'contact-us', component: ContactUsComponent },
  { path: 'plans-and-price', component: PlansAndPricingComponent },
  { path: 'course/browse', component: BrowseCourseComponent },
  { path: 'course/category/:categoryId', component: CourseByCategoryComponent },
  // {
  //   path: 'course/session-details/:courseId',
  //   component: CourseDetailsComponent,
  // },
  { path: '**', redirectTo: 'home' },
];
