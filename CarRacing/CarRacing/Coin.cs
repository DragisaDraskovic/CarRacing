using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    internal class Coin
    {
        private List<PictureBox> coin = new List<PictureBox>();
        internal List<PictureBox> allCoins
        {
            get
            {
                return coin;
            }
        }   
        internal Coin(params PictureBox[] coins)
        {
            foreach (var ccoin in coins)
            {
                coin.Add(ccoin);
            }
        }
        
        internal bool CheckWereBoundsTouched(Car car)
        {
            foreach(var ccoin in coin)
            {
                if (ccoin.Bounds.IntersectsWith(car.Bounds) == true)
                {
                    Random r = new Random();
                    ccoin.Location = new Point(r.Next(0, 400), 0);
                    return true;
                }
            }
            return false;
        }
    }
}
