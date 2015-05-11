using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinionWorld
{
    public class ScoreImage
    {
        public Bitmap scoreImage;
        public Bitmap livesImage;

        public float X { get; set; }
        public float Y { get; set; }

        public ScoreImage(float x, float y)
        {
            X = x;
            Y = y;
            scoreImage = new Bitmap(MinionWorld.Properties.Resources.BananaScore);
            livesImage = new Bitmap(MinionWorld.Properties.Resources.LivesImage);
        }

        //metod za iscrtuvanje na slikite
        public void Draw(Graphics g)
        {
            g.DrawImage(scoreImage, X, Y);
            g.DrawImage(livesImage, X, Y+50);
        }
    }
}
