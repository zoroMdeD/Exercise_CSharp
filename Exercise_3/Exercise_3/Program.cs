using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    /* Exercise_3:
     * Запросить у пользователя: фамилию, имя, возраст, вес, рост.
     * Высчитать ИМТ (индекс массы тела) по формуле ИМТ = вес (кг) / (рост (м) * рост (м))
     * Сформировать единую строку, в следующем формате:
     * Your profile:
     * Full Name: фамилия, имя
     * Age: рост
     * Weight: вес
     * Height: рост
     * Body Mass Index: ИМТ
     * Вывести сформированную строку на консоль.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your surname: ");
            string SurName = Console.ReadLine();

            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your weight in kg: ");
            double Wg = double.Parse(Console.ReadLine());

            Console.Write("Please enter your height in cm: ");
            double Hg = double.Parse(Console.ReadLine());

            double IMT = Wg / ((Hg / 100) * (Hg / 100));
            Console.WriteLine();

            Console.WriteLine("Your profile:" + Environment.NewLine + 
                             $"Full Name: {SurName}, {Name}" + Environment.NewLine + 
                             $"Age: {Age}" + Environment.NewLine + 
                             $"Weight: {Wg}" + Environment.NewLine + 
                             $"Height: {Hg}" + Environment.NewLine + 
                             $"Body Mass Index: {IMT:f2}");

            Console.ReadLine();
        }
    }
}
