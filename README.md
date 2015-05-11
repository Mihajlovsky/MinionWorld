Напомена: По симнување на проектот сите фајлови освен **MinionWorld.sln.ide** и **MinionWorld.sln** поставете ги во фолдерот **MinionWorld** !

#**MINION WORLD**

Играта Minion World  е игра во која играчот контролира херој (Minion) и се состои од вкупно 3 нивоа. Главна цел на играчот е да собере што повеќе банани, притoа избегнувајки ги металните објекти кои паѓаат.  Играчот има вкупно 5 животи и играта завршува доколку сите се изгубат или играчот успее да собере вкупно 60 банани.


**Инструкции за играње:**
Со притискање или држење на стрелките лево и десно , херојот се движи во посакуваната насока. 

####**ПОЧЕТНО МЕНИ** 
![Alt text](http://s27.postimg.org/z7ielj2vn/MWSplash.png "Optional title")

Почетното мени на играта е составено од повеке копчиња. Со клик на НОВА ИГРА започнува играта, со клик на ИНСТРУКЦИИ се отвара соодветна слика со инструции. Со клик на За играта се отвара кратка содржина за креаторот на играта и слично, додека со клик на ИЗЛЕЗИ завршува играта.

####**НОВА ИГРА**

![Alt text](http://s23.postimg.org/55ksutggb/New_Game.png)

Со клик на копчето Нова Игра од стартното мени се отвара главната форма на играта.  Движењето на Минионот , бананите , металот, исцртувањето на скорот  и животите се овозможени од повеке класи и тоа:

**Minion.cs**


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

Оваа класа овозможува да се ицрта херојот на позиции кои се зададени во Form1.

**Banana.cs**


        
        public void Move(float MonkeyX, float MonkeyY)
        {
            //ako pozicijata na bananata dojde vo kontakt so pozicijata na minionot
            if (Y > MonkeyY-20 && Y < MonkeyY + 90 && X > MonkeyX-20 && X < MonkeyX + 80)
            {
                
                    banana = null;

                    X = 0;
                    Y +=300; // dodaj vrednost za da bananata ne dojde na pozicija 540 so sto ke se odzeme zivot
                    Score.Value++; // dodaj poeni
                
            }

            else
            {
                Y += Speed; // brzinata na paganje na bananata
                if (Y==540) // ako pozicijata e zemjata, odzemi zivot
                {
                    banana = null;
                    Score.Lives--;
                }
            }
         }

Главната функција во оваа класа е методот за движење на бананата. Со овој код е постигнато кога бананата ке дојде во контакт со минионот кој се движи, да се зголеми скорот. Кога бананата ке падне на земјата, да се одземе живот.

**Metal.cs**


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

Слично како кај класата банана, доколку металот дојде во контакт со херојот се одзема живот.

**Metal.cs  и Bananas.cs**

Овие класи содржат листа од метал и од банани. Се движат со методот Move  и се исцртуваат со методот Draw.

####**Движење на херојот**


            if (e.KeyCode == Keys.Left)
            {
                if (minion.X > 10) // za da se spreci minionot da ne izleze od leviot del od ekranot
                {
                    minion.minionImage = new Bitmap(MinionWorld.Properties.Resources.Minion_Left);
                    minion.X -= 20; //brzina na dvizenje
                   
                }


            }

            else if (e.KeyCode == Keys.Right)
            {
                if (minion.X < 600) // da se spreci minionot da ne izleze od desniot del od ekranot
                {
                    minion.minionImage = new Bitmap(MinionWorld.Properties.Resources.Minion_Right);
                    minion.X += 20; //brzina na dvizenje na minionot
                 
                }

            }


####**Менување на левел**


        //koga ke se soberat 10 banani se menuva levelot 
                if (score.ChangeLevel == 10)
                {
                    
                    level2 = true;
                    score.Text = " /30";
                    score.Level++;
                    this.BackgroundImage = MinionWorld.Properties.Resources.Level2;
                    MetalDrop.Start();

                }

**Score.cs**

Скорот се исцртува со помош на стрингови и графика.

###*Се останато е објаснето во изворниот код.*
