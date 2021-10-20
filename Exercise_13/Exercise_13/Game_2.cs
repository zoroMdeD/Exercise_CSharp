using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    public class TicTacToe
    {
        private char[] turn = new char[9];

        public char[] Turn
        {
            get
            {
                return turn;
            }
            private set
            {
                turn = value;
            }
        }
        public TicTacToe()
        {

        }

        public string CheckWins(char[] Turn, string player)
        {
            if(player == "player_1")
            {
                if ((Turn[0] == 'X') && (Turn[1] == 'X') && (Turn[2] == 'X'))
                    return "player_1";
                else if ((Turn[3] == 'X') && (Turn[4] == 'X') && (Turn[5] == 'X'))
                    return "player_1";
                else if ((Turn[6] == 'X') && (Turn[7] == 'X') && (Turn[8] == 'X'))
                    return "player_1";
                else if ((Turn[0] == 'X') && (Turn[3] == 'X') && (Turn[6] == 'X'))
                    return "player_1";
                else if ((Turn[1] == 'X') && (Turn[4] == 'X') && (Turn[7] == 'X'))
                    return "player_1";
                else if ((Turn[2] == 'X') && (Turn[5] == 'X') && (Turn[8] == 'X'))
                    return "player_1";
                else if ((Turn[0] == 'X') && (Turn[4] == 'X') && (Turn[8] == 'X'))
                    return "player_1";
                else if ((Turn[2] == 'X') && (Turn[4] == 'X') && (Turn[6] == 'X'))
                    return "player_1";
            }
            else if (player == "player_2")
            {
                if ((Turn[0] == 'O') && (Turn[1] == 'O') && (Turn[2] == 'O'))
                    return "player_2";
                else if ((Turn[3] == 'O') && (Turn[4] == 'O') && (Turn[5] == 'O'))
                    return "player_2";
                else if ((Turn[6] == 'O') && (Turn[7] == 'O') && (Turn[8] == 'O'))
                    return "player_2";
                else if ((Turn[0] == 'O') && (Turn[3] == 'O') && (Turn[6] == 'O'))
                    return "player_2";
                else if ((Turn[1] == 'O') && (Turn[4] == 'O') && (Turn[7] == 'O'))
                    return "player_2";
                else if ((Turn[2] == 'O') && (Turn[5] == 'O') && (Turn[8] == 'O'))
                    return "player_2";
                else if ((Turn[0] == 'O') && (Turn[4] == 'O') && (Turn[8] == 'O'))
                    return "player_2";
                else if ((Turn[2] == 'O') && (Turn[4] == 'O') && (Turn[6] == 'O'))
                    return "player_2";
            }
            return "";
        }
        public void ClearField()
        {
            for(int i = 0; i < 9; i++)
                turn[i] = ' ';
        }
    }
}
