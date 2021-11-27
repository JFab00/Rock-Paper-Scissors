namespace WindowsFormsClient
{
    partial class Login
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelU = new System.Windows.Forms.Panel();
            this.panelP = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.closeGame = new System.Windows.Forms.Button();
            this.minimiseGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.marti = new System.Windows.Forms.Label();
            this.ilru = new System.Windows.Forms.Label();
            this.gio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.White;
            this.tbUser.Location = new System.Drawing.Point(99, 268);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(224, 23);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "USERNAME";
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnLogin.Location = new System.Drawing.Point(111, 428);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 65);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(132, 382);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 26);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "See password.";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelU
            // 
            this.panelU.BackColor = System.Drawing.Color.White;
            this.panelU.Location = new System.Drawing.Point(64, 297);
            this.panelU.Name = "panelU";
            this.panelU.Size = new System.Drawing.Size(263, 1);
            this.panelU.TabIndex = 10;
            // 
            // panelP
            // 
            this.panelP.BackColor = System.Drawing.Color.White;
            this.panelP.Location = new System.Drawing.Point(60, 366);
            this.panelP.Name = "panelP";
            this.panelP.Size = new System.Drawing.Size(263, 1);
            this.panelP.TabIndex = 11;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.White;
            this.tbPass.Location = new System.Drawing.Point(99, 334);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(224, 23);
            this.tbPass.TabIndex = 2;
            this.tbPass.Text = "PASSWORD";
            this.tbPass.Enter += new System.EventHandler(this.tbPass_Enter);
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            // 
            // closeGame
            // 
            this.closeGame.CausesValidation = false;
            this.closeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeGame.FlatAppearance.BorderSize = 0;
            this.closeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeGame.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.closeGame.ForeColor = System.Drawing.Color.White;
            this.closeGame.Location = new System.Drawing.Point(344, 12);
            this.closeGame.Name = "closeGame";
            this.closeGame.Size = new System.Drawing.Size(44, 44);
            this.closeGame.TabIndex = 8;
            this.closeGame.Text = "x";
            this.closeGame.UseVisualStyleBackColor = true;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            // 
            // minimiseGame
            // 
            this.minimiseGame.CausesValidation = false;
            this.minimiseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimiseGame.FlatAppearance.BorderSize = 0;
            this.minimiseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseGame.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiseGame.ForeColor = System.Drawing.Color.White;
            this.minimiseGame.Location = new System.Drawing.Point(294, 12);
            this.minimiseGame.Name = "minimiseGame";
            this.minimiseGame.Size = new System.Drawing.Size(44, 44);
            this.minimiseGame.TabIndex = 0;
            this.minimiseGame.Text = "_";
            this.minimiseGame.UseVisualStyleBackColor = true;
            this.minimiseGame.Click += new System.EventHandler(this.minimiseGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "powered by";
            // 
            // marti
            // 
            this.marti.AutoSize = true;
            this.marti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marti.ForeColor = System.Drawing.Color.White;
            this.marti.Location = new System.Drawing.Point(168, 559);
            this.marti.Name = "marti";
            this.marti.Size = new System.Drawing.Size(62, 13);
            this.marti.TabIndex = 6;
            this.marti.Text = "marti0198";
            this.marti.Click += new System.EventHandler(this.marti_Click);
            // 
            // ilru
            // 
            this.ilru.AutoSize = true;
            this.ilru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilru.ForeColor = System.Drawing.Color.White;
            this.ilru.Location = new System.Drawing.Point(131, 559);
            this.ilru.Name = "ilru";
            this.ilru.Size = new System.Drawing.Size(40, 13);
            this.ilru.TabIndex = 5;
            this.ilru.Text = "ILRU-";
            this.ilru.Click += new System.EventHandler(this.ilru_Click);
            // 
            // gio
            // 
            this.gio.AutoSize = true;
            this.gio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gio.ForeColor = System.Drawing.Color.White;
            this.gio.Location = new System.Drawing.Point(249, 559);
            this.gio.Name = "gio";
            this.gio.Size = new System.Drawing.Size(59, 13);
            this.gio.TabIndex = 7;
            this.gio.Text = "suacorno";
            this.gio.Click += new System.EventHandler(this.gio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "and";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(124, 238);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 18);
            this.lbError.TabIndex = 15;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.Font = new System.Drawing.Font("Arial", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.Color.White;
            this.lbRegister.Location = new System.Drawing.Point(153, 514);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(84, 21);
            this.lbRegister.TabIndex = 16;
            this.lbRegister.Text = "Register";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // pbPass
            // 
            this.pbPass.Image = global::WindowsFormsClient.Properties.Resources.pass;
            this.pbPass.Location = new System.Drawing.Point(64, 331);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(30, 29);
            this.pbPass.TabIndex = 9;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::WindowsFormsClient.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(64, 265);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(30, 30);
            this.pbUser.TabIndex = 8;
            this.pbUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsClient.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(111, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.marti);
            this.Controls.Add(this.ilru);
            this.Controls.Add(this.gio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimiseGame);
            this.Controls.Add(this.closeGame);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.panelP);
            this.Controls.Add(this.panelU);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS | Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.Panel panelU;
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button closeGame;
        private System.Windows.Forms.Button minimiseGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label marti;
        private System.Windows.Forms.Label ilru;
        private System.Windows.Forms.Label gio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbRegister;
    }
}

