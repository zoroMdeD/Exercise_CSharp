using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    /* Exercise_11:
     * Разработать класс представляющий комплексное число. Класс должен содержать два свойства для представления вещестенной (double) и мнимой части (double). 
     * Сделать так, чтобы создать экземпляр класса без передачи соответствующих аргументов было невозможно.
     * Создать два метода, реализующих сложение и вычитание двух комплексных чисел. Чтобы сложить два комплексных числа необходимо по отдельности сложить их вещественные и мнимые части.
     * То есть, предположим, что мы имеет два комплексных числа. У первого вещественная часть равна 1, мнимая 2. У второго вещественная часть равна 3, мнимая 1. 
     * Результатам будет комплексное число, где вещественная часть равна 1+3=4, а мнимая равна 2 + 1 = 3.
     * Операция вычитания работает по тому же принципу, что и сложение (ну, только вычитание).
     * 
     * API спроектировать таким образом, чтобы клиентский код мог написать следующий код:
     * Complex c1 = new Complex(1, 1);
     * Complex c2 = new Complex(1, 2);
     * Complex result = c1.Plus(c2);
     */
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 4);
            Complex c2 = new Complex(2, 3);

            Complex result1 = c1.Plus(c2);

            Console.WriteLine($"Out complex number one (Plus): {result1.Number_a}");
            Console.WriteLine($"Out complex number two (Plus): {result1.Number_b}");
        }
    }
}
