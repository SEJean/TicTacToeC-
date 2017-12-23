using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{


    public class HudManager
    { 
        public Label GameStatus { get; set; }
        public Label XScore { get; set; }
        public Label OScore { get; set; }

        public void SetStatus(string p_Message)
        {
            GameStatus.Text = p_Message;
        }

        public void SetScore(char p_Player)
        {
            int score;
            Label lblPlayer;
            if (p_Player == 'X')
            {
                score = Convert.ToInt32(XScore.Text);
                lblPlayer = XScore;
            }
            else
            {
                score = Convert.ToInt32(OScore.Text);
                lblPlayer = OScore;
            }
            score++;
            lblPlayer.Text = score.ToString();
        }
    }
}
