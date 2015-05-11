using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinionWorld
{
    public class Score
    {
        System.Drawing.Font Font = new System.Drawing.Font("Arial", 20, FontStyle.Italic);
        public float X { get; set; }
        public float Y { get; set; }      
        public static int Lives { get; set; } //static za da moze da pristapi klasata banana
        public int ChangeLevel { get; set; } //kopija na promenlivata Value, za da moze da pristapi glavnata klasa
        public int LivesLeft { get; set; } // kopija na promenlivata Lives, za da moze da pristapi glavnata klasa
        public static int Value { get; set; } //static za da moze da pristapi klasata banana
        public string Text { get; set; }
        public int Level { get; set; }

        public Score(float x, float y, int value)
        {
            X = x;
            Y = y;
           
            Value = value;
            Text = " /10  ";
            Lives = 5;
            Level = 1;
        }

        //iscrtuvanje na tekstualniot del od grafikata
        public void ShowScore(Graphics g)
        {
            g.DrawString(Value.ToString() + Text , Font, new SolidBrush(Color.Black), X, Y);
            g.DrawString(Lives.ToString(), Font, new SolidBrush(Color.Black), X, Y+50);
            g.DrawString("Level " + Level.ToString(), Font, new SolidBrush(Color.Black), 10, 20);

            
            ChangeLevel = Value;
            LivesLeft = Lives;
        }
    }
}
