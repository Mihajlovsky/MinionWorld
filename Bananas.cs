using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinionWorld
{
    public class Bananas
    {
        public List<Banana> bananas;

        public Bananas()
        {
            bananas = new List<Banana>();
        }

        public void addBanana(float x, float y)
        {
            Banana banana = new Banana(x, y);
            bananas.Add(banana);
            
        }
        
        public void NewGame()
        {
            Score.Value = 0;
        }

        
     

        //metod za iscrtuvanje na site banani
        public void Draw(Graphics g)
        {
            foreach (Banana banana in bananas)
            {
                if (banana==null)
                {
                    bananas.Remove(banana);
                }
                   banana.Draw(g); 
            }
        }

        //metod za dvizenjeto na site banani
        public void Move(float MonkeyX, float MonkeyY)
        {
            foreach (Banana banana in bananas)
            {
               
                    banana.Move(MonkeyX, MonkeyY);
                
            }
        }
    }
}
