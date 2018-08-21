using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operators
{
    public class Arit_Op
    {
        public static void Add()
        // Function for Addition of Two Integers
        {
            Console.Clear();
            Console.WriteLine("\nFunction for Addition of Two Integers\n");
            long total, n1, n2;
            Console.WriteLine("Enter a Integer : ");
            n1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter another Integer : ");
            n2 = Convert.ToInt64(Console.ReadLine());
            total = n1 + n2;
            Console.WriteLine("Addition of Entered Digits is : {0}", total.ToString());
            Console.ReadLine();
            
        }

        public static void Sub()
        // Function for Substraction of two integers
        {
            Console.Clear();
            Console.WriteLine("\nFunction for Substraction of two integers \n");
            long total, n1, n2;
            Console.WriteLine("Enter a Integer : ");
            n1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter another Integer : ");
            n2 = Convert.ToInt64(Console.ReadLine());
            total = n1 - n2;
            Console.WriteLine("Subtraction of Entered Digits is : {0}", total.ToString());
            Console.ReadLine();
        }

        public static void Multiply()
        // Function for Multiplication of Two numbers with two decimal places
        {
            Console.Clear();
            Console.WriteLine("\nFunction for Multiplication of Two numbers with two decimal places:\n");
            double total, n1, n2;
            Console.WriteLine("Enter a Number With Two Decimals : ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter another Number with Two Decimals : ");
            n2 = Convert.ToDouble(Console.ReadLine());
            total = n1 * n2;
            Console.WriteLine("Multiplication of Entered Numbers is : {0}", total.ToString());
            Console.ReadLine();
        }

        public static void Division()
        // Function for division of Two numbers with two decimal places
        {
            Console.Clear();
            Console.WriteLine("\nFunction for division of Two numbers with two decimal places\n");
            double total, n1, n2;
            Console.WriteLine("Enter a Number With Two Decimals : ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter another Number with Two Decimals : ");
            n2 = Convert.ToDouble(Console.ReadLine());
            total = n1 / n2;
            Console.WriteLine("Division of Entered Numbers is : {0}", total.ToString());
            Console.ReadLine();
        }

        public static void Modulus()
        //Function to get the remainder of the division
        {
            Console.Clear();
            Console.WriteLine("\nFunction to get ramainder of the division\n");
            int total, n1, n2;
            Console.WriteLine("\nEnter Number One ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Number Two ");
            n2 = Convert.ToInt32(Console.ReadLine());
            total = n1 % n2;
            Console.WriteLine("Remainder of {0} and {1} is {2}", n1.ToString(), n2.ToString(), total.ToString());
            Console.ReadLine();
        }

        public static void IncDec()
        //Function to (post) increment and decrement accepted number
        {
            Console.Clear();
            Console.WriteLine("\nEnter a number which is to be added by one -> ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter a number which is to be subtracted by one -> ");
            double b = Convert.ToDouble(Console.ReadLine());
            a++;b--;
            Console.WriteLine("\nValue of Entered number one is \t{0}\nValue of Entered number two is \t{1}",a,b);
            Console.ReadLine();
        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\tPractical Number ");
            Console.WriteLine("\n\n\t Arithmatic Operators");
            Console.WriteLine("\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            Console.WriteLine("5. Modulus or Remainder\n6. Increment & Decrement");
            string userinput = Console.ReadLine();
            int a;
            Int32.TryParse(userinput, out a);

            if(a>0 && a<=7)
            {
                switch (a)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Sub();
                        break;

                    case 3:
                        Multiply();
                        break;

                    case 4:
                        Division();
                        break;

                    case 5:
                        Modulus();
                        break;

                    case 6:
                        IncDec();
                        break;
                }



                Console.WriteLine("\nDo you want to exit the program?");
                    Console.WriteLine("\n\tYes\n\tNo");
                    string A = Console.ReadLine();
                    if(A=="y" || A=="ye" || A=="yea" || A=="yes" || A == "Y" || A == "YE" || A == "YEA" || A == "YES"
                        || A == "Yes" || A == "yEs" || A == "yeS" || A == "yES")
                    {
                    Environment.Exit(0);
                    }
            }
        }
    }
}
