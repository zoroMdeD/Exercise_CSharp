using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    /* Exercise_9:
     * Написать функцию, которая принимает на вход строку - римское число, а возвращает это число в арабском виде. Например, если передаём "XV" - должна вернуть 15, если передаём "IV" - должна вернуть 4.
     * Вот список римских символов и их отображение на арабские числа:
     * I - 1
     * V - 5
     * X - 10
     * L - 50
     * C - 100
     * D - 500
     * M - 1000
     * Варианты типа IIIV = 5-3 = 2 мы не рассматриваем. Хотя Римляне и пользовались иногда такими видами записей, но есть разная информация о приемлимости оных. 
     * В нашем ДЗ такие варианты мы не рассматриваем. 
     * Вот выдержка из wiki:
     * "Необходимо отметить, что другие способы «вычитания» недопустимы; так, число 99 должно быть записано как XCIX, но не как IC."
     * Подсказка. Для решения надо реализовать два правила:
     * Правила записи чисел римскими цифрами:
     * - если большая цифра стоит перед меньшей, то они складываются (принцип сложения),
     * - если меньшая цифра стоит перед большей, то меньшая вычитается из большей (принцип вычитания).
     * Защиту от некорректного ввода реализовать по вашему желанию (можно не делать, но для тренировки всегда полезно).
     */
    class Program
    {
        static void Main(string[] args)
        {
            char[] RomanNum = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] GreekNum = { 1, 5, 10, 50, 100, 500, 1000 };
            string strRoman = string.Empty;
            int data = 0;
            bool check = false;

            do
            {
                while (!check)
                {
                    Console.Write("Please enter to \"Roman\" value: ");
                    strRoman = Console.ReadLine();
                    for (int i = 0; i < strRoman.Length; i++)
                    {
                        for (int j = 0; j < RomanNum.Length; j++)
                        {
                            if (strRoman[i] == RomanNum[j])
                            {
                                check = true;
                            }
                        }
                    }
                    Console.WriteLine("Please enter correct value!");
                }
                data = integer(strRoman);
                Console.Write("\"Greek\" value: ");
                Console.WriteLine(data);
                check = false;
            } while (data != 0);
        }

        static int integer (string str)
        {
            int value = 0;

            var Num = new Dictionary<char, int>();
            Num.Add('I', 1);
            Num.Add('V', 5);
            Num.Add('X', 10);
            Num.Add('L', 50);
            Num.Add('C', 100);
            Num.Add('D', 500);
            Num.Add('M', 1000);
                    
            for(int i = str.Length - 1; i >= 0; i--)
            {
                if (i == (str.Length - 1))
                {
                    if(str.Length == 1)
                    {
                        value = value = Num[str[i]];
                        break;
                    }
                    else if (Num[str[i-1]] > Num[str[i]])
                    {
                        value = (Num[str[i-1]] + Num[str[i]]);
                    }
                    else if(Num[str[i-1]] < Num[str[i]])
                    {   
                        value = (Num[str[i]] - Num[str[i-1]]);
                    }
                    else if(Num[str[i-1]] == Num[str[i]])
                    {
                        value = (Num[str[i-1]] + Num[str[i]]);
                    }
                }
                else
                {
                    if (Num[str[i-1]] > value)
                    {
                        value = (Num[str[i-1]] + value);
                    }
                    else if(value > Num[str[i-1]])
                    {   
                        value = (value + Num[str[i-1]]);
                    }
                    else if(Num[str[i-1]] == value)
                    {
                        value = (Num[str[i-1]] + value);
                    }
                }
                if(i == 1)
                {
                    break;
                }
            }
            return value;
        }
    }
}
