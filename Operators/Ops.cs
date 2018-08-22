using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    // A main class, consisting sevral other classes for easy understanding
    public class Ops
    {

        // Following block / class consist only arithmatic operators
        public class Arith_Ops
        {
            // The '+' operator class
            public static void Add()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tAddition Operator");
                Console.WriteLine("\nEnter a number : ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter another number : ");
                double number = Convert.ToDouble(Console.ReadLine());
                double numb = num + number;
                Console.WriteLine("\nAddition of {0} and {1} is {2.00}.", 
                    num.ToString(),number.ToString(),numb.ToString());
                Console.ReadLine();
                Main();
            }

            // The '-' operator class
            public static void Sub()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tSubtraction Operator");
                Console.WriteLine("\nEnter a number : ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter another number : ");
                double number = Convert.ToDouble(Console.ReadLine());
                double numb = num - number;
                Console.WriteLine("\nSubtraction of {1} from {0} is {2.00}.", //be mindful while using {}
                    num.ToString(), number.ToString(), numb.ToString());
                Console.ReadLine();
                Main();
            }

            // The '*' (asterisk) operator class
            public static void Mul()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tMultiplication Operator");
                Console.WriteLine("\nEnter a number : ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter another number : ");
                double number = Convert.ToDouble(Console.ReadLine());
                double numb = num * number;
                Console.WriteLine("\nMultiplication between {0} and {1} is {2.00}.",
                    num.ToString(), number.ToString(), numb.ToString());
                Console.ReadLine();
                Main();
            }

            // The '/' operator class
            public static void Div()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tDivision Operator");
                Console.WriteLine("\nEnter a number : ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter another number : ");
                double number = Convert.ToDouble(Console.ReadLine());
                double numb = num / number;
                Console.WriteLine("\nDivision of {1} by {0} is {2.00}.",
                    num.ToString(), number.ToString(), numb.ToString());
                Console.ReadLine();
                Main();
            }

            // The '%' operator class
            public static void Mod()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tModulus Operator");
                Console.WriteLine("\nEnter a number : ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter another number : ");
                double number = Convert.ToDouble(Console.ReadLine());
                double numb = num % number;
                Console.WriteLine("\nRemainder after division between {0} and {1} is {2.00}.",
                    num.ToString(), number.ToString(), numb.ToString());
                Console.ReadLine();
                Main();
            }

            // Function to Ask to Exit the Console
            public static void Exit()
            {
                Console.WriteLine("\nDo You Really Wish To Exit?\n\nY/N?");
                string a = Console.ReadLine();
                if (a == "Y" | a == "y" | a == "Yes" | a == "yes" | a == "YES" | a == "yEs" | a == "yeS")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Main();
                }
            }

            public static void Main()
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\tPlease select any of the following arithmatic function");
                string userinput = Console.ReadLine();
                int num;
                int.TryParse(userinput, out num);

                switch (num)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Sub();
                        break;

                    case 3:
                        Mul();
                        break;

                    case 4:
                        Div();
                        break;

                    case 5:
                        Mod();
                        break;

                    default:
                        if (num > 0 && num <= 10)
                        {
                            Console.WriteLine("Please select an appropriate option");
                            Console.ReadLine();
                            Main();
                        }
                        else
                            Exit();
                        break;
                }
            }
        }

        public class Assign_Ops
        {
            // Using "+="
            public static void Add()
            {
                /* Expected block of code [to be done]
                 * 
                 * Accept Three [3] numbers from user
                 * One to be kept simple
                 * Second number is to be added to the first
                 * And another for how many times a number is to be added to the first
                 * 
                 * Returning the controller back to Main() as always
                 */
            }

            // Using "-="
            public static void Sub()
            {

            }

            // Using "*="
            public static void Mul()
            {

            }

            // Using "/="
            public static void Div()
            {

            }

            // Standard (Copy-Pasted) Exit class
            public static void Exit()
            {
                Console.WriteLine("\nDo You Really Wish To Exit?\n\nY/N?");
                string a = Console.ReadLine();
                if (a == "Y" | a == "y" | a == "Yes" | a == "yes" | a == "YES" | a == "yEs" | a == "yeS")
                    // Addition in above conditions (possible inputs) welcomed.
                {
                    Environment.Exit(0);
                }
                else
                {
                    Main();
                }
            }

            public static void Main()
            {

            }
        }

        public class Rel_Ops
        {
            public static void Main()
            {

            }
        }

        public class Log_Ops
        {
            public static void Main()
            {

            }
        }

        public class Bit_Ops
        {
            public static void Main()
            {

            }
        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tOperations on Operators\nKindly Select Any of the following:");
            Console.WriteLine("\n1.Arithmetic Operators\n2.Relational Operators\n.3. Logical Operators");
            Console.WriteLine("4. Bitwise Operators\n5. Assignment Operators");
            string userin = Console.ReadLine();
            int UI;
            int.TryParse(userin, out UI);
            switch(UI)
            {
                case 1:
                    Arith_Ops.Main();
                    break;

                case 2:
                    Rel_Ops.Main();
                    break;

                case 3:
                    Log_Ops.Main();
                    break;

                case 4:
                    Bit_Ops.Main();
                    break;

                case 5:
                    Assign_Ops.Main();
                    break;

                default:
                    Console.WriteLine("\t\t\tKindly select an appropriate option");
                    break;
            }
        }

    }
}
