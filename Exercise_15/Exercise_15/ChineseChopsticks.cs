using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    public partial class ChineseChopsticks
    {
        private int sticks = 0;
        
        
        // Объявляем делегат
        public delegate void ChineseChopsticksStateHandler(string message);
        // Создаем переменную делегата
        ChineseChopsticksStateHandler first_del;
        
        // Регистрируем делегат
        public void RegisterHandler(ChineseChopsticksStateHandler del)
        {
            first_del += del;
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(ChineseChopsticksStateHandler del)
        {
            first_del -= del; // удаляем делегат
        }

        public int Sticks
        {
            get
            {
                return sticks;
            }
            private set
            {
                sticks = value;
            }
        }

        public ChineseChopsticks(int sticks = 10)
        {
            this.sticks = sticks;
        }

        public int GetSticks(int CountSticks)
        {
            if (CountSticks > 0 && CountSticks <= 3)
            {
                sticks -= CountSticks;
                if (first_del != null)
                    first_del($"Number of Chinese sticks left: {sticks}");
            }
            else
            {
                if (first_del != null)
                {
                    first_del("Please repeat enter, a number chinese chopsticks can be at 1 to 3");
                    return -1;
                }
            }
            return sticks;
        }

        public int MachineWalks()
        {
            int MaxSticks = 3;
            Random rand = new Random();

            if (sticks < 3)
                MaxSticks = sticks;

            return rand.Next(1, MaxSticks + 1);
        }
        public int CheckWins(int WhoseWin)
        {
            if(sticks <= 0)
            {
                if(WhoseWin == 1)
                {
                    if (first_del != null)
                    {
                        first_del("The machine won!");
                        return 0;
                    }
                }
                else if (WhoseWin == 0)
                {
                    if (first_del != null)
                    {
                        first_del("The player won!");
                        return 0;
                    }
                }
            }
            return -1;
        }
    }
}
