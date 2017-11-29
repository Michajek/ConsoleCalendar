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
            int choosenNoteYear = Answer.IntParser("Podaj rok:", 3000);
            int choosenNoteMonth = Answer.IntParser("Podaj miesiąc:", 12);
            int daysInActualMonth = DateTime.DaysInMonth(choosenNoteYear, choosenNoteMonth);
            int choosenNoteDay = Answer.IntParser("Podaj dzień:", daysInActualMonth);

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
            Console.WriteLine("1. Usuń notatkę");
            Console.WriteLine("Enter by wrócić");
            string chooseDelete = Console.ReadLine();
            if (chooseDelete == "1") 
            {
                Console.WriteLine("Usuń notatkę numer:");
                string lineToDelete = Console.ReadLine();
                int intLineToDelete;
                if (Int32.TryParse(lineToDelete, out intLineToDelete))
                {
                    intLineToDelete = Convert.ToInt32(lineToDelete);
                    DeleteNotes(intLineToDelete);
                }
                else
                {
                    DisplayNotes();
                }
               
            }
            else
            {
                Console.Clear();
                Menu.FirstMenu();
            }
        }
        public static void DeleteNotes(int lineToDelete)
        {
            var file = new List<string>(System.IO.File.ReadAllLines(@".\WriteText.txt"));
            if (file.Count >= lineToDelete)
            {
                file.RemoveAt(lineToDelete - 1);
                File.WriteAllLines(@".\WriteText.txt", file.ToArray());
                DisplayNotes();
            }
            else
            {
                DisplayNotes();
            }

        }

    }
}