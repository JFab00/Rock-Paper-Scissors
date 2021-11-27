namespace WindowsFormsClient
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lbBenvenuto = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGetMatch = new System.Windows.Forms.Button();
            this.minimiseGame = new System.Windows.Forms.Button();
            this.closeGame = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.timerSearching = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBenvenuto
            // 
            resources.ApplyResources(this.lbBenvenuto, "lbBenvenuto");
            this.lbBenvenuto.ForeColor = System.Drawing.Color.White;
            this.lbBenvenuto.Name = "lbBenvenuto";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGetMatch
            // 
            this.btnGetMatch.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnGetMatch, "btnGetMatch");
            this.btnGetMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnGetMatch.Name = "btnGetMatch";
            this.btnGetMatch.UseVisualStyleBackColor = false;
            this.btnGetMatch.Click += new System.EventHandler(this.btnGetMatch_Click);
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
            // lbStatus
            // 
            resources.ApplyResources(this.lbStatus, "lbStatus");
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Name = "lbStatus";
            // 
            // timerSearching
            // 
            this.timerSearching.Tick += new System.EventHandler(this.timerSearching_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsClient.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btStats
            // 
            this.btStats.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btStats, "btStats");
            this.btStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btStats.Name = "btStats";
            this.btStats.UseVisualStyleBackColor = false;
            this.btStats.Click += new System.EventHandler(this.btStats_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.minimiseGame);
            this.Controls.Add(this.closeGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btStats);
            this.Controls.Add(this.btnGetMatch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbBenvenuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPartita_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPartita_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBenvenuto;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGetMatch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimiseGame;
        private System.Windows.Forms.Button closeGame;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Timer timerSearching;
        private System.Windows.Forms.Button btStats;
    }
}