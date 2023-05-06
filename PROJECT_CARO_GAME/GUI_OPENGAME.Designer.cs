
namespace PROJECT_CARO_GAME
{
    partial class GUI_OPENGAME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_OPENGAME));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbO = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.rbt2 = new CustomButton.RJButton();
            this.lbWelcom = new System.Windows.Forms.Label();
            this.rbt1 = new CustomButton.RJButton();
            this.btGuide = new CustomButton.RJButton();
            this.btRegister = new CustomButton.RJButton();
            this.btLogin = new CustomButton.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton1 = new CustomButton.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT_CARO_GAME.Properties.Resources.Caro_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lbO);
            this.panel1.Controls.Add(this.lbX);
            this.panel1.Controls.Add(this.rbt2);
            this.panel1.Controls.Add(this.lbWelcom);
            this.panel1.Controls.Add(this.rbt1);
            this.panel1.Controls.Add(this.btGuide);
            this.panel1.Controls.Add(this.btRegister);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Location = new System.Drawing.Point(531, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 578);
            this.panel1.TabIndex = 1;
            // 
            // lbO
            // 
            this.lbO.AutoSize = true;
            this.lbO.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lbO.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbO.ForeColor = System.Drawing.Color.Orange;
            this.lbO.Location = new System.Drawing.Point(547, 476);
            this.lbO.Name = "lbO";
            this.lbO.Size = new System.Drawing.Size(52, 46);
            this.lbO.TabIndex = 7;
            this.lbO.Text = "O";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbX.Location = new System.Drawing.Point(25, 523);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(48, 46);
            this.lbX.TabIndex = 6;
            this.lbX.Text = "X";
            // 
            // rbt2
            // 
            this.rbt2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbt2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbt2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbt2.BorderRadius = 20;
            this.rbt2.BorderSize = 0;
            this.rbt2.FlatAppearance.BorderSize = 0;
            this.rbt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbt2.ForeColor = System.Drawing.Color.White;
            this.rbt2.Location = new System.Drawing.Point(604, 287);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(42, 418);
            this.rbt2.TabIndex = 5;
            this.rbt2.TextColor = System.Drawing.Color.White;
            this.rbt2.UseVisualStyleBackColor = false;
            // 
            // lbWelcom
            // 
            this.lbWelcom.AutoSize = true;
            this.lbWelcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcom.ForeColor = System.Drawing.Color.White;
            this.lbWelcom.Location = new System.Drawing.Point(-241, 18);
            this.lbWelcom.Name = "lbWelcom";
            this.lbWelcom.Size = new System.Drawing.Size(557, 38);
            this.lbWelcom.TabIndex = 0;
            this.lbWelcom.Text = "WELCOM TO OUR GAME CARO  ";
            // 
            // rbt1
            // 
            this.rbt1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbt1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbt1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbt1.BorderRadius = 20;
            this.rbt1.BorderSize = 0;
            this.rbt1.FlatAppearance.BorderSize = 0;
            this.rbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbt1.ForeColor = System.Drawing.Color.White;
            this.rbt1.Location = new System.Drawing.Point(-17, 192);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(38, 397);
            this.rbt1.TabIndex = 4;
            this.rbt1.TextColor = System.Drawing.Color.White;
            this.rbt1.UseVisualStyleBackColor = false;
            // 
            // btGuide
            // 
            this.btGuide.BackColor = System.Drawing.Color.DeepPink;
            this.btGuide.BackgroundColor = System.Drawing.Color.DeepPink;
            this.btGuide.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btGuide.BorderRadius = 20;
            this.btGuide.BorderSize = 4;
            this.btGuide.FlatAppearance.BorderSize = 0;
            this.btGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuide.ForeColor = System.Drawing.Color.White;
            this.btGuide.Location = new System.Drawing.Point(170, 391);
            this.btGuide.Name = "btGuide";
            this.btGuide.Size = new System.Drawing.Size(275, 77);
            this.btGuide.TabIndex = 3;
            this.btGuide.Text = "GUIDE";
            this.btGuide.TextColor = System.Drawing.Color.White;
            this.btGuide.UseVisualStyleBackColor = false;
            this.btGuide.Click += new System.EventHandler(this.btGuide_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Violet;
            this.btRegister.BackgroundColor = System.Drawing.Color.Violet;
            this.btRegister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btRegister.BorderRadius = 20;
            this.btRegister.BorderSize = 4;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.White;
            this.btRegister.Location = new System.Drawing.Point(170, 246);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(275, 77);
            this.btRegister.TabIndex = 2;
            this.btRegister.Text = "REGISTER";
            this.btRegister.TextColor = System.Drawing.Color.White;
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btLogin.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btLogin.BorderRadius = 20;
            this.btLogin.BorderSize = 4;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(170, 106);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(275, 77);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "LOGIN";
            this.btLogin.TextColor = System.Drawing.Color.White;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 117);
            this.panel2.TabIndex = 2;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Orchid;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Orchid;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(90, 55);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(294, 15);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "GAME CARO";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GUI_OPENGAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImage = global::PROJECT_CARO_GAME.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_OPENGAME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPEN GAME";
            this.Load += new System.EventHandler(this.GUI_OPENGAME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private CustomButton.RJButton btGuide;
        private CustomButton.RJButton btRegister;
        private CustomButton.RJButton btLogin;
        private System.Windows.Forms.Label lbWelcom;
        private System.Windows.Forms.Panel panel2;
        private CustomButton.RJButton rjButton1;
        private System.Windows.Forms.Label label2;
        private CustomButton.RJButton rbt2;
        private CustomButton.RJButton rbt1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbO;
        private System.Windows.Forms.Label lbX;
    }
}

