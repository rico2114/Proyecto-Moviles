using System;
using System.Collections.ObjectModel;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public class CourseService : CourseServiceInterface {

        public CourseService() {
        }

        public DetailedCourseModel findCourseDetail(UserModel user, GeneralCourseModel course)
        {
            // Here lookup for the user id and a desired course id (I assume thats the way the restful server handles this query
            GradeModel grade1 = new GradeModel("Examen 1", 5.0, 25);
            GradeModel grade2 = new GradeModel("Examen 2", 5.0, 25);
            GradeModel grade3 = new GradeModel("Examen 3", 5.0, 25);
            GradeModel grade4 = new GradeModel("Examen 4", 5.0, 25);

            GradeModel[] grades = new GradeModel[] { grade1 , grade2, grade3, grade4 };
            return new DetailedCourseModel(course.Id, course.Name, course.Classrooms, course.Teachers, course.Dates, grades);
        }

        public ObservableCollection<GeneralCourseModel> findCoursesByStudent(UserModel user) {
            ObservableCollection<GeneralCourseModel> courses = new ObservableCollection<GeneralCourseModel>();
            DateModel date1 = new DateModel("2:00pm", "4:00pm", DaysOfTheWeek.MONDAY);
            DateModel date2 = new DateModel("2:00pm", "4:00pm", DaysOfTheWeek.THURSDAY);

            courses.Add(new GeneralCourseModel(85000, "Calculo Multivariable", new String[] { "Lago 2.1", "Palmas 3.4" }, new String[] { "Carlos Garzon", "Carlos Garzon" }, new DateModel[] { date1, date2 }));

            DateModel date3 = new DateModel("4:00pm", "6:00pm", DaysOfTheWeek.TUESDAY);
            DateModel date4 = new DateModel("4:00pm", "6:00pm", DaysOfTheWeek.FRIDAY);
            courses.Add(new GeneralCourseModel(85000, "Fundamentos de investigacion", new String[] { "Educon 2.0", "Guayacanes 1.5" }, new String[] { "Diego Linares", "Diego Linares" }, new DateModel[] { date3, date4 }));
            return courses;
        }


    }
}
