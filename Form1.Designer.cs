namespace MinionWorld
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonInstructions = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.Location = new System.Drawing.Point(314, 119);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(136, 53);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Нова Игра";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(314, 397);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(136, 53);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Излези";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Location = new System.Drawing.Point(314, 305);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(136, 53);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "За играта";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonInstructions
            // 
            this.buttonInstructions.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstructions.Location = new System.Drawing.Point(314, 210);
            this.buttonInstructions.Name = "buttonInstructions";
            this.buttonInstructions.Size = new System.Drawing.Size(136, 53);
            this.buttonInstructions.TabIndex = 3;
            this.buttonInstructions.Text = "Инструкции";
            this.buttonInstructions.UseVisualStyleBackColor = false;
            this.buttonInstructions.Click += new System.EventHandler(this.buttonInstructions_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Enabled = false;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(136, 53);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "< Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MinionWorld.Properties.Resources.Splash;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonInstructions);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.Text = "MinionWorld";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
      
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonInstructions;
        private System.Windows.Forms.Button buttonBack;
    }
}

