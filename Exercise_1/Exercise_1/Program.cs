using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    //  Exercise_1:
    //  1. Запросить имя пользователя.Вывести Hello, [имя пользователя].
    //  2. Запросить у пользователя два целых числа и сохранить в двух переменных.Вывести значения. 
    //     Обменять значения переменных: например, если в переменной x было записано число 3, а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5. Вывести значения после обмена.
    //  3. Запросить у пользователя целое число.Вывести количество цифр числа. Например, в числе 156 - 3 цифры.
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            string a = "", b = "";
            string tmp = "";
            string one_int = "";
            int one_int_length = 0;

            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine();
            Console.WriteLine($"Hello, {Name}");

            Console.WriteLine("Please enter two integers with enter!");
            Console.Write("Please enter variable \"a\": ");
            a = Console.ReadLine();
            Console.Write("Please enter variable \"b\": ");
            b = Console.ReadLine();
            Console.WriteLine($"Your entered two integers: a = {a}, b = {b}");
            Console.WriteLine();
            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Value of variables after exchange: a = {a}, b = {b}");
            Console.WriteLine("Please enter one integer: ");
            one_int = Console.ReadLine();
            one_int_length = one_int.Length;
            Console.WriteLine($"Number of numbers in a number: {one_int_length}");
            Console.ReadLine();
        }
    }
}
