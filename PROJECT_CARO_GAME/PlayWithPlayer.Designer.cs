
namespace PROJECT_CARO_GAME
{
    partial class PlayWithPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayWithPlayer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbScoreO = new System.Windows.Forms.TextBox();
            this.tbScoreX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.NudPort = new System.Windows.Forms.NumericUpDown();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEnterMessage = new System.Windows.Forms.TextBox();
            this.lvMessage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btLanConnect = new CustomButton.RJButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbScoreO);
            this.groupBox1.Controls.Add(this.tbScoreX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // tbScoreO
            // 
            this.tbScoreO.Enabled = false;
            this.tbScoreO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreO.Location = new System.Drawing.Point(231, 55);
            this.tbScoreO.Name = "tbScoreO";
            this.tbScoreO.Size = new System.Drawing.Size(45, 30);
            this.tbScoreO.TabIndex = 4;
            this.tbScoreO.Text = "0";
            this.tbScoreO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScoreX
            // 
            this.tbScoreX.Enabled = false;
            this.tbScoreX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScoreX.Location = new System.Drawing.Point(84, 54);
            this.tbScoreX.Name = "tbScoreX";
            this.tbScoreX.Size = new System.Drawing.Size(43, 30);
            this.tbScoreX.TabIndex = 3;
            this.tbScoreX.Text = "0";
            this.tbScoreX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(153, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROJECT_CARO_GAME.Properties.Resources.o;
            this.pictureBox2.Location = new System.Drawing.Point(300, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT_CARO_GAME.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(6, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1591, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(39, 182);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(109, 22);
            this.tbIPAddress.TabIndex = 4;
            // 
            // NudPort
            // 
            this.NudPort.Location = new System.Drawing.Point(220, 181);
            this.NudPort.Name = "NudPort";
            this.NudPort.Size = new System.Drawing.Size(120, 22);
            this.NudPort.TabIndex = 5;
            this.NudPort.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(378, 33);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(760, 667);
            this.pnlChessBoard.TabIndex = 7;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            this.pnlChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChessBoard_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEnterMessage);
            this.groupBox2.Controls.Add(this.lvMessage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1144, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 666);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // tbEnterMessage
            // 
            this.tbEnterMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterMessage.Location = new System.Drawing.Point(7, 618);
            this.tbEnterMessage.Name = "tbEnterMessage";
            this.tbEnterMessage.Size = new System.Drawing.Size(368, 30);
            this.tbEnterMessage.TabIndex = 1;
            this.tbEnterMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEnterMessage_KeyPress);
            // 
            // lvMessage
            // 
            this.lvMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMessage.HideSelection = false;
            this.lvMessage.Location = new System.Drawing.Point(7, 21);
            this.lvMessage.Name = "lvMessage";
            this.lvMessage.Size = new System.Drawing.Size(368, 581);
            this.lvMessage.TabIndex = 0;
            this.lvMessage.UseCompatibleStateImageBehavior = false;
            this.lvMessage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sender";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Content";
            this.columnHeader2.Width = 258;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PROJECT_CARO_GAME.Properties.Resources.PlayWithPlayer;
            this.pictureBox3.Location = new System.Drawing.Point(12, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(354, 367);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btLanConnect
            // 
            this.btLanConnect.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btLanConnect.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btLanConnect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btLanConnect.BorderRadius = 20;
            this.btLanConnect.BorderSize = 0;
            this.btLanConnect.FlatAppearance.BorderSize = 0;
            this.btLanConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLanConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLanConnect.ForeColor = System.Drawing.Color.White;
            this.btLanConnect.Location = new System.Drawing.Point(39, 242);
            this.btLanConnect.Name = "btLanConnect";
            this.btLanConnect.Size = new System.Drawing.Size(301, 40);
            this.btLanConnect.TabIndex = 6;
            this.btLanConnect.Text = "FIGHT RIGHT NOW (LAN)";
            this.btLanConnect.TextColor = System.Drawing.Color.White;
            this.btLanConnect.UseVisualStyleBackColor = false;
            this.btLanConnect.Click += new System.EventHandler(this.btLanConnect_Click);
            // 
            // PlayWithPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 711);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.btLanConnect);
            this.Controls.Add(this.NudPort);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayWithPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayWithPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayWithPlayer_FormClosed);
            this.Load += new System.EventHandler(this.PlayWithPlayer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbScoreO;
        private System.Windows.Forms.TextBox tbScoreX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.NumericUpDown NudPort;
        private CustomButton.RJButton btLanConnect;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvMessage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbEnterMessage;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}