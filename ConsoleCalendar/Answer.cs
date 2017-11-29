using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalendar
{
    class Answer
    {
        public static int IntParser(string askDate, int maxValue)
        {
            Console.Write(askDate);
            string answer = Console.ReadLine();
            int noteAnswer;
            if (Int32.TryParse(answer, out noteAnswer))
            {
                noteAnswer = Convert.ToInt32(answer);

                if (noteAnswer > 0 && noteAnswer <= maxValue)
                {

                    return noteAnswer;
                }
                else
                {
                    Console.WriteLine("Zła odpowiedź wybierz od 1 do " + maxValue);
                    return IntParser(askDate, maxValue);
                }
            }
            else
            {
                Console.WriteLine("Zła odpowiedź wybierz od 1 do " + maxValue);
                return IntParser(askDate, maxValue);
            }
        }
    }
}
