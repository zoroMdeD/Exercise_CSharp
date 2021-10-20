using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    //Exercise_2:
    //Запросить у пользователя длины трёх сторон треугольника. Длины могут быть представлены дробными значениями.
    //После получения длин сторон - использовать формулу Герона для вычисления площади треугольника.
    //Чтобы жизнь не казалась мёдом найдите формулу самостоятельно.
    //После вычисления площади - вывести результат на консоль.
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0, b = 0.0, c = 0.0;
            double p = 0.0;
            double s = 0.0;

            Console.WriteLine("Please enter the sides of the triangle.");
            Console.Write("Please enter the side \"a\": ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the side \"b\": ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the side \"c\": ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine();
            p = 0.5 * (a + b + c);
            s = Math.Sqrt((p*((p - a)*(p - b)*(p - c))));
            Console.WriteLine($"Area triangle: {s:f2}");
            Console.ReadLine();
        }
    }
}
