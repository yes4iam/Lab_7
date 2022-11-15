using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static double GetPerimTriangle (double a, double b, double c, out double s)
        {
            double p = (a + b + c) / 2;
            return s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s;
            double s1 = GetPerimTriangle(a1, b1, c1, out s);
            Console.WriteLine("{0}", s1);
            Console.WriteLine("введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetPerimTriangle(a2, b2, c2, out s);
            Console.WriteLine("{0}", s2);
            if (s1>s2)
            {
                Console.WriteLine("площадь первого треугольника больше площади второго");
            }
            else
            {
                if (s1 < s2)
                {
                    Console.WriteLine("площадь первого треугольника меньше площади второго");
                }
                else
                {
                    Console.WriteLine("площади равны");
                }
            }
            Console.ReadKey();
        }
    }
}
