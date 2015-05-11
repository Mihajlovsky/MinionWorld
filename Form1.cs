using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinionWorld
{
    public partial class Form1 : Form
    {
        Random randomBanana;
        Random randomMetal;
        int bananaX;
        int metalX;

        
        bool NewGame = false;
        bool GameOver = false;
        
        bool level2 = false;
        bool level3 = false;
        
       
        Timer BananaDrop; //tajmer za bananite
        Timer MetalDrop; //tajmer za metalnite objekti
        Timer invalidate; //tajmer za povikuvanje na invalidate

        Minion minion;
        Score score;
        ScoreImage scoreImage;
        Bananas bananas;
        Metals metals;

        public Form1()
        {
            InitializeComponent();
            
            minion = new Minion(350, 427); //startna pozicija 
            scoreImage = new ScoreImage(520, 10); // pozicija na slikickite
            score = new Score(590, 30, 0); //pozicija na skorot

            bananas = new Bananas();
            metals = new Metals();
           

            BananaDrop = new Timer();
            BananaDrop.Tick += BananaDrop_Tick;
            BananaDrop.Interval = 1500;
            BananaDrop.Start();


            invalidate = new Timer();
            invalidate.Tick += Invalidate_Tick;
            invalidate.Interval = 1;
            invalidate.Start();

            MetalDrop = new Timer();
            MetalDrop.Tick += MetalDrop_Tick;
            MetalDrop.Interval = 3500;


            this.DoubleBuffered = true;
        }

        private void BananaDrop_Tick(object sender, EventArgs e)
        {
            //bananite ke pagaat samo koga igrata e nova
            // sp ova se sprecuva da pagaat banani dodeka sme na startnoto meni
            if (NewGame)
            {
                randomBanana = new Random();
                bananaX = randomBanana.Next(10, 500);
                bananas.addBanana(bananaX, 0);


                //koga ke se soberat 10 banani se menuva levelot 
                
                if (score.ChangeLevel == 10)
                {
                    
                    level2 = true;
                    score.Text = " /30";
                    score.Level++;
                    this.BackgroundImage = MinionWorld.Properties.Resources.Level2;
                    MetalDrop.Start();

                }

                if (score.ChangeLevel == 30) 
                {
                    
                    level2 = false;
                    level3 = true;
                    score.Text = " /60";
                    score.Level++;
                    this.BackgroundImage = MinionWorld.Properties.Resources.level3;
                  
                }

                

              
                //menuvanje na karakteristikite
                if (level2)
                {
                    Banana.Speed = 5;
                    Metal.Speed = 10;
                    BananaDrop.Interval = 2000;
                    MetalDrop.Interval = 3000;
                    
                }

                if (level3)
                {
                    Banana.Speed = 10;
                    Metal.Speed = 10;
                    BananaDrop.Interval = 2500;
                    MetalDrop.Interval = 1500;
                }

               

                //dokolku nema veke zivoti, igrata e neuspesno zavrsena
                if (score.LivesLeft <= 0)
                {
                    this.BackgroundImage = MinionWorld.Properties.Resources.GameOver;
                    ShowButtons();
                    GameOver = true;
                    score.LivesLeft = 1;
                    NewGame = false;
                    score.ChangeLevel = 0;
                    MetalDrop.Stop();
                }

                //dokolku sobereme 60 banani, igrata e uspesno zavrsena
                if (score.ChangeLevel==60)
                {
                    this.BackgroundImage = MinionWorld.Properties.Resources.YouWon;
                    ShowButtons();
                    GameOver = true;
                    score.LivesLeft = 1;
                    NewGame = false;
                    score.ChangeLevel = 0;
                    MetalDrop.Stop();
                }
            }
        
        }

        //metalot zapocnuva da pagja od random pozicija
        private void MetalDrop_Tick(object sender, EventArgs e)
        {
            randomMetal = new Random();
            metalX = randomMetal.Next(10, 500);
            metals.addMetal(metalX, 0);
        }


        //funkcijata Invalidate se povikuva na sekoja 1 milisekunda
        // so sto poefikasno se refreshira slikata i e namalen flickeringot
        private void Invalidate_Tick(object sender, EventArgs e)
        {

            bananas.Move(minion.X, minion.Y);
            metals.Move(minion.X, minion.Y);
                 
           
            Invalidate();
        }

        
        //se iscrtuva grafikata samo e nova igrata
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if ((NewGame) && (!GameOver))
            {
                minion.Draw(e.Graphics);
                bananas.Draw(e.Graphics);
                metals.Draw(e.Graphics);
                score.ShowScore(e.Graphics);
                scoreImage.Draw(e.Graphics);
            }
        }

        //metodi za dvizenje na Minionot
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //vrakanje na pocetnata pozicija koga ke se pusti nekoe kopce
            minion.minionImage = new Bitmap(MinionWorld.Properties.Resources.Minion_Front);
          
        }

       
        //krienje na site kopcinja
        private void HideButtons()
        {
            buttonNewGame.Enabled = false;            
            buttonAbout.Enabled = false;
            buttonInstructions.Enabled = false;
            buttonExit.Enabled = false;
            
            buttonNewGame.Visible = false;            
            buttonAbout.Visible = false;
            buttonExit.Visible = false;
            buttonInstructions.Visible = false;
        }

        //pokazuvanje na site kopcinja
        private void ShowButtons()
        {
            buttonNewGame.Enabled = true;            
            buttonAbout.Enabled = true;
            buttonInstructions.Enabled = true;
            buttonExit.Enabled = true;

            buttonNewGame.Visible = true;            
            buttonAbout.Visible = true;
            buttonExit.Visible = true;
            buttonInstructions.Visible = true;
        }

        //zapocnuvanje na nova igra
        //se pravat novi instanci od banani i metal vo slucaj da ne e prv pat na igranje
        //se vraka skorot na nula i slicno
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = MinionWorld.Properties.Resources.Level1;
            score = new Score(590, 30, 0); 
            bananas = new Bananas();
            metals = new Metals();
            bananas.NewGame();
            NewGame = true;
            GameOver = false;
         
            
            HideButtons();
        }

        //izleguvanje od igrata
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void buttonInstructions_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = MinionWorld.Properties.Resources.InstructionsImage;
            buttonBack.Visible = true;
            buttonBack.Enabled = true;
            HideButtons();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = MinionWorld.Properties.Resources.Splash;
            buttonBack.Visible = false;
            buttonBack.Enabled = false;
            ShowButtons();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = MinionWorld.Properties.Resources.About;
            buttonBack.Visible = true;
            buttonBack.Enabled = true;
            HideButtons();
        }
    }
}
