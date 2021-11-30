using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну стороны куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double V, S;
            Volume(a, out V, out S);
            Console.WriteLine("Объем куба равен {0}", V);
            Console.WriteLine("Площадь поверхности куба равена {0}", S);
            Console.ReadKey();
        }
        static void Volume(double a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6*(a*a);

        }
    }
 
}
