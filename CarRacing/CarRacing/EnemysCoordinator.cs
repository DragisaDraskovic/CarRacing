using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    internal class EnemysCoordinator
    {
        int endPosition = 500;
        int startPosition = -50;

        internal void MoveEnemy(PictureBox enemy, int distance)
        {
            if(enemy.Top >= endPosition)
            {
                enemy.Top = startPosition;
            }
            else
            {
                enemy.Top += distance;
            }
        }
    }
}
