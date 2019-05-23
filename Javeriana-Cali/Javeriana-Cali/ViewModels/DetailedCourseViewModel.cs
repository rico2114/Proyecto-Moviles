using System;
using JaverianaCali.Models;

namespace JaverianaCali.ViewModels
{
    public class DetailedCourseViewModel : DetailedCourseModel {

        public DetailedCourseViewModel(DetailedCourseModel course) {
            this.Id = course.Id;
            this.Name = course.Name;
            this.Classrooms = course.Classrooms;
            this.Teachers = course.Teachers;
            this.Dates = course.Dates;
            this.Grades = course.Grades;
        }
    }
}
