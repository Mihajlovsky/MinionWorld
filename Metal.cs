using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinionWorld
{
    public class Metal
    {
        Bitmap metal;

        public float X { get; set; }
        public float Y { get; set; }
        public static float Speed { get; set; }

        public Metal(float x, float y)
        {
            X = x;
            Y = y;
            metal = new Bitmap(MinionWorld.Properties.Resources.Metal);
            Speed = 8;
        }

        public void Draw(Graphics g)
        {

            if (metal != null)
            {
                g.DrawImage(metal, X, Y);

            }
        }

        //iscrtuvanje na metalot
        public void Move(float MonkeyX, float MonkeyY)
        {
            //dokolku metalot dojde vo kontakt so pozicijata na minionot
            if (Y > MonkeyY - 20 && Y < MonkeyY + 90 && X > MonkeyX-20 && X < MonkeyX + 80)
            {
                metal = null;
                
                X = 0;
                Y = 0;
                Score.Lives--;

            }

            else
            {
                Y += Speed; // brzina na paganjeto na metalot
            }
        }
    }
}
