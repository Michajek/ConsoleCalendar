using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalendar
{
    class DrawCalendar
    {
        public static void DisplayMonth(int year, int month)
        {
            {
                int dayInActualMonth = DateTime.DaysInMonth(year, month);
                int firstDayOfMonth = 1;
                DateTime usingDate = new DateTime(year, month, firstDayOfMonth);
                int startDay = Convert.ToInt32(usingDate.DayOfWeek);
                int numberOfTabs = startDay;
                Console.WriteLine("Nd\tPn\tWt\tŚr\tCzw\tPt\tSb\n");

                int DayOfWeek = startDay;
                for (int Gaps = 1; Gaps <= dayInActualMonth; Gaps++)
                {
                    string dayString = "";

                    if (Gaps == 1)
                    {
                        String Padding = new String('\t', numberOfTabs);
                        dayString = String.Concat(Padding, Gaps.ToString());
                    }
                    else
                    {
                        dayString = Gaps.ToString();
                    }


                    if (DayOfWeek % 7 == 0 && Gaps > 1)
                    {
                        dayString = String.Concat("\n", Gaps.ToString());
                    }

                    Console.Write(dayString + "\t");

                    DayOfWeek++;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Enter aby wrócić");
                Console.ReadLine();
                Console.Clear();
                Menu.FirstMenu();
            }
        }
    }
}
