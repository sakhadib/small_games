using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    internal static class utility
    {
        public static game g;
        public static bool move = false;
        public static int mvct = 0;
        
        public static string player_1 = "Player 1";
        public static string player_2 = "player 2";

        public static int p1_pts = 0;
        public static int p2_pts = 0;

        public static bool curr_move = false;
        public static string curr_winner = "nobody";

        public static void p1_win()
        {
            p1_pts++;
            curr_winner = player_1;
        }

        public static void p2_win()
        {
            p2_pts++;
            curr_winner = player_2;
        }

        public static void mvcnt()
        {
            mvct++;
            if(mvct == 9 && curr_winner == "nobody")
            {
                // MessageBox.Show("problem boss");
                curr_winner = "draw";
            }
        }

        public static void init()
        {
            curr_winner = "nobody";
            curr_move = false;
            move = false;
            mvct = 0;
        }
    }
}
