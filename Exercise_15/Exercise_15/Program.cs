using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise_15.ChineseChopsticks;

namespace Exercise_15
{
    class Program
    {
        /* Exercise_15:
         * Вы попробуете разработать игру.
         * Предлагаю древнюю китайскую игру в палочки.
         * Играют два игрока.  Есть 10 палочек (по умолчанию). Игроки по очереди берут от одной до трёх палочек. 
         * Играют до тех пор пока не закончатся палочки. Тот кто взял последним - тот проиграл.
         * Реализуйте игру таким образом, чтобы против человек играл компьютер. Изначально есть 10 палочек. 
         * На каждом ходу выводите на консоль текущее количество оставшихся палочек и просите ввести количество палочек, которое хочет взять игрок (который делает ход. машина делает ход автоматически при своей очереди, её просить не надо :)). 
         * Не забывайте менять очерёдность игроков и сокращать кол-во палочек. В конце надо вывести кто победил - человек или машина.
         * Нюансы реализации могут отличаться. Кто-то может захотеть реализовать не с 10-ю палочками, а с тем количеством, которое введёт пользователь (может он хочет играть с 20-ю палочками?).
         */
        static void Main(string[] args)
        {
            int sticks = 0;
            int answer = 0;
            bool cicle = true;

            while (cicle)
            {
                ChineseChopsticks ChineseChopsticks = new ChineseChopsticks();
                ChineseChopsticksStateHandler GetDelegate = new ChineseChopsticksStateHandler(Show_Message);
                ChineseChopsticksStateHandler WonDelegate = new ChineseChopsticksStateHandler(Show_Message);
                // Добавляем в делегат ссылку на метод Show_Message
                // а сам делегат передается в качестве параметра метода RegisterHandler
                //ChineseChopsticks.RegisterHandler(new ChineseChopsticks.ChineseChopsticksStateHandler(Show_Message));
                ChineseChopsticks.RegisterHandler(GetDelegate);
                do
                {
                    Console.WriteLine("User walks.");
                    do
                    {
                        Console.Write("Please enter a number chinese chopsticks at 1 to 3: ");
                        answer = int.Parse(Console.ReadLine());
                        sticks = ChineseChopsticks.GetSticks(answer);
                        ChineseChopsticks.RegisterHandler(WonDelegate);
                        ChineseChopsticks.UnregisterHandler(WonDelegate);
                        answer = ChineseChopsticks.CheckWins((int)WhoseWin.User);
                    }
                    while (answer < 0 && sticks <= 0);
                    if (sticks != 0)
                    {
                        Console.WriteLine("Machine walks.");
                        answer = ChineseChopsticks.MachineWalks();
                        sticks = ChineseChopsticks.GetSticks(answer);
                        ChineseChopsticks.RegisterHandler(WonDelegate);
                        ChineseChopsticks.UnregisterHandler(WonDelegate);
                        answer = ChineseChopsticks.CheckWins((int)WhoseWin.Machine);
                    }
                }
                while (answer < 0);
                while (answer == 0)
                {
                    Console.WriteLine("Restart the game?(Y/N): ");
                    string enter = Console.ReadLine();
                    if (enter == "Y")
                    {
                        cicle = true;
                        break;
                    }
                    else if (enter == "N")
                    {
                        cicle = false;
                        break;
                    }
                }
            }
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
    }
}
