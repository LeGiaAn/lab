using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_bt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (a >= b && a >= c && a >= d) ;
            {
                Console.WriteLine(a);
            }
            else if (b >= c)
            {
                Console.WriteLine(b);
            }
            else if (c >= d)
            {
                Console.WriteLine(c);
            }
            else
                Console.WriteLine(d);
        }
    }
}
