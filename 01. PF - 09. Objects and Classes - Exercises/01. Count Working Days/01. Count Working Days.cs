using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static DateTime[] OfficialHolidays()
        {
            string[] holidaysAsText = new string[] {
                "01.01",
                "03.03",
                "01.05",
                "06.05",
                "24.05",
                "06.09",
                "22.09",
                "01.11",
                "24.12",
                "25.12",
                "26.12",
            };
            DateTime[] officialHolidays = new DateTime[holidaysAsText.Length];
            for (int i = 0; i < holidaysAsText.Length; i++)
            {
                officialHolidays[i] = DateTime.ParseExact(holidaysAsText[i], "dd.MM", CultureInfo.InvariantCulture);
            }
            return officialHolidays;
            //DateTime[] officialHolidays = new DateTime[]
            //{ DateTime.ParseExact("01.01", "dd-MM", CultureInfo.InvariantCulture),
            //"03.03", "dd-MM", CultureInfo.InvariantCulture),
            //"01.05", "dd-MM", CultureInfo.InvariantCulture),
            //"06.05", "dd-MM", CultureInfo.InvariantCulture),
            //"24.05", "dd-MM", CultureInfo.InvariantCulture),
            //"06.09", "dd-MM", CultureInfo.InvariantCulture),
            //"22.09", "dd-MM", CultureInfo.InvariantCulture),
            //"01.11", "dd-MM", CultureInfo.InvariantCulture),
            //"24.12", "dd-MM", CultureInfo.InvariantCulture),
            //"25.12", "dd-MM", CultureInfo.InvariantCulture),
            //"26.12", "dd-MM", CultureInfo.InvariantCulture)};
            //return officialHolidays;
        }

        static void Main(string[] args)
        {
            string startDateAsText = Console.ReadLine();
            string endDateAsText = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(startDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] officialHolidays = OfficialHolidays();
            int workingDaysCounter = 0;
            for (DateTime currentDay = startDate; currentDay <= endDate; currentDay= currentDay.AddDays(1))
            {
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isWorkingDay = true;
                    for (int i = 0; i < officialHolidays.Length; i++)
                    {
                        if (officialHolidays[i].Day==currentDay.Day&&officialHolidays[i].Month==currentDay.Month)
                        {
                            isWorkingDay = false;
                            break;
                        }
                        
                    }
                    if (isWorkingDay)
                    {
                        workingDaysCounter++;
                    }
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
