using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinionWorld
{
    public class Metals
    {
        public List<Metal> metals;


        public Metals()
        {
            metals = new List<Metal>();
        }

        public void addMetal(float x, float y)
        {
            Metal metal = new Metal(x, y);
            metals.Add(metal);

        }

        public void Draw(Graphics g)
        {
            foreach (Metal metal in metals)
            {
                if (metal==null)
                {
                    metals.Remove(metal);
                }
                metal.Draw(g);
            }
        }

        public void Move(float MonkeyX, float MonkeyY)
        {
            foreach (Metal metal in metals)
            {
                metal.Move(MonkeyX, MonkeyY);
            }
        }
    }
}
