using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_Operators
{
    public class Rel_Op
    {
        public static void Great()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t This program compares two user entered integers");
            Console.WriteLine("\nPlease Enter A Number : ");
            string userIn1 = Console.ReadLine();
            double UI1;
            double.TryParse(userIn1, out UI1);
            Console.WriteLine("\nKindly Enter Another Number :");
            string userIn2 = Console.ReadLine();
            double UI2;
            double.TryParse(userIn2, out UI2);

            if (UI1 > UI2)
            {
                Console.WriteLine("\nFirst Entered Number is Greater than the number entered afterwards");
            }
            else
            {
                Console.WriteLine("\nSecond Entered Number is greater than the First One");
            }
        }

        public static void Less()
        {

        }

        public static void GreatEqual()
        {

        }

        public static void LessEqual()
        {

        }

        public static void NotEqual()
        {

        }

        public static void EqualTo()
        {

        }

        public static void Identical()
        {

        }

        public static void NotIdentical()
        {

        }

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tPlease Select Any of the Following:");
        }
    }
}
