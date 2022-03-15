using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    internal class Car
    {
        internal PictureBox car;
        internal Rectangle Bounds
        {
            get { return car.Bounds; }
        }
        internal Car(PictureBox car)
        {
            this.car = car;
        }

        internal void MoveCarRight()
        {
            if(car.Left > 16)
            {
                car.Left += -8;
            }
        }

        internal void MoveCarLeft()
        {
            if(car.Right < 368)
            {
                car.Left += 8;
            }
        }
    }
}
