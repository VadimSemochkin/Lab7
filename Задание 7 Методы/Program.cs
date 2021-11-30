using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_Методы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинны сторон первого треугольника");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длинны сторон второго треугольника");
            double k = Convert.ToDouble(Console.ReadLine());
            double l = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());

            double s1, s2;
            Square(a, b, c,k ,l ,m, out s1, out s2);
  
            Console.WriteLine("Площадь первого треугольника равна {0}", s1);
            Console.WriteLine("Площадь второго треугольника равна {0}", s2);

            if (s1>s2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                if (s2 == s1)
                {
                    Console.WriteLine("Площади треугольников равны");
                }
                else
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
            }
            Console.ReadKey();
        }
        static void Square(double a, double b, double c, double k, double l, double m, out double s1, out double s2)
        {
             double p1 = (a + b + c) / 2;
             s1 = Math.Sqrt((p1 * (p1 - a) * (p1 - b) * (p1 - c)));
             double p2 = (k + l + m) / 2;
             s2 = Math.Sqrt((p2 * (p2 - k) * (p2 - l) * (p2 - m)));

        }
 
    }
}
