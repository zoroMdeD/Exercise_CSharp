using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    /* Exercise_10:
    * Добавить перегрузку, которая принимает длины двух смежных сторон (double) и величину угла между ними. 
    * Величину угла принимать как int.
    * Метод должен рассчитывать площадь по формуле:
    * 0.5 * ab * ac * sin(alpha)
    */
    class Program
    {
        static void Main(string[] args)
        {
            Area Square = new Area();

            Square.SquareTriangle(30, 40, 30);
            Console.WriteLine(Square.Square);

            Square.SquareTriangle(30, 40);
            Console.WriteLine(Square.Square);
        }
    }
}
