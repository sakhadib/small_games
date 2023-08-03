using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    internal class game
    {

        int win = 5;

        public int[,] ga = new int[3, 3]
        {
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 9, 10, 11 }
        };

        public game ()
        {
            
        }

        public bool move(int x, int y, int q)
        {
            bool returner = false;
            if (ga[x, y] > 2)
            {
                ga[x, y] = q;
                returner = true;
            }
            else
            {
                returner = false;
            }

            bool won = check();

            if (won)
            {
                if(win == 0)
                {
                    utility.p1_win();
                }
                else if(win == 1)
                {
                    utility.p2_win();
                }
            }

            utility.mvcnt();
            return returner;

        }

        

        public bool check()
        {
            bool is_win = false;
            is_win = CheckThreeAdjacentSame();
            if (!is_win)
            {
                if (ga[0, 0] == ga[1, 1] && ga[1, 1] == ga[2, 2])
                {
                    win = ga[0, 0];
                    is_win = true;
                }
                else if (ga[0, 2] == ga[1, 1] && ga[1, 1] == ga[2, 0])
                {
                    win = ga[0, 2];
                    is_win = true;
                }
            }
            return is_win;
            
        }

        public bool CheckThreeAdjacentSame()
        {
            int rows = 2;
            int cols = 2;

            for(int i = 0; i <= rows; i++)
            {
                if (ga[i, 0] == ga[i, 1] && ga[i, 1] == ga[i, 2])
                {
                    win = ga[i, 0];
                    return true;
                }
            }
            for (int i = 0; i <= cols; i++)
            {
                if (ga[0, i] == ga[1, i] && ga[1, i] == ga[2, i])
                {
                    win = ga[0, i];
                    return true;
                }
            }

            return false;
        }
    }
}
