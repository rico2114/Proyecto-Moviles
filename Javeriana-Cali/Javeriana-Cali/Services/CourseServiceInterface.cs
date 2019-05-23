using System;
using System.Collections.ObjectModel;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public interface CourseServiceInterface {

        ObservableCollection<GeneralCourseModel> findCoursesByStudent(UserModel user);
        DetailedCourseModel findCourseDetail(UserModel user, GeneralCourseModel course);

    }
}
