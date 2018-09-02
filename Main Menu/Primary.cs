using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary
{
    public class Menu
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

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tApplication Development Tools");
            Console.WriteLine("\n\t<--------------------------------------------->");
            //Creating a list to Select from
            Console.WriteLine("\n  Select Any of the Following Function :");
            Console.WriteLine("\n_________________________________________");
            Console.WriteLine("\n1. Operators\n2. Branching & Looping Statements\n3. Add");
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
                    Ops.Main();
                    break; // States that the first case is finished. If removed, gives compile-time error

                case 2:
                    BrooP.Main();
                    break;

                case 3:
                    ;
                    break;

                default:
                    Console.WriteLine("\n\nDo you wish to \na. Continue the Program\n\nb. Exit the Program");
                    string c = Console.ReadLine();
                    if (c == "a" || c == "A")
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
                Console.WriteLine("\nAddition of {0} and {1} is {2}.",
                    num.ToString(), number.ToString(), numb.ToString());
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
                Console.WriteLine("\nSubtraction of {1} from {0} is {2}.", //be mindful while using {}
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
                Console.WriteLine("\nMultiplication between {0} and {1} is {2}.",
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
                Console.WriteLine("\nDivision of {1} by {0} is {2}",
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
                Console.WriteLine("\nRemainder after division between {0} and {1} is {2}.",
                    num.ToString(), number.ToString(), numb.ToString());
                Console.ReadLine();
                Main();
            }

            // The '++' operator
            public static void Inc()
            {
                Console.Clear();
                Console.WriteLine("\t\t\tIncrement Operation");
                Console.WriteLine("\nKindly enter any number");
                double num = Convert.ToDouble(Console.ReadLine());
                double num1 = num;
                num++;
                Console.WriteLine("Entered Number is {0} and after increment, it becomes {1}", num1.ToString(), num.ToString());
                Console.ReadLine();
                Main();
            }

            // The '--' operator
            public static void Dec()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                double num, num1;
                num = Convert.ToDouble(Console.ReadLine());
                num1 = num;
                num++;
                Console.WriteLine("\nEntered Number is {0} and after decrement, it is {1}", num1.ToString(), num.ToString());
                Console.ReadLine();
                Main();
            }

            // Function to Ask to Exit the Console
            public static void Exit()
            {
                Console.WriteLine("\nDo You Really Wish to Exit Arithmetic Operators?\n\nY/N?");
                string a = Console.ReadLine();
                if (a == "Y" | a == "y" | a == "Yes" | a == "yes" | a == "YES" | a == "yEs" | a == "yeS" | a == "")
                {
                    Ops.Main();
                }
                else
                {
                    Main();
                }
            }

            public static void Main()
            {
                Console.Clear();
                Console.WriteLine("\n\tPlease select any of the following arithmatic function");
                Console.WriteLine("\n1. Addition Function\n2. Subtraction Function\n3. Multiplication Function");
                Console.WriteLine("4. Division Function\n5. Remiander Function\n6. Increment Function\n7. Decrement Function");
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
                Console.Clear();
                Console.WriteLine("\n\t\tAddition Assignment Operator");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be incremented");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be added to the first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                double num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                double.TryParse(usernum1, out num1);
                double.TryParse(usernum2, out num2);
                double.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= 3; num5++)
                {
                    num1 += num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto increase the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Using "-="
            public static void Sub()
            {
                Console.Clear();
                Console.WriteLine("\n\t\tSubtraction Assignment Operator");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be subtracted");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be subtracted from the first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                double num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                double.TryParse(usernum1, out num1);
                double.TryParse(usernum2, out num2);
                double.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= 3; num5++)
                {
                    num1 -= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto subtract the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Using "*="
            public static void Mul()
            {
                Console.Clear();
                Console.WriteLine("\n\t\tMultiplication Assignment Operator");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be multiplied");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be multiplied with the first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                double num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                double.TryParse(usernum1, out num1);
                double.TryParse(usernum2, out num2);
                double.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= 3; num5++)
                {
                    num1 *= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto multiply the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Using "/="
            public static void Div()
            {
                Console.Clear();
                Console.WriteLine("\n\t\tDivision Assignment Operator");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be divided");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be divided to the first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                double num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                double.TryParse(usernum1, out num1);
                double.TryParse(usernum2, out num2);
                double.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= 3; num5++)
                {
                    num1 /= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto divide the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Standard (Copy-Pasted) Exit class
            public static void Exit()
            {
                Console.WriteLine("\nDo You Really Wish To Exit Assignment Operations?\n\nY/N?");
                string a = Console.ReadLine();
                if (a == "Y" | a == "y" | a == "Yes" | a == "yes" | a == "YES" | a == "yEs" | a == "yeS")
                // Addition in above conditions (possible inputs) welcomed.
                {
                    Ops.Main();
                }
                else
                {
                    Main();
                }
            }

            public static void Main()
            {
                Console.Clear();
                Console.WriteLine("\n\tPlease Select any of the following assignment operation");
                Console.WriteLine("\n1. Addition '+' Assignmen\n2. Subtraction '-' Assignment");
                Console.WriteLine("3. Multiplication '*' Assignment\n4. Division '/' Assignment");
                string UI = Console.ReadLine();
                int num;
                Int32.TryParse(UI, out num);

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

                    default:
                        if (num > 0 && num <= 10)
                        {
                            Console.WriteLine("\n\n\tPlease Select an Appropriate Option.");
                            Console.ReadLine();
                            Main();
                        }
                        else
                            Exit();
                        break;
                }
            }
        }

        public class Rel_Ops
        {
            // Copy - Pasted Exit Code
            public static void Exit()
            {
                Console.WriteLine("\nDo You Really Wish to Exit Arithmetic Operators?\n\nY/N?");
                string a = Console.ReadLine();
                if (a == "Y" | a == "y" | a == "Yes" | a == "yes" | a == "YES" | a == "yEs" | a == "yeS" | a == "")
                {
                    Ops.Main();
                }
                else
                {
                    Main();
                }
            }

            public static void Main()
            {
                /*
                 * Use following of the relational operators
                 * 
                 * <
                 * >
                 * <=
                 * >=
                 * 
                 */
                Console.Clear();
                Console.WriteLine("\n\t\t\tRelational Operators");

                Console.WriteLine("\nEnter Number 1 = ");
                string userinput1 = Console.ReadLine();

                Console.WriteLine("\nEnter Number 2 = ");
                string userinput2 = Console.ReadLine();
                
                
                double num1, num2;
                Double.TryParse(userinput1, out num1);
                Double.TryParse(userinput2, out num2);

                if (num1>num2)
                {
                    Console.WriteLine("{0} is greater than {1}",num1.ToString(),num2.ToString());
                }

                else if (num1<num2)
                {
                    Console.WriteLine("{1} is greater than {0}", num1.ToString(), num2.ToString());
                }

                else if (num1==num2)
                {
                    Console.WriteLine("\nBoth of the entered numbers are equal.");
                }

                else
                {
                    Exit();
                }
                    
            }
        }

        public class Log_Ops
        {
            // Copy - Pasted Exit Code
            public static void Exit()
            {
                Console.WriteLine("\nDo You Really Wish to Exit Arithmetic Operators?\n\nY/N?");
                string a = Console.ReadLine();
                if (a == "Y" | a == "y" | a == "Yes" | a == "yes" | a == "YES" | a == "yEs" | a == "yeS" | a == "")
                {
                    Ops.Main();
                }
                else
                {
                    Main();
                }
            }

            public static void Main()
            {
                /*
                 * Use following of the logical operators
                 * 
                 * &&
                 * ||
                 * !=
                 * 
                 */

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");

                Console.ReadLine();
            }
        }

        public class Bit_Ops
        {
            // Bitwise AND '&' Operator
            public static void AND()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                string userinput = Console.ReadLine();
                
            }

            // Bitwise OR '|' Operator
            public static void OR()
            {

            }

            // Bitwise XOR '^' Operator
            public static void XOR()
            {

            }


            // Bitwise One's Complement '~' Operator
            public static void OneComplement()
            {

            }

            // Bitwise Left Shift '<<'Operator
            public static void LeftShift()
            {

            }

            // Bitwise Right Shift '>>' Operator
            public static void RightShift()
            {

            }

            public static void Main()
            {
                /*
                 * Use following BitWise Operators
                 * 
                 * & Binary AND
                 * | Binary OR
                 * ^ Binary XOR
                 * ~ Binary Ones Complement Operator
                 * << Binary Left Shift Operator
                 * >> Binary Right Shift Operator
                 * 
                 */

                Console.Clear();
                Console.WriteLine("\n\t\t\tBit Operators");
                Console.WriteLine("\nPlease Select Any of the following :");
                Console.WriteLine("\n\t1.AND [&] Operator\t\t2. OR [|] Operator\n\t3. XOR [^] Operator\t\t4. One's Complement [~] Operator");
                Console.WriteLine("\n\t5. Left Shift [<<] Operator\t\t6. Right Shift [>>] Operator");

                string one = Console.ReadLine();
                int number;
                Int32.TryParse(one, out number);

                switch (number)
                {
                    case 1:
                        AND();
                        break;

                    case 2:
                        OR();
                        break;

                    case 3:
                        XOR();
                        break;

                    case 4:
                        OneComplement();
                        break;

                    case 5:
                        LeftShift();
                        break;

                    case 6:
                        RightShift();
                        break;

                    default:
                        if (number > 0 && number <= 10)
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

        // Function to return to main menu
        public static void Exit()
        {
            Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menue\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
            string a = Console.ReadLine();
            if (a == "A" | a == "a")
            {
                Menu.Main();
            }
            if (a == "B" | a == "b")
            {
                Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tOperations on Operators\nKindly Select Any of the following:");
            Console.WriteLine("\n1. Arithmetic Operators\n2. Relational Operators\n3. Logical Operators");
            Console.WriteLine("4. Bitwise Operators\n5. Assignment Operators");
            string userin = Console.ReadLine();
            int UI;
            int.TryParse(userin, out UI);
            switch (UI)
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
                    Exit();
                    break;
            }
        }
    }

// <---------------------------------------------************************************************************-------------------------------------------->

    public class BrooP
    {
        public class Branching
        {

        }

        public class Loops
        {

        }

        public static void Exit()
        {

        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("");
        }
    }
}