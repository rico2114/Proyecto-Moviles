using System;
namespace JaverianaCali.Models
{
    public class GeneralCourseModel : AbstractModel {

        private int id;
        private String name;
        private String[] classrooms;
        private String[] teachers;
        private DateModel[] dates;

        public GeneralCourseModel() { }

        public GeneralCourseModel(int id, String name, String [] classrooms, String [] teachers, DateModel [] dates) {
            this.id = id;
            this.name = name;
            this.classrooms = classrooms;
            this.teachers = teachers;
            this.dates = dates;
        }

        public int Id {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        public String Name {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public String [] Classrooms
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

        /**
         * todo: From this line and so forth, that should be processed on the front end (view) shouldn't we?       
         * but to be honnest I don't know how to do that. read about that.
         */        
        public String GetDetailedInformation
        {
            get
            {
                String ans = "";
                for (int i = 0; i < dates.Length; ++i)
                {
                    ans += teachers[i] + ", " + classrooms[i] + ", " + dates[i].BeginHour + " - " + dates[i].EndHour + ", " + Conversion.convertDayToString(dates[i].Day) + "\n";
                }
                return ans;
            }
        }
    }
}
