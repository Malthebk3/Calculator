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

        }


    }

}

