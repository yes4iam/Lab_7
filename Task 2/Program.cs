using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void GetCubeParams(double a, out double s, out double v)
        {
            s = 6*a*a;
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetCubeParams(a, out s, out v);
            Console.WriteLine("Площадь поверхности куба - {0:.00}, Объем куба - {1:.00}", s, v);
            Console.ReadKey();
        }
    }
}
