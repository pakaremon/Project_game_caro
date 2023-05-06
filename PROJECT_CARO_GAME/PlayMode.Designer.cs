
namespace PROJECT_CARO_GAME
{
    partial class PlayMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMode));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPlayWithComputer = new CustomButton.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btPlayWithPlayer = new CustomButton.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rbtRecordPlayer = new CustomButton.RJButton();
            this.rbtRecordPC = new CustomButton.RJButton();
            this.btUser = new CustomButton.RJButton();
            this.rjButton3 = new CustomButton.RJButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btPlayWithComputer);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 462);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT_CARO_GAME.Properties.Resources.PlayWithComputer;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btPlayWithComputer
            // 
            this.btPlayWithComputer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPlayWithComputer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPlayWithComputer.BorderColor = System.Drawing.Color.Black;
            this.btPlayWithComputer.BorderRadius = 20;
            this.btPlayWithComputer.BorderSize = 2;
            this.btPlayWithComputer.FlatAppearance.BorderSize = 0;
            this.btPlayWithComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlayWithComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayWithComputer.ForeColor = System.Drawing.Color.Black;
            this.btPlayWithComputer.Location = new System.Drawing.Point(63, 364);
            this.btPlayWithComputer.Name = "btPlayWithComputer";
            this.btPlayWithComputer.Size = new System.Drawing.Size(233, 70);
            this.btPlayWithComputer.TabIndex = 0;
            this.btPlayWithComputer.Text = "PLAY WITH\r\nCOMPUTER";
            this.btPlayWithComputer.TextColor = System.Drawing.Color.Black;
            this.btPlayWithComputer.UseVisualStyleBackColor = false;
            this.btPlayWithComputer.Click += new System.EventHandler(this.btPlayWithComputer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btPlayWithPlayer);
            this.panel2.Location = new System.Drawing.Point(564, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 462);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROJECT_CARO_GAME.Properties.Resources.PlayWithPlayer;
            this.pictureBox2.Location = new System.Drawing.Point(11, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(342, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btPlayWithPlayer
            // 
            this.btPlayWithPlayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPlayWithPlayer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPlayWithPlayer.BorderColor = System.Drawing.Color.Black;
            this.btPlayWithPlayer.BorderRadius = 20;
            this.btPlayWithPlayer.BorderSize = 2;
            this.btPlayWithPlayer.FlatAppearance.BorderSize = 0;
            this.btPlayWithPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlayWithPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayWithPlayer.ForeColor = System.Drawing.Color.Black;
            this.btPlayWithPlayer.Location = new System.Drawing.Point(72, 364);
            this.btPlayWithPlayer.Name = "btPlayWithPlayer";
            this.btPlayWithPlayer.Size = new System.Drawing.Size(233, 70);
            this.btPlayWithPlayer.TabIndex = 1;
            this.btPlayWithPlayer.Text = "PLAY WITH\r\nPLAYER";
            this.btPlayWithPlayer.TextColor = System.Drawing.Color.Black;
            this.btPlayWithPlayer.UseVisualStyleBackColor = false;
            this.btPlayWithPlayer.Click += new System.EventHandler(this.btPlayWithPlayer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.rbtRecordPlayer);
            this.panel3.Controls.Add(this.rbtRecordPC);
            this.panel3.Controls.Add(this.btUser);
            this.panel3.Location = new System.Drawing.Point(364, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 462);
            this.panel3.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(11, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "See your record?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rbtRecordPlayer
            // 
            this.rbtRecordPlayer.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbtRecordPlayer.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rbtRecordPlayer.BorderColor = System.Drawing.Color.MediumBlue;
            this.rbtRecordPlayer.BorderRadius = 20;
            this.rbtRecordPlayer.BorderSize = 5;
            this.rbtRecordPlayer.FlatAppearance.BorderSize = 0;
            this.rbtRecordPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtRecordPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRecordPlayer.ForeColor = System.Drawing.Color.White;
            this.rbtRecordPlayer.Location = new System.Drawing.Point(0, 195);
            this.rbtRecordPlayer.Name = "rbtRecordPlayer";
            this.rbtRecordPlayer.Size = new System.Drawing.Size(193, 66);
            this.rbtRecordPlayer.TabIndex = 10;
            this.rbtRecordPlayer.TextColor = System.Drawing.Color.White;
            this.rbtRecordPlayer.UseVisualStyleBackColor = false;
            // 
            // rbtRecordPC
            // 
            this.rbtRecordPC.BackColor = System.Drawing.Color.Red;
            this.rbtRecordPC.BackgroundColor = System.Drawing.Color.Red;
            this.rbtRecordPC.BorderColor = System.Drawing.Color.Maroon;
            this.rbtRecordPC.BorderRadius = 20;
            this.rbtRecordPC.BorderSize = 5;
            this.rbtRecordPC.FlatAppearance.BorderSize = 0;
            this.rbtRecordPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtRecordPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRecordPC.ForeColor = System.Drawing.Color.White;
            this.rbtRecordPC.Location = new System.Drawing.Point(-1, 123);
            this.rbtRecordPC.Name = "rbtRecordPC";
            this.rbtRecordPC.Size = new System.Drawing.Size(193, 66);
            this.rbtRecordPC.TabIndex = 9;
            this.rbtRecordPC.TextColor = System.Drawing.Color.White;
            this.rbtRecordPC.UseVisualStyleBackColor = false;
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.Color.Orange;
            this.btUser.BackgroundColor = System.Drawing.Color.Orange;
            this.btUser.BorderColor = System.Drawing.Color.Black;
            this.btUser.BorderRadius = 10;
            this.btUser.BorderSize = 2;
            this.btUser.FlatAppearance.BorderSize = 0;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.White;
            this.btUser.Location = new System.Drawing.Point(-1, 3);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(194, 40);
            this.btUser.TabIndex = 5;
            this.btUser.Text = "User: ";
            this.btUser.TextColor = System.Drawing.Color.White;
            this.btUser.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.DarkOrchid;
            this.rjButton3.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.rjButton3.BorderColor = System.Drawing.Color.Black;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 5;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(12, 471);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(904, 162);
            this.rjButton3.TabIndex = 4;
            this.rjButton3.Text = "CHOOSE    PLAY    MODE";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayMode";
            this.Load += new System.EventHandler(this.PlayMode_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton.RJButton btPlayWithComputer;
        private CustomButton.RJButton btPlayWithPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomButton.RJButton rjButton3;
        private CustomButton.RJButton btUser;
        private CustomButton.RJButton rbtRecordPC;
        private System.Windows.Forms.Panel panel3;
        private CustomButton.RJButton rbtRecordPlayer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}