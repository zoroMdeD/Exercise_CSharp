using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    /* Exercise_6:
     * Запросить у пользователя не более 10 целых чисел. Пользователь может прекратить приём чисел, введя 0.
     * После прекращения приёма целых чисел (это происходит в случае если было введено 10 чисел, либо пользователь ввёл 0, чтобы не вводить все 10) 
     * подсчитать среднее значение введённых целых чисел и вывести на консоль.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double[] mass_int = new double[10];
            int i = 0;
            Console.WriteLine("Please enter <= 10 integers value.");

            do
            {
                mass_int[i] = double.Parse(Console.ReadLine());
                if (mass_int[i] == 0)
                    break;
                i++;
            }
            while (i < 10);

            double summ = 0.0;
            double average = 0.0;

            for (int j = 0; j < mass_int.Length; j++)
            {
                summ = summ + mass_int[j]; 
            }
            average = summ / i;
            Console.WriteLine($"Average of values: {average:f2}");
            Console.ReadLine();
        }
    }
}
