using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    internal class GameOver
    {
        internal Label lblGameOver;
        internal Timer timer;

        internal GameOver(Timer timer, Label lblGameOver)
        {
            this.timer = timer;
            this.lblGameOver = lblGameOver;
        }

        internal void setGameLabel()
        {
            timer.Enabled = false;
            lblGameOver.Visible = true;
        }
     }
}
