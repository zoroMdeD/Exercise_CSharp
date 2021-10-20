using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        /* Exercise_8:
         * Предположим, что логин\пароль для входа в систему: johnsilver\qwerty.
         * Запросить у пользователя логин и пароль. Дать пользователю только три попытки для ввода корректной пары логин\пароль. 
         * Если пользователь произвёл корректный ввод, вывести на консоль: "Enter the System" и прекратить запрос логина\пароля. 
         * Если пользователь ошибся трижды - вывести "The number of available tries have been exceeded" и прекратить запрос пары логин\пароль.
         */
        static void Main(string[] args)
        {
            const string login_success = "johnsilver";
            const string password_success = "qwerty";
            string login = string.Empty;
            string password = string.Empty;
            int count = 0;

            while (count != 3)
            {
                count++;
                Console.Write("Please enter you login: ");
                login = Console.ReadLine();
                Console.Write("Please enter you password: ");
                password = Console.ReadLine();

                if(login == login_success)
                {
                    if(password == password_success)
                    {
                        Console.WriteLine("Enter the System");
                        break;
                    }
                    else if (count != 3)
                        Console.WriteLine($"Invalid login or password, attempts left {3 - count}, try again");
                }
                else if (count != 3)
                    Console.WriteLine($"Invalid login or password, attempts left {3 - count}, try again");
            }
            if(count == 3)
                Console.WriteLine("The number of available tries have been exceeded");
            Console.ReadLine();
        }
    }
}
