using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    internal class Enemy
    {
        private List<PictureBox> enemy = new List<PictureBox>();
        internal List<PictureBox> allEnemys
        {
            get
            {
                return enemy;
            }
        }

        internal Enemy(params PictureBox[] enemys)
        {
            foreach(var eenemy in enemys)
            {
                enemy.Add(eenemy);
            }
        }

        internal bool CheckWereBoundsTouched(Car car)
        {
            foreach (var eenemy in enemy)
            {
                if (eenemy.Bounds.IntersectsWith(car.Bounds) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
