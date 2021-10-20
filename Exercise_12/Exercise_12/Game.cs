using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    public class Game
    {
        private string answer = "";
        private int min = 0;
        private int max = 100;
        public string Answer
        {
            get
            {
                return answer;
            }
            private set
            {
                answer = value;
            }
        }
        public Game(string answer)
        {
            this.answer = answer;
        }

        public bool WhoIsWho()
        {
            if (answer[0] == 'U')
            {
                var rand = new Random();
                int find = 0;
                int num = 0;
                Console.Write("Please enter numeric at 0 to 100: ");
                while (true)
                {
                    num = int.Parse(Console.ReadLine());
                    if (num >= 0 && num <= 100)
                    {
                        for (int i = 5; i > 0; i--)
                        {
                            BinaryAlgorinm(num);
                            find = rand.Next(min, max + 1);
                            if (find == num)
                            {
                                Console.WriteLine("Yes match, the game is over");
                                return true;
                            }
                            else
                            {
                                Console.WriteLine($"No match, try again, attempts left: {i-1}");
                                Console.WriteLine($"Computer numbers: {find}");
                            }
                        }
                        Console.WriteLine("Computer loose, the game is over");
                        return true;
                    }
                    else
                    {
                        Console.Write("Errore, please enter numeric at 0 to 100: ");
                    }
                }
            }
            else if (answer[0] == 'M')
            {
                var rand = new Random();
                int find = 0;
                int num = 0;

                num = rand.Next(0, 101);
                Console.WriteLine("Guess a number at 0 to 100");
                Console.Write("Please enter a number: ");
                while (true)
                {
                    for (int i = 5; i > 0; i--)
                    {
                        try
                        {
                            find = int.Parse(Console.ReadLine());
                            if (num >= 0 && num <= 100)
                            {
                                if(find > num)
                                {
                                    Console.WriteLine("Your number is greater!");
                                }
                                else
                                {
                                    Console.WriteLine("Your number is less!");
                                }
                                if (find == num)
                                {
                                    Console.WriteLine("Yes match, the game is over");
                                    return true;
                                }
                                else
                                {
                                    Console.WriteLine($"No match, try again, attempts left: {i - 1}");
                                    Console.WriteLine($"User numbers: {find}");
                                }

                            }
                            else
                            {
                                Console.Write("Errore, please enter numeric at 0 to 100: ");
                            }
                        }
                        catch (Exception)
                        {;} //Добавить обработку иключений
                    }
                    Console.WriteLine("You loose, the game is over");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Unknown cmd, please repeat enter");
                Console.Write("Who will guess the number?('U'ser/'M'achine): ");
            }
            return false;
        }
        private void BinaryAlgorinm(int num)
        {
            if(num < max/2)
            {
                max = max / 2;
            }
            else
            { 
                if (min == 0)
                {
                    min = max / 2;
                }
                else
                {
                    if (num > (min + max) / 2)
                        min = ((min + max) / 2);
                    else
                        max = ((min + max) / 2);
                }
            }
        }
    }
}