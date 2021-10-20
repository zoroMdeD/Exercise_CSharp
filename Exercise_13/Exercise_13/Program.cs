using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        /* Exercise_13:
         * А вот и новое домашнее задание. Непростое. Но вполне реализуемое.
         * Вы попробуете реализовать игру в крестики-нолики размером 3х3 - самые что ни наесть обыкновенные.
         * Сделайте метод, который выводит на каждом ходу текущее положение с линейками, крестиками и ноликами (используйте буквы X и O в качестве крестиков и ноликов) - так игрокам будет удобнее ориентироваться.
         * Также вам понадобится реализовать способ проверки наличия выигрышной комбинации. 
         * Подсказа: договоримся, что клетки поля будут пронумерованы от 0 до 8 и пользователи будут вводить индекс поля, чтобы поставить там крестик или нолик.
         * Для упрощения - тот кто ходит первым - ставит крестик.
         */
        static void Main(string[] args)
        {
            int i = 0;
            bool body = true;
            bool one = true;
            bool two = true;
            string CheckWin = "null";
            TicTacToe TicTacToe = new TicTacToe();

            Console.WriteLine("Game rule:");
            Console.WriteLine("The squares of the field are numbered from 0 to 8" + Environment.NewLine + "and the players enter the field index to put a cross or zero there.");
            Console.WriteLine("[0][1][2]");
            Console.WriteLine("[3][4][5]");
            Console.WriteLine("[6][7][8]");
            Console.WriteLine("The one who goes first puts a cross.");

            while (body)
            {
                
                for (i = 1; i <= 9; i++)
                {
                    if (!(i % 2 == 0))
                    {
                        one = true;
                        while (one)
                        {
                            Console.Write("The first player walks: ");
                            try
                            {
                                int index = int.Parse(Console.ReadLine());
                                if (index >= 0 && index < 9)
                                {
                                    if (TicTacToe.Turn[index] != 'O' && TicTacToe.Turn[index] != 'X')
                                    {
                                        TicTacToe.Turn[index] = 'X';
                                        one = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please choose another input field!");
                                        i--;
                                        one = false;
                                    }

                                    Console.WriteLine($"[{TicTacToe.Turn[0]}][{TicTacToe.Turn[1]}][{TicTacToe.Turn[2]}]");
                                    Console.WriteLine($"[{TicTacToe.Turn[3]}][{TicTacToe.Turn[4]}][{TicTacToe.Turn[5]}]");
                                    Console.WriteLine($"[{TicTacToe.Turn[6]}][{TicTacToe.Turn[7]}][{TicTacToe.Turn[8]}]");

                                    CheckWin = TicTacToe.CheckWins(TicTacToe.Turn, "player_1");

                                    if (CheckWin == "player_1")
                                    {
                                        Console.WriteLine("Player one wins('X')");
                                        one = false;
                                        return;
                                    }
                                }
                                else
                                    Console.WriteLine("Please enter correct index a number!");
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("Please enter a number!");
                            }
                        }
                    }
                    else
                    {
                        two = true;
                        while (two)
                        {
                            Console.Write("The second player walks: ");
                            try
                            {
                                int index = int.Parse(Console.ReadLine());
                                if (index >= 0 && index < 9)
                                {
                                    if (TicTacToe.Turn[index] != 'O' && TicTacToe.Turn[index] != 'X')
                                    {
                                        TicTacToe.Turn[index] = 'O';
                                        two = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please choose another input field!");
                                        i--;
                                        two = false;
                                    }

                                    Console.WriteLine($"[{TicTacToe.Turn[0]}][{TicTacToe.Turn[1]}][{TicTacToe.Turn[2]}]");
                                    Console.WriteLine($"[{TicTacToe.Turn[3]}][{TicTacToe.Turn[4]}][{TicTacToe.Turn[5]}]");
                                    Console.WriteLine($"[{TicTacToe.Turn[6]}][{TicTacToe.Turn[7]}][{TicTacToe.Turn[8]}]");

                                    CheckWin = TicTacToe.CheckWins(TicTacToe.Turn, "player_2");

                                    if (CheckWin == "player_2")
                                    {
                                        Console.WriteLine("Player two wins('O')");
                                        two = false;
                                        return;
                                    }
                                }
                                else
                                    Console.WriteLine("Please enter correct index a number!");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter a number!");
                            }
                        }
                    }
                }
                while (true)
                {   
                    if(i > 9)
                    {
                        Console.WriteLine("Draw!");
                    }
                    Console.Write("Do you want restart game?(Y/N): ");
                    string answer = Console.ReadLine();
                    if (answer == "Y")
                    {
                        TicTacToe.ClearField();
                        body = true;
                        break;
                    }
                    else if (answer == "N")
                    {
                        body = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct answer!");
                    }
                }
            }
        }
    }
}
