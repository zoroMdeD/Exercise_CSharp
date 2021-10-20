using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    //Exercise_4:
    //Запросить у пользователя два целочисленных значения и найти максимальное.
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Please enter two integer values");
            Console.Write("Please enter integer value \"a\" = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Please enter integer value \"b\" = ");
            b = int.Parse(Console.ReadLine());
            
            if(a > b)
            {
                Console.WriteLine($"Value \"a\" = {a} the value of a is greater than \"b\" = {b}");
                Console.WriteLine($"Max value: {a}");
            }
            else
            {
                Console.WriteLine($"Value \"b\" = {b} the value of a is greater than \"a\" = {a}");
                Console.WriteLine($"Max value: {b}");
            }
            Console.ReadLine();
        }
    }
}
