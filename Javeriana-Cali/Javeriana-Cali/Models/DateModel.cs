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
            if (day.Equals(DaysOfTheWeek.MONDAY)) {
                return "Lunes";
            } else if (day.Equals(DaysOfTheWeek.TUESDAY)) {
                return "Martes";
            } else if (day.Equals(DaysOfTheWeek.WEDNESDAY)) {
                return "Miercoles";
            } else if (day.Equals(DaysOfTheWeek.THURSDAY)) {
                return "Jueves";
            } else if (day.Equals(DaysOfTheWeek.FRIDAY)) {
                return "Viernes";
            } else if (day.Equals(DaysOfTheWeek.SATURDAY)) {
                return "Sabado";
            }
            return "Domingo";
        }
    }


}
