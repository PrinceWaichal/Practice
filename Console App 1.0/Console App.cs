using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Program
    {
        /*      
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
        */
        public static void Main()
        {
            Primary.Menu.Main();
            Console.Clear();
            Console.WriteLine("\nControl is Back in Main CS Filed");
            Console.ReadLine();

        }
    }
}
