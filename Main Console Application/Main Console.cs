using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Console_Application
{
    class Main_Program
    {
        static void Main()  
        {
            Project_Library.Projects.Menu.Main();
            Console.WriteLine("\nControl has been returned to the Console Application.");
            Console.WriteLine("\nAfter the press of Any Key This program will now terminate");
            Console.ReadLine();
        }
    }
}
