using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    internal class CoinsCoordinator
    {
        int endPosition = 500;
        int startPosition = -50;

        internal void MoveCoin(PictureBox coin, int distance)
        {
            if (coin.Top >= endPosition)
            {
                coin.Top = startPosition;
            }
            else
            {
                coin.Top += distance;
            }
        }
    }
}
