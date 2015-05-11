using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MinionWorld
{
    public class Minion
    {
        public Bitmap minionImage;

        public float X { get; set; }
        public float Y { get; set; }

        public Minion(float x, float y)
        {
            X = x;
            Y = y;
            minionImage = new Bitmap(MinionWorld.Properties.Resources.Minion_Front);
        }

        //metod za iscrtuvanje na Minionot
        public void Draw(Graphics g)
        {
            g.DrawImage(minionImage, X, Y);
        }
    }
}
