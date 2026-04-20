using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming_Examples
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            int tal1, tal2,choice;
            float c;
            Console.WriteLine("==========Calculator==========");
            Console.WriteLine("\n Enter your first Number");
            tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your second Number");
            tal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select any below");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divided");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Plus();
                    break;
                case 1:
                    Minus();
                    break;
                case 2:
                    Multiply();
                    break;
                case 3:
                    Divide();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
        void Plus()
        {
            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        }
        void Minus()
        {
            Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
        }
        void Multiply()
        {
            Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}");
        }
        void Divide()
        {
            Console.WriteLine($"{tal1} / {tal2} = {tal1 / tal2}");
        }
    }

}
