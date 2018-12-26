using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main_Console_Application
{
    class Main_Program
    {
        public static void Exit()
        // Function to Ask to Exit the Console
        {
            Console.Clear();
            Console.WriteLine("\nYou are about the exit the program, do you wish to continue?\n\tYes\n\tNo");
            string str1 = Console.ReadLine();
            if (str1 == "" || str1 == "yes" || str1 == "Yes" || str1 == "YES")
            {
                Environment.Exit(0);
            }
            else
            {
                Main();
            }
        }

        static void Main()  
        {
            Console.Clear();
            Console.WriteLine("\n\t\tApplication Development Tools");
            Console.WriteLine("\n\t<--------------------------------------------->");
            //Creating a list to Select from
            Console.WriteLine("\n  Select Any of the Following Function :");
            Console.WriteLine("\n_________________________________________");
            Console.WriteLine("\n1. Operators\n2. Constructor Examples\n3. Miscellaneous Projects\n4. Exception Handling");
            Console.WriteLine("5. String Functions");
            Console.WriteLine("\nPress Any Other Key to Exit the Console Application.");

            //Accepting a normal string
            string userinput = Console.ReadLine();
            int convertedint = 0;
            try
            {
                // Following converts string into an integer
                Int32.TryParse(userinput, out convertedint);
            }
            catch
            {
                Console.WriteLine("\nWrong Input\nTry Again");
                Console.ReadLine();
                Main();
            }

            //Following code is used to create menu-driven program
            switch (convertedint)
            {
                case 1:
                    Project_Library.Ops.Main();
                    break; // States that the first case is finished. If removed, gives compile-time error

                case 2:
                    Project_Library.Construct.Main();
                    break;

                case 3:
                    Project_Library.Misc_Proj.Main();
                    break;

                case 4:
                    Project_Library.Except.Main(); ;
                    break;

                case 5:
                    Project_Library.StringFuctions.Main();
                    break;

                default:
                    Exit();
                    break;
            }
            Main();
        }
    }
}
