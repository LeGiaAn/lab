using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai pt bac 2");
            Console.Write("Nhap a: ");
            int soA = System.Int32.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int soB = System.Int32.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            float soC = Convert.ToSingle(Console.ReadLine());

            float delta = ((soB * soB) - (4 * soA * soC));
            Console.WriteLine("Delta = " + delta);

            if (delta < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Pt co nghiem kep: X1 = X2 = " + ((-soB) / (2 * soA)));
            }
            else
            {
                double x1 = ((-1) * soB - Math.Sqrt(delta)) / (2 * soA);
                double x2 = ((-1) * soB + Math.Sqrt(delta)) / (2 * soA);
                Console.WriteLine("Pt co 2 nghiem phan biet: X1 = " + x1 + " X2 = " + x2);
                Console.ReadKey();
            }
        }
    }
}
