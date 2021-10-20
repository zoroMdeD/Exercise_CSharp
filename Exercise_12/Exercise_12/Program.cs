﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    /* Exercise_12:
     * Разработать игру "угадай число".
     * Смысл игры.
     * Один из игроков загадывает число от 0 до 100 (по умолчанию), а второй пытается угадать за лимитированное число попыток (5 по умолчанию). 
     * Когда второй игрок делает предположение о загаданном числе, первый игрок сообщает о том угадано ли число, меньше ли оно загаданного, или больше. 
     * Если угадано - игра завершена. Если меньше или больше загаданного, то второй игрок сужает область поиска и продолжает пытаться угадывать. 
     * Так происходит до тех пор пока либо число не угадано, либо исчерпано кол-во попыток.
     * Загадывать может как человек, так и машина. Соответственно и угадывать может как человек, так и машина. 
     * Это значит, что надо реализовать два режима игры: когда загадывает машина и когда загадывает человек.
     * Если загадывает человек, а угадывает машина, то нужно сделать так, чтобы машина пыталсь угадать число, используя алгоритм бинарного поиска.
     * Пример бинарного поиска загаданного числа:
     * загадано число 18, при условии, что число загадывалось в диапазоне от 0 до 100. 
     * Игрок каждый раз берёт середину, т.е. на первой попытке предполагает число 50. 
     * Первый игрок говорит, что загаданное число меньше. Значит число лежит между 0 и 50. 
     * Тогда второй игрок снова делит диапазон на 2 и предполагает 25. Первый игрок говорит, что загаднное число меньше. 
     * Значит число между 0 и 25. Тогда второй игрок снова делит диапазон на 2 и предполагает 12 (дробную часть мы просто срезаем). 
     * Первый игрок говорит, что загаданное число больше. Значит число лежит в диапазоне между 12 и 25. 
     * Второй игрок делить диапазон на два и предполагает 18. Первый игрок говорит, что число угадано. Игра завершена.
     * На каждой попытке , благодаря так стратегии, диапазон поиска сужается в два раза. 
     * Это и есть суть бинарного поиска. В конце игры выводится информация о том достигнута ли победа или нет. 
     * Конечно же, будет необходимо реализовать диалог между игроками.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool cicle = true;
            bool check = false;
            Console.Write("Who will guess the number?('U'ser/'M'achine): ");
            while (cicle)
            {
                try
                {
                    string answer = Console.ReadLine();
                    Game Game = new Game(answer);
                    check = Game.WhoIsWho();
                    if (check == true)
                    {
                        Console.WriteLine("Restart the game?(Y/N): ");
                        while (true)
                        {
                            try
                            {
                                answer = Console.ReadLine();
                                if (answer[0] == 'Y')
                                {
                                    Console.Write("Who will guess the number?('U'ser/'M'achine): ");
                                    cicle = true;
                                    break;
                                }
                                else if (answer[0] == 'N')
                                {
                                    cicle = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Errore, please enter correct CMD: ");
                                    Console.WriteLine("Restart the game?(Y/N): ");
                                }
                            }
                            catch (Exception)
                            {;} //Добавить обработку иключений
                        }
                    }
                }
                catch (Exception)
                {;} //Добавить обработку иключений
            }
        }
    }
}
