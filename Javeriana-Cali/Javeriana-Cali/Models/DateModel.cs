using System;
namespace JaverianaCali.Models
{
    public class DateModel {

        private String beginHour;
        private String endHour;
        private DaysOfTheWeek day;

        public DateModel(String beginHour, String endHour, DaysOfTheWeek day) {
            this.beginHour = beginHour;
            this.endHour = endHour;
            this.day = day;
        }

        public String BeginHour {
            get { return beginHour;  }
            set { beginHour = value; }
        }

        public String EndHour {
            get { return endHour; }
            set { endHour = value; }
        }

        public DaysOfTheWeek Day {
            get { return day; }
            set { day = value; }
        }
    }

    public enum DaysOfTheWeek {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY
    }

    static class Conversion {
        public static String convertDayToString(DaysOfTheWeek day) {
            if (day.Equals(DayOfWeek.Monday)) {
                return "Lunes";
            } else if (day.Equals(DayOfWeek.Tuesday)) {
                return "Martes";
            } else if (day.Equals(DayOfWeek.Wednesday)) {
                return "Miercoles";
            } else if (day.Equals(DayOfWeek.Thursday)) {
                return "Jueves";
            } else if (day.Equals(DayOfWeek.Friday)) {
                return "Viernes";
            } else if (day.Equals(DayOfWeek.Saturday)) {
                return "Sabado";
            }
            return "Domingo";
        }
    }


}
