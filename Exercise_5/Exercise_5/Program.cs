using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    /* Exercise_5:
     * Числа фибоначчи описываются следующей последовательностью: 1, 1, 2, 3, 5, 8, 13, 21...
     * Первые два числа - единицы. Все последующие числа вычисляются как сумма двух предыдущих.
     * Задание: запросить у пользователя кол-во чисел Фибоначчи, которое он хотел бы сгенерировать (вычислить), и, собственно, произвести генерацию (вычисление). 
     * В процессе генерации записывать числа в массив. После генерации вывести вычисленные числа.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int Quantity = 0;

            Console.WriteLine("Please enter the number of fibonacci values.");
            Console.Write("Quantity: ");
            Quantity = int.Parse(Console.ReadLine());

            int[] Fibonacci = new int[Quantity];

            for (int i = 0; i < Fibonacci.Length; i++)
            {
                if (i == 0 || i == 1)
                    Fibonacci[i] = 1;
                if(i > 1)
                {
                    Fibonacci[i] = Fibonacci[i-2] + Fibonacci[i-1];
                }
            }
            Console.Write($"Fibonacci values: ");
            for (int i = 0; i < Fibonacci.Length; i++)
            {
                Console.Write(Fibonacci[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
