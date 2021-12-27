using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_bt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number A: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter Number B: ");
            int numberB = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            if (numberB <= 0)
            {
                Console.WriteLine("Error!!!");
            }
            else
            {
                Console.Write(numberA + " / " + numberB + " = " + (numberA / numberB));
            }
        }
    }
}
