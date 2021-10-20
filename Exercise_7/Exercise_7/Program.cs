using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        /* Exercise_7:
         * Факториалом числа является произведение этого числа на все предшествующие этому числу числа (кроме 0). 
         * Факториал в математике записывается через восклицательный знак. Например 5! = 5*4*3*2*1 = 120. Особые случаи: 0! = 1. 1! = 1.
         * Задача: запросить у пользователя число, факториал которого необходимо вычислить и произвести вычисление. Затем вывести результат вычисления. 
         * Восклицательный знак запрашивать не надо, кроме того, в C# такой операции нет. Для вычисления факториала надо производить перемножение.
         */
        static int fact(int factorial)
        {
            if (factorial == 1)
                return 1;

            return factorial * fact(factorial - 1);
        }
        static void Main(string[] args)
        {
            int factorial = 0;
            int composition = 0;
            Console.Write("Please enter to value of factorial: ");

            //at recursion
            //composition = fact(factorial = int.Parse(Console.ReadLine()));

            //at cicle
                factorial = int.Parse(Console.ReadLine());
                composition = factorial;
                for (int i = factorial; i > 1; i--)
                {
                    composition = composition * (factorial - (i - 1));
                }
            //
            Console.Write($"Factorial of value: {factorial} equals {composition}");
            Console.ReadLine();
        }

    }
}
