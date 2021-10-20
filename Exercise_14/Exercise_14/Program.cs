using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        /* Exercise_14:
         * Старая добрая игра "Виселица" (с недобрым названием).
         * Смысл игры:
         * Компьютер загадывает любое слово, взятое из словаря (ссылка на словарь прилагается). 
         * Человек пытается, называя буквы, угадать слово. Если буква есть в слове, компьютер вскрывает отгаданные буквы. 
         * Неотгаданные буквы не вскрываются, а выводятся, например, прочерки (дефисы). Есть ограниченное кол-во попыток (по умолчанию, максимум 6). 
         * Если попытки исчерпаны - человек проиграл, игра завершается и показывается загаданное слово и кол-во ошибок допущенных игроком.
         * Ссылка на словарь: https://1drv.ms/t/s!AqtQeAOHZEjQuKEXnwI-VtMds9wAug?e=bGvrIR
         */
        static void Main(string[] args)
        {
            int cnt = 6;
            bool cicle = true;
            char[] GuessWord;

            while (cicle)
            {
                ReadFile ReadFile = new ReadFile();
                GuessWord = ReadFile.MakeGuess(ReadFile.CountStingToFile());
                int lenghtWord = GuessWord.Length;
                char[] UIString = new char[lenghtWord];
                for (int i = 0; i < lenghtWord; i++)
                {
                    UIString[i] = '*';
                }
                Console.WriteLine("Отгадайте загаданное слово, отгадывая скрытые буквы.");
                Console.Write("Загаданное слово: ");
                Console.WriteLine(UIString);

                while (cnt != 0)
                {
                    Console.Write("\n");
                    Console.WriteLine($"Кол-во попыток: {cnt}");
                    Console.Write("Введите букву: ");
                    char letter = char.Parse(Console.ReadLine());

                    for (int i = 0; i < lenghtWord; i++)
                    {
                        if (GuessWord[i] == letter)
                            UIString[i] = letter;
                    }

                    for (int i = 0; i < lenghtWord; i++)
                        Console.Write(UIString[i]);
                    cnt--;
                    if (GuessWord == UIString)
                    {
                        Console.WriteLine("Вы отгадали слово, поздравляем!");
                        break;
                    }
                    while(cnt == 0)
                    {
                        Console.Write("\n");
                        Console.Write("Загаданное слово: ");
                        Console.WriteLine(UIString);
                        Console.Write("Попробуйте отгадать слово: ");
                        string answer = Console.ReadLine();
                        if (GuessWord == answer.ToCharArray())
                        {
                            Console.Write("Вы отгадали слово, поздравляем!");
                            break;
                        }
                        else
                        {
                            Console.Write("Вы проиграли, загаданное слово: ");
                            Console.WriteLine(GuessWord);
                            break;
                        }
                    }
                }
                while (true)
                {
                    Console.Write("\n");
                    Console.WriteLine("Хотите начать новую игру?(Да/Нет)");
                    string answer = Console.ReadLine();
                    if (answer == "Да")
                    {
                        cnt = 6;
                        break;
                    }
                    else if (answer == "Нет")
                    {
                        cicle = false;
                        break;
                    }
                    else
                        Console.WriteLine("Ошибка ввода!");
                }
            }
        }
    }
}
