using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleCalendar

{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@".\WriteText.txt", "");
            Menu.FirstMenu();
        }

    }
}