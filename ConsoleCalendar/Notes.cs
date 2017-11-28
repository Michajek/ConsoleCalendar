using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleCalendar
{
    class Notes
    {
        public static void AddNotes()
        {
            Console.Clear();
            Console.Write("Podaj rok:");
            int choosenNoteYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj miesiąc:");
            int choosenNoteMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj dzień:");
            int choosenNoteDay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dodaj notatkę:");
            string choosenNote = Console.ReadLine();
            DateTime dateNote = new DateTime(choosenNoteYear, choosenNoteMonth, choosenNoteDay);

            string fullNote = dateNote.ToShortDateString() + " " + choosenNote;
            using (StreamWriter file = new StreamWriter(@".\Writetext.txt", true))
            {
                file.WriteLine(fullNote);
            }
            Console.Clear();
            Console.WriteLine("Dodałes notke o treści:\n " + fullNote);
            Console.ReadLine();
            Console.Clear();
            Menu.FirstMenu();


        }

        public static void DisplayNotes()
        {
            Console.Clear();
            string[] lines = File.ReadAllLines(@".\WriteText.txt");

            Console.WriteLine("Twoje notatki: ");
            int counter = 0;
            foreach (string line in lines)
            {
                counter++;
                Console.WriteLine("\t" + counter + ".  " + line);
            }

            
            Console.ReadLine();
            Console.Clear();
            Menu.FirstMenu();

        }
    }
}