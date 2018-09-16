﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Library
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
                Console.WriteLine("\t\t\tDecrement Operation");
                Console.WriteLine("\nKindly Enter ny number");
                double num, num1;
                num = Convert.ToDouble(Console.ReadLine());
                num1 = num;
                num--;
                Console.WriteLine("\nEntered Number is {0} and after decrement, it is {1}", num1.ToString(), num.ToString());
                Console.ReadLine();
                Main();
            }

            // Function to Ask to Exit the Console
            public static void Exit()
            {
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    Ops.Main();
                }
                else
                {
                    Environment.Exit(0);
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

                    case 6:
                        Inc();
                        break;

                    case 7:
                        Dec();
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
                Console.Clear(); // Console screen is cleared
                Console.WriteLine("\n\t\tAddition Assignment Operator"); //             Addition Assignment Operator
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be incremented");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be added to the first");
                string usernum3 = Console.ReadLine();

                // Following code converts the string input into the number format
                double num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                double.TryParse(usernum1, out num1);
                double.TryParse(usernum2, out num2);
                double.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= num3; num5++)
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

                for (num5 = 1; num5 <= num3; num5++)
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

                for (num5 = 1; num5 <= num3; num5++)
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

                for (num5 = 1; num5 <= num3; num5++)
                {
                    num1 /= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto divide the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Using "%="
            public static void Mod()
            {
                Console.Clear();
                Console.WriteLine("\n\t\tModulus Assignment Operator");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be operated");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be operated with first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                double num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                double.TryParse(usernum1, out num1);
                double.TryParse(usernum2, out num2);
                double.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= num3; num5++)
                {
                    num1 %= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto operate the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Using "&="
            public static void And()
            {
                Console.Clear();
                Console.WriteLine("\n\t\tAnd Assignment Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be operated");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be operated with first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                int num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                int.TryParse(usernum1, out num1);
                int.TryParse(usernum2, out num2);
                int.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= num3; num5++)
                {
                    num1 &= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto operate the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Using "|="
            public static void OR()
            {
                Console.Clear();
                Console.WriteLine("\n\t\tAnd Assignment Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be operated");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be operated with first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                int num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                int.TryParse(usernum1, out num1);
                int.TryParse(usernum2, out num2);
                int.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= num3; num5++)
                {
                    num1 |= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto operate the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }


            // Using "^="
            public static void XOR()
            {
                Console.Clear();
                Console.WriteLine("\n\t\tAnd Assignment Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");
                Console.WriteLine("\nEnter any number");
                string usernum1 = Console.ReadLine();
                Console.WriteLine("\nEnter a number by which the previous number is to be operated");
                string usernum2 = Console.ReadLine();
                Console.WriteLine("\nEnter, how many number of times \n\tthe second input number is to be operated with first");
                string usernum3 = Console.ReadLine();

                // Following convert the string input into the number format
                int num1, num2, num3, num4, num5; // num5 variable is taken for the purpose of loop
                int.TryParse(usernum1, out num1);
                int.TryParse(usernum2, out num2);
                int.TryParse(usernum3, out num3);
                num4 = num1;

                for (num5 = 1; num5 <= num3; num5++)
                {
                    num1 ^= num2;
                }

                Console.WriteLine("\nEntered number was {0}, you requested \nto operate the {0} by {1} number and by {2} times", num4.ToString(), num2.ToString(), num3.ToString());
                Console.WriteLine("Henceforth, after assignment operation, the result is " + num1.ToString());
                Console.ReadLine();
                Main();
            }

            // Standard (Copy-Pasted) Exit class
            public static void Exit()
            {
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    Ops.Main();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            public static void Main()
            {
                Console.Clear();
                Console.WriteLine("\n\tPlease Select any of the following assignment operation");
                Console.WriteLine("\n1. Addition '+' Assignmen\n2. Subtraction '-' Assignment");
                Console.WriteLine("3. Multiplication '*' Assignment\n4. Division '/' Assignment");
                Console.WriteLine("5. Modulues '%' Assignment\n6. And '&' Assignment");
                Console.WriteLine("7. OR '|' Assignment\n8. XOR '^' Assignment");
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

                    case 5:
                        Mod();
                        break;

                    case 6:
                        And();
                        break;

                    case 7:
                        OR();
                        break;

                    case 8:
                        XOR();
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
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    Ops.Main();
                }
                else
                {
                    Environment.Exit(0);
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

                if (num1 > num2)
                {
                    Console.WriteLine("{0} is greater than {1}", num1.ToString(), num2.ToString());
                }

                else if (num1 < num2)
                {
                    Console.WriteLine("{1} is greater than {0}", num1.ToString(), num2.ToString());
                }

                else if (num1 == num2)
                {
                    Console.WriteLine("\nBoth of the entered numbers are equal.");
                }

                else
                {
                    Exit();
                }

            }
        }
        ;
        public class Log_Ops
        {
            // Copy - Pasted Exit Code
            public static void Exit()
            {
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    Ops.Main();
                }
                else
                {
                    Environment.Exit(0);
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
                Console.WriteLine("\n\t\t\tLogical Operators");
                Console.WriteLine("\nThis functions either adds or subtracts any input made");
                Console.WriteLine("\nEnter Anything :");
                string userinput = Console.ReadLine();
                Console.WriteLine("\nEnter Something Else : ");
                string userinput1 = Console.ReadLine();

                float num, num1;
                float.TryParse(userinput, out num);
                float.TryParse(userinput1, out num1);

                if (num > num1 && num != 0)
                {
                    Console.WriteLine("\n{0} is converted into {1} and is greater than {2}, a conversion of {3}", userinput, num.ToString(), num1.ToString(), userinput1);
                }

                else if (num < num1 || num1 != 0)
                {
                    Console.WriteLine("\n{0} is converted into {1} and is less than {2}, a conversion of {3}", userinput, num.ToString(), num1.ToString(), userinput1);
                }

                else
                {
                    Exit();
                }
            }
        }

        public class Bit_Ops
        {
            // Copy-Pasted Exit Program
            public static void Exit()
            {
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    Ops.Main();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            // Bitwise AND '&' Operator
            public static void AND()
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\tBitwise & (AND) Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");

                Console.WriteLine("\nEnter First Number = ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter Second Number = ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int result = number1 & number2;

                Console.WriteLine("\nThe result of Bitwise '&' (AND) Operator is {0}", result.ToString());
                Console.ReadLine();
                Main();
            }

            // Bitwise OR '|' Operator
            public static void OR()
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\tBitwise | (OR) Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");

                Console.WriteLine("\nEnter Number One -> ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter Number Two -> ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int result = number1 | number2;

                Console.WriteLine("\nThe result of Bitwise '|' (OR) Operator is {0}", result.ToString());
                Console.ReadLine();
                Main();
            }

            // Bitwise XOR '^' Operator
            public static void XOR()
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\tBitwise ^ (XOR) Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");

                Console.WriteLine("\nEnter Number One ->");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter Number Two ->");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int result = number1 ^ number2;

                Console.WriteLine("\nThe result of Bitwise '^' (XOR) Operator is {0}", result.ToString());
                Console.ReadLine();
                Main();
            }


            // Bitwise Complement '~' Operator
            public static void OneComplement()
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\tBitwise ~ (Completement) Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");
                Console.WriteLine("\nEnter Any Number : ");
                string userinput = Console.ReadLine();

                int num, result;
                Int32.TryParse(userinput, out num);

                result = ~num;

                Console.WriteLine("\nThe '~' (Complement) Bitwise :");
                Console.WriteLine("\nConverts the {0} into {1}", num.ToString(),result.ToString());

                Console.ReadLine();
                Main();
            }

            // Bitwise Left Shift '<<'Operator
            public static void LeftShift()
            {
                Console.Clear();

                Console.WriteLine("\n\t\t\tBitwise Left Shift Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");

                Console.WriteLine("\nEnter Any Number : ");
                string userinput = Console.ReadLine();

                int num, result;
                Int32.TryParse(userinput, out num);
                result = num << 4;

                Console.WriteLine("\nEntered number was {0}. After (left) shifting by 4, we get {1}", num.ToString(), result.ToString());
                Console.ReadLine();
                Main();
            }

            // Bitwise Right Shift '>>' Operator
            public static void RightShift()
            {
                Console.Clear();

                Console.WriteLine("\n\t\t\tBitwise Right Shift Operator");
                Console.WriteLine("\n\n<===========Integer Input Only===========>");

                Console.WriteLine("\nEnter Any Number : ");
                string userinput = Console.ReadLine();

                int num, result;
                Int32.TryParse(userinput, out num);
                result = num >> 4;

                Console.WriteLine("\nEntered number was {0}. After (right) shifting by 4, we get {1}", num.ToString(), result.ToString());
                Console.ReadLine();
                Main();
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
                Console.WriteLine("\t5. Left Shift [<<] Operator\t6. Right Shift [>>] Operator");

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
            Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Exit the Program");
            string a = Console.ReadLine();
            if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
            {
                ;
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
    // <---------------------------------------------************************************************************-------------------------------------------->
    // <---------------------------------------------************************************************************-------------------------------------------->

    public class BrooP
    {
        public class Branching
        {
            public static void If()
            {

            }

            public static void NestedIf()
            {

            }


            public static void IfElse()
            {

            }

            public static void IfElseIf()
            {

            }

            public static void Switch()
            {

            }

            public static void Exit()
            {
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    BrooP.Main();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            public static void Main()
            {
                Console.Clear();
                /*
                 * 
                 * Branching Statements - 1) If 2) Nested If 3) If-Else 4) If-elseif 5) Switch
                 * Looping Statements - 1) For 2) While 3) Do-While 4) foreach
                 * Jumping Statements - 1) goto 
                 * 
                 */

                Console.WriteLine("\n\t\t\tBranching Statements Menu");
                Console.WriteLine("1.If \n2. Nested If\n3. If-Else\n4. If-ElseIf\n5. Switch");
                string userinput = Console.ReadLine();
                int number;

                int.TryParse(userinput, out number);

                switch (number)
                {
                    case 1:
                        ;
                        break;

                    case 2:
                        ;
                        break;

                    case 3:
                        ;
                        break;

                    case 4:
                        ;
                        break;

                    case 5:
                        ;
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

        public class Loops
        {
            public static void Exit()
            {
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    BrooP.Main();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

                public static void Main()
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\tLooping Statements Menu");
                Console.WriteLine("1. For\n2. For-Each\n3. Do\n4.Do-While");
                string userinput = Console.ReadLine();
                int number;
                int.TryParse(userinput, out number);
                switch (number)
                {
                    case 1:
                        ;
                        break;

                    case 2:
                        ;
                        break;

                    case 3:
                        ;
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

        public class Jump
        {
            public static void Exit()
            {
                Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
                string a = Console.ReadLine();
                if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
                {
                    ;
                }
                if (a == "B" | a == "b")
                {
                    BrooP.Main();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            public static void Main()
            {
                Console.Clear();
                Console.WriteLine("\nJumping Statement");
                Console.WriteLine("<------Only One Statement Available------>");
                Console.WriteLine("\t\tGoTo");

            }
        }

        public static void Exit()
        {
            Console.WriteLine("\nDo You Wish To \n\tA. Return to Main Menu\n\tB. Go Back to Operators Menu\n\tC. Exit the Program");
            string a = Console.ReadLine();
            if (a == "A" | a == "a" | a == "1" | a == "Return" | a == "Main Menu" | a == "Return to Main")
            {
                ;
            }
            if (a == "B" | a == "b")
            {
                BrooP.Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tBranching & Looping Statements");
            Console.WriteLine("\nKindly Select Any one of the Followig Option");
            Console.WriteLine("\n1. Branching Statements\n2. Looping Statements\n3. Jumping Satements");
            string userin = Console.ReadLine();

            int input;
            int.TryParse(userin, out input);

            switch(input)
            {
                case 1:
                    Branching.Main();
                    break;

                case 2:
                    Loops.Main();
                    break;

                case 3:
                    Jump.Main();
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
                    };
                    break;
            }

            Console.ReadLine();
        }
    }

    // <---------------------------------------------************************************************************-------------------------------------------->
    // <---------------------------------------------************************************************************-------------------------------------------->
    // <---------------------------------------------************************************************************-------------------------------------------->

    public class Misc_Proj
    {
        public static void Student()
        // Student Percentage Calculation
        {
            Console.Clear();
            Console.WriteLine("\nEnter the following details :\n");
            Console.WriteLine("\nEnter Marks for 1st Subject : \t");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 2nd Subject : \t");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 3rd Subject : \t");
            double s3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 4th Subject : \t");
            double s4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 5th Subject : \t");
            double s5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter Marks for 6th Subject : \t");
            double s6 = Convert.ToDouble(Console.ReadLine());
            double total = s1 + s2 + s3 + s4 + s5 + s6;
            double per = total / 6;
            Console.WriteLine("\nTotal Marks Secured : \t{0} and percntage are \t{1} %", total.ToString(), per.ToString());
            Console.ReadLine();
            Main();
        }

        public static void Area()
        //Calculating Area of Circle
        {
            Console.Clear();
            const double pi = (double)22/7;
            Console.WriteLine("\nEnter the Radius of the Circle");
            double r = Convert.ToDouble(Console.ReadLine());
            double a = pi * r * r;
            Console.WriteLine("\nThe Radius given is {0} and the area of the circle therefore is\n{1}", r.ToString(), a.ToString());
            Console.ReadLine();
            Main();
        }

        public static void Max()
        {
            Console.Clear();
            // Code to find out maximum number from given number
            Console.WriteLine("\n\t\t\tFinding Max Number");
            Console.Write("\nEnter First Number : ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter Second Number :  ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter Third Number : ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            if(number1 > number2 && number1 > number3)
            {
                Console.Write("\nThe Largest Number is " + number1);
            }

            else if(number2>number1 && number2>number3)
            {
                Console.Write("\nThe Largest Number is " + number2);
            }

            else if(number3>number1 && number3>number2)
            {
                Console.Write("\nThe Largest Number is " + number3);
            }

            /*
            else if(number1==number2 && number1>number3)
            {
                Console.Write("\nEntered Number First & Second are equal and larger than nummber Third");
            }

            else if(number1==number3 && number1>number2)
            {
                Console.Write("\nEntered Number First & Third are equal and larger than number Second");
            }

            else if (number1 == number2 && number1 < number3)
            {
                Console.Write("\nEntered Number First & Second are equal and smaller than nummber Third");
            }

            else if (number1 == number3 && number1 < number2)
            {
                Console.Write("\nEntered Number First & Third are equal and smaller than number Second");
            }
            */

            else
            {
                Console.Write("\nAll the entered numbers are equal");
            }

            Console.ReadLine();
            Main();
        }

        public static void Magnitude()
        {
            Console.Clear();
            // Code to find out magnutude of a number
            /*
             * Divide the number by ten and increment the count
             * 
             * Accept any number
             * Divide it by 10  whish shouldn't be equal to zero
             * 
             */
            Console.WriteLine("\n\t\t\tMagnitude of a Number");
            Console.WriteLine("\n\n<===========Integer Input Only===========>");
            Console.WriteLine("\nEnter Any Number");
            long input = Convert.ToInt64(Console.ReadLine()),counter=0;

            do
            {
                counter++;
                input = input / 10;
            }
            while (input != 0);

            Console.WriteLine("\nThe Number of Digits in entered number is = {0}",counter.ToString());
            Console.ReadLine();
            Main();
        }

        public static void Palindrome()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tPalindrome Program");
            /*
             * 
             * Similar to Magnitude Program
             * 
             * for (count= 1; (number/10) != 0; count++)
             * {
             *      reverse = number % 10;
             *      number = number / 10;
             *      Console.Write(reverse)
             *       if (
             * }
             * 
             */
            Console.WriteLine("\nEnter Anything :");
            string input = Console.ReadLine();      // Accepting Input from the User
            string reverse = "";                    // Initializing an empty string to store value later on
            int length;                             // Counter for loop purpose (I think)
            length = input.Length - 1;              // Storing number of characters of User Input String && Subtraction since numbering starts from 0
            while (length>=0)                       // Loop will run till last character of the string is not reached
            {
                reverse = reverse + input[length];  // This is to be confirmed
                length--;                           // Reverse Loop
            }
            Console.Write("\nPalindrome of Your Input is as follows :");
            Console.Write(reverse);
            Console.ReadLine();
            Main();
        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\nSelect Any of the Following Projects");
            Console.WriteLine("1. Percentage of Student\n2. Area of a Circle\n3. Number of Digits");
            Console.WriteLine("4. Maximum Number\n5. Palindrome\n6. ");

            string input = Console.ReadLine();
            int menunum;
            int.TryParse(input, out menunum);

            switch (menunum)
            {
                case 1:
                    Student();
                    break;

                case 2:
                    Area();
                    break;

                case 3:
                    Magnitude();
                    break;

                case 4:
                    Max();
                    break;

                case 5:
                    Palindrome();
                    break;

                case 6:
                    ;
                    break;

                default:
                    ;
                    break;
            }
        }
    }
}