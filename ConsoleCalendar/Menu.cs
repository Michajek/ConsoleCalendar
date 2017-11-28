using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalendar
{
    class Menu
    {
        public static void FirstMenu()
        {
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Pokaż aktualną datę:");
            Console.WriteLine("2. Wybierz datę:");
            Console.WriteLine("3. Dodaj notatkę:");
            Console.WriteLine("4. Pokaż notatki:");
            Console.WriteLine("5. Wyjdź");
            string firstChoose = Console.ReadLine();

            if (firstChoose == "1")
            {
                Console.Clear();
                DateTime todayDate = DateTime.Now;
                Console.WriteLine(todayDate.ToShortDateString());
                int actualYear = todayDate.Year;
                int actualMonth = todayDate.Month;
                DrawCalendar.DisplayMonth(actualYear, actualMonth);
            }

            else if (firstChoose == "2")
            {
                Console.Clear();
                Console.Write("Podaj rok:");
                int choosenYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj miesiąc:");
                int choosenMonth = Convert.ToInt32(Console.ReadLine());
                DrawCalendar.DisplayMonth(choosenYear, choosenMonth);

            }
            else if (firstChoose == "3")
            {
                Notes.AddNotes();

            }
            else if (firstChoose == "4")
            {
                Notes.DisplayNotes();
                Console.ReadLine();

            }
            else if (firstChoose == "5")
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Wybierz 1,2,3 lub 4");
                Console.WriteLine();
                FirstMenu();
            }
        }
    }
}
