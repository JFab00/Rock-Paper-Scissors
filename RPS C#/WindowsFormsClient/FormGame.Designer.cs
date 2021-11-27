namespace WindowsFormsClient
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.lbPunteggio = new System.Windows.Forms.Label();
            this.lbGameStatus = new System.Windows.Forms.Label();
            this.lbYou = new System.Windows.Forms.Label();
            this.lbEnemy = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerRisultato = new System.Windows.Forms.Timer(this.components);
            this.minimiseGame = new System.Windows.Forms.Button();
            this.closeGame = new System.Windows.Forms.Button();
            this.btForbici = new System.Windows.Forms.Button();
            this.btCarta = new System.Windows.Forms.Button();
            this.btSasso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPunteggio
            // 
            resources.ApplyResources(this.lbPunteggio, "lbPunteggio");
            this.lbPunteggio.Name = "lbPunteggio";
            // 
            // lbGameStatus
            // 
            resources.ApplyResources(this.lbGameStatus, "lbGameStatus");
            this.lbGameStatus.Name = "lbGameStatus";
            // 
            // lbYou
            // 
            resources.ApplyResources(this.lbYou, "lbYou");
            this.lbYou.Name = "lbYou";
            // 
            // lbEnemy
            // 
            resources.ApplyResources(this.lbEnemy, "lbEnemy");
            this.lbEnemy.Name = "lbEnemy";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerRisultato
            // 
            this.timerRisultato.Interval = 5000;
            this.timerRisultato.Tick += new System.EventHandler(this.timerRisultato_Tick);
            // 
            // minimiseGame
            // 
            this.minimiseGame.CausesValidation = false;
            this.minimiseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimiseGame.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.minimiseGame, "minimiseGame");
            this.minimiseGame.ForeColor = System.Drawing.Color.White;
            this.minimiseGame.Name = "minimiseGame";
            this.minimiseGame.UseVisualStyleBackColor = true;
            this.minimiseGame.Click += new System.EventHandler(this.minimiseGame_Click);
            // 
            // closeGame
            // 
            this.closeGame.CausesValidation = false;
            this.closeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeGame.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.closeGame, "closeGame");
            this.closeGame.ForeColor = System.Drawing.Color.White;
            this.closeGame.Name = "closeGame";
            this.closeGame.UseVisualStyleBackColor = true;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            // 
            // btForbici
            // 
            this.btForbici.BackgroundImage = global::WindowsFormsClient.Properties.Resources.scissors;
            resources.ApplyResources(this.btForbici, "btForbici");
            this.btForbici.FlatAppearance.BorderSize = 0;
            this.btForbici.Name = "btForbici";
            this.btForbici.Tag = "forbici";
            this.btForbici.UseVisualStyleBackColor = true;
            this.btForbici.Click += new System.EventHandler(this.btForbici_Click);
            // 
            // btCarta
            // 
            this.btCarta.BackgroundImage = global::WindowsFormsClient.Properties.Resources.paper;
            resources.ApplyResources(this.btCarta, "btCarta");
            this.btCarta.FlatAppearance.BorderSize = 0;
            this.btCarta.Name = "btCarta";
            this.btCarta.Tag = "carta";
            this.btCarta.UseVisualStyleBackColor = true;
            this.btCarta.Click += new System.EventHandler(this.btCarta_Click);
            // 
            // btSasso
            // 
            this.btSasso.BackgroundImage = global::WindowsFormsClient.Properties.Resources.rock;
            resources.ApplyResources(this.btSasso, "btSasso");
            this.btSasso.FlatAppearance.BorderSize = 0;
            this.btSasso.Name = "btSasso";
            this.btSasso.Tag = "sasso";
            this.btSasso.UseVisualStyleBackColor = true;
            this.btSasso.Click += new System.EventHandler(this.btSasso_Click);
            // 
            // FormGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.minimiseGame);
            this.Controls.Add(this.closeGame);
            this.Controls.Add(this.lbEnemy);
            this.Controls.Add(this.lbYou);
            this.Controls.Add(this.lbGameStatus);
            this.Controls.Add(this.lbPunteggio);
            this.Controls.Add(this.btForbici);
            this.Controls.Add(this.btCarta);
            this.Controls.Add(this.btSasso);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSasso;
        private System.Windows.Forms.Button btCarta;
        private System.Windows.Forms.Button btForbici;
        private System.Windows.Forms.Label lbPunteggio;
        private System.Windows.Forms.Label lbGameStatus;
        private System.Windows.Forms.Label lbYou;
        private System.Windows.Forms.Label lbEnemy;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerRisultato;
        private System.Windows.Forms.Button minimiseGame;
        private System.Windows.Forms.Button closeGame;
    }
}