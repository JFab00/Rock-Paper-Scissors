namespace WindowsFormsClient
{
    partial class FormStats
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbRegDate = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbTotM = new System.Windows.Forms.Label();
            this.lbWins = new System.Windows.Forms.Label();
            this.lbLoses = new System.Windows.Forms.Label();
            this.closeGame = new System.Windows.Forms.Button();
            this.lbWinPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsClient.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(20, 117);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(118, 19);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name: Loading...";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(19, 154);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(136, 19);
            this.lbSurname.TabIndex = 2;
            this.lbSurname.Text = "Surname: Loading...";
            // 
            // lbRegDate
            // 
            this.lbRegDate.AutoSize = true;
            this.lbRegDate.Location = new System.Drawing.Point(20, 189);
            this.lbRegDate.Name = "lbRegDate";
            this.lbRegDate.Size = new System.Drawing.Size(194, 19);
            this.lbRegDate.TabIndex = 3;
            this.lbRegDate.Text = "Registration Date: Loading...";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbUsername.Location = new System.Drawing.Point(85, 38);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(107, 25);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Loading...";
            // 
            // lbTotM
            // 
            this.lbTotM.AutoSize = true;
            this.lbTotM.Location = new System.Drawing.Point(20, 222);
            this.lbTotM.Name = "lbTotM";
            this.lbTotM.Size = new System.Drawing.Size(172, 19);
            this.lbTotM.TabIndex = 5;
            this.lbTotM.Text = "Total Matches: Loading...";
            // 
            // lbWins
            // 
            this.lbWins.AutoSize = true;
            this.lbWins.Location = new System.Drawing.Point(21, 257);
            this.lbWins.Name = "lbWins";
            this.lbWins.Size = new System.Drawing.Size(113, 19);
            this.lbWins.TabIndex = 6;
            this.lbWins.Text = "Wins: Loading...";
            // 
            // lbLoses
            // 
            this.lbLoses.AutoSize = true;
            this.lbLoses.Location = new System.Drawing.Point(21, 290);
            this.lbLoses.Name = "lbLoses";
            this.lbLoses.Size = new System.Drawing.Size(117, 19);
            this.lbLoses.TabIndex = 7;
            this.lbLoses.Text = "Loses: Loading...";
            // 
            // closeGame
            // 
            this.closeGame.CausesValidation = false;
            this.closeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeGame.FlatAppearance.BorderSize = 0;
            this.closeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeGame.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.closeGame.ForeColor = System.Drawing.Color.White;
            this.closeGame.Location = new System.Drawing.Point(248, 5);
            this.closeGame.Name = "closeGame";
            this.closeGame.Size = new System.Drawing.Size(44, 44);
            this.closeGame.TabIndex = 9;
            this.closeGame.Text = "x";
            this.closeGame.UseVisualStyleBackColor = true;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            // 
            // lbWinPercentage
            // 
            this.lbWinPercentage.AutoSize = true;
            this.lbWinPercentage.Location = new System.Drawing.Point(23, 327);
            this.lbWinPercentage.Name = "lbWinPercentage";
            this.lbWinPercentage.Size = new System.Drawing.Size(183, 19);
            this.lbWinPercentage.TabIndex = 10;
            this.lbWinPercentage.Text = "Win Percentage: Loading...";
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(304, 456);
            this.Controls.Add(this.lbWinPercentage);
            this.Controls.Add(this.closeGame);
            this.Controls.Add(this.lbLoses);
            this.Controls.Add(this.lbWins);
            this.Controls.Add(this.lbTotM);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbRegDate);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStats";
            this.Text = "FormStats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbRegDate;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbTotM;
        private System.Windows.Forms.Label lbWins;
        private System.Windows.Forms.Label lbLoses;
        private System.Windows.Forms.Button closeGame;
        private System.Windows.Forms.Label lbWinPercentage;
    }
}