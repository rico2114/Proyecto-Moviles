using System;
using System.Collections.ObjectModel;
using JaverianaCali.Models;
using JaverianaCali.Services;

namespace JaverianaCali.ViewModels
{
    public class GeneralCourseViewModel : GeneralCourseModel {

        private CourseService courseService = new CourseService();

        private ObservableCollection<GeneralCourseModel> courses;

        public GeneralCourseViewModel(UserModel user) {
            courses = courseService.findCoursesByStudent(user);
        }

        public ObservableCollection<GeneralCourseModel> Courses {
            get { return courses; }
        }

    }
}
