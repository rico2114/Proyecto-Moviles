using System;
namespace JaverianaCali.Models
{
    public class DetailedCourseModel : AbstractModel {

        private int id;
        private String name;
        private String[] classrooms;
        private String[] teachers;
        private DateModel[] dates;
        private GradeModel[] grades;

        public DetailedCourseModel() { }

        public DetailedCourseModel(int id, String name, String[] classrooms, String[] teachers, DateModel[] dates, GradeModel[] grades) 
        {
            this.id = id;
            this.name = name;
            this.classrooms = classrooms;
            this.teachers = teachers;
            this.dates = dates;
            this.grades = grades;
        }

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        public String Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public String[] Classrooms
        {
            get { return classrooms; }
            set { classrooms = value; OnPropertyChanged(); }
        }

        public String[] Teachers
        {
            get { return teachers; }
            set { teachers = value; OnPropertyChanged(); }
        }

        public DateModel[] Dates
        {
            get { return dates; }
            set { dates = value; OnPropertyChanged(); }
        }

        public GradeModel[] Grades
        {
            get { return grades; }
            set { grades = value; OnPropertyChanged(); }
        }

        /**
         * todo: From this line and so forth, that should be processed on the front end (view) shouldn't we?       
         * but to be honnest I don't know how to do that. read about that.
         */
        public String GetDates {
            get
            {
                String ans = "";
                for (int i = 0; i < dates.Length; ++i)
                {
                    ans += teachers[i] + "\nDìa y hora: " + Conversion.convertDayToString(dates[i].Day) + " de " + dates[i].BeginHour + " a " + dates[i].EndHour + "\nSalòn:" + classrooms[i] + "\n";
                }
                return ans;
            }
        }

        public String GetGrades
        {
            get
            {
                String ans = "";
                for (int i = 0; i < dates.Length; ++i)
                {
                    ans += grades[i].Name + "\nNota: " + grades[i].Calification + "\nPorcentaje: " + grades[i].Percentage + "%\n";
                }
                return ans;
            }
        }
    }
}
