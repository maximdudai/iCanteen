using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.helpers
{
    internal class Week
    {
        CultureInfo cultureInfo;
        Calendar calendar;
        CalendarWeekRule weekRule;
        DayOfWeek firstDayOfWeek;

        public Week()
        {
            cultureInfo = new CultureInfo("pt-PT");
            calendar = cultureInfo.Calendar;
            weekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
        }

        public int GetCurrentYearWeek()
        {
            int currentWeekNumber = calendar.GetWeekOfYear(DateTime.Now, this.weekRule, this.firstDayOfWeek);

            return currentWeekNumber;
        }
        public int GetMaxWeeksOfYear()
        {
            int maxWeeks = calendar.GetWeekOfYear(new DateTime(DateTime.Now.Year, 12, 31), this.weekRule, this.firstDayOfWeek);

            return maxWeeks;
        }

        public int GetMinWeeksOfYear()
        {
            int minWeeks = calendar.GetWeekOfYear(new DateTime(DateTime.Now.Year, 1, 1), this.weekRule, this.firstDayOfWeek);

            return minWeeks;
        }

        public int GetWeekFromDay(DateTime date)
        {
            int weekNumber = calendar.GetWeekOfYear(date, this.weekRule, this.firstDayOfWeek);

            return weekNumber;
        }
    }
}
