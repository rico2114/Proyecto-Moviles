using System;
using System.Collections.Generic;
using JaverianaCali.Models;
using JaverianaCali.Services;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class CoursesView : ContentPage
    {

        private UserModel user;
        private GeneralCourseViewModel context;
        private CourseService courseService = new CourseService();

        public CoursesView(UserModel user)
        {
            InitializeComponent();
            this.user = user;
            context = new GeneralCourseViewModel(user);
            BindingContext = context;
            ListViewCourses.ItemSelected += ListViewCourses_ItemSelected;
        }

        private void ListViewCourses_ItemSelected(object sender, SelectedItemChangedEventArgs eventArgument)
        {
            if (eventArgument.SelectedItem != null) {
                GeneralCourseModel model = (GeneralCourseModel) eventArgument.SelectedItem;
                DetailedCourseModel detailedCourse = courseService.findCourseDetail(user, model);
                Navigation.PushAsync(new DetailedCourseView(detailedCourse));
            }
        }
    }
}
