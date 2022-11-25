using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class TotalSaturdays_Result
    {
        public int countSaturday(int year, int month)
        {
            int count = 0;
            DateOnly dateOnly = new DateOnly(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int i = 1; i <= daysInMonth; i++)
            {
                DateOnly currentDay = new DateOnly(year, month, i);
                if (currentDay.DayOfWeek.ToString().ToUpper() == "SATURDAY")
                    count++;
            }
            return count;
        }
    }
    public class TotalSaturdays_Solution
    {
        public static void Input()
        {
            TotalSaturdays_Result objResult = new TotalSaturdays_Result();
            int year = 2022;
            int month = 11;
            int result = objResult.countSaturday(year, month);

            Console.WriteLine($"Total number of Saturdays in year:{year}, month:{month} are: {result}");
        }
    }
}
