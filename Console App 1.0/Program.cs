using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators;

namespace Console_App_1._0
{
    class Program
    {
         public static void Exit()
        // Function to Ask to Exit the Console
        {
            Console.WriteLine("\nDo You Really Wish To Exit?\n\nY/N?");
            string a = Console.ReadLine();
            if (a == "Y" | a == "y"|a=="Yes"|a=="yes"|a=="YES"|a=="yEs"|a=="yeS")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Main();
            }

        }
      
        public static void Student()
            // Student Percentage Calculation
        {
            Console.Clear();
            Console.WriteLine("\nEnter the following details :\n");
            Console.WriteLine("\nEnter Marks for 1st Subject : \t");
            double s1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 2nd Subject : \t");
            double s2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 3rd Subject : \t");
            double s3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 4th Subject : \t");
            double s4 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 5th Subject : \t");
            double s5 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 6th Subject : \t");
            double s6 = Convert.ToInt64(Console.ReadLine());
            double total = s1 + s2 + s3 + s4 + s5 + s6;
            double per = total / 6;
            Console.WriteLine("\nTotal Marks Secured : \t{0} and percntage are \t{1} %",total.ToString(),per.ToString());
            Console.ReadLine();
        }

        public static void Area()
        //Calculating Area of Circle
        {
            Console.Clear();
            const double pi = 3.14;
            Console.WriteLine("\nEnter the Radius of the Circle");
            double r = Convert.ToDouble(Console.ReadLine());
            double a = pi * r * r;
            Console.WriteLine("\nThe Radius give is {0} and the area of the circle therefore is\n{1}",r.ToString(),a.ToString());
            Console.ReadLine();
        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\nApplication Development Tools");
            Console.WriteLine("\n<--------Pracitcal 1-------->");
            //Creating a list to Select from
            Console.WriteLine("\n  Select Any of the Following Function :");
            Console.WriteLine("\n_________________________________________");
            Console.WriteLine("\n1. Operators\n2. Add\n3. Add");
            Console.WriteLine("\nPress Any Other Key to Exit the Console Application.");

            //Accepting a normal string
            string userinput = Console.ReadLine();
            int convertedint;
            // Following converts string into an integer
            Int32.TryParse(userinput, out convertedint);

            //Following code is used to create menu-driven program
            switch (convertedint)
            {
                case 1:
                    //Following statement acts as "Console.Function"
                    Operators.Ops.Main();
                    break; // States that the first case is finished. If removed, gives compile-time error

                case 2:
                    ;
                    break;

                case 3:
                    ;
                    break;
                
                default:
                    Console.WriteLine("\n\nDo you wish to \na. Continue the Program\n\nb. Exit the Program");
                    char c = Convert.ToChar(Console.ReadLine());
                    if(c=='a'||c=='A')
                    {
                        // Redirects the control back to the start of the Main() method of the project
                        Main();
                    }
                    else
                    {
                        Exit();
                    }                  
                    break;
            }
        }
    }
}
