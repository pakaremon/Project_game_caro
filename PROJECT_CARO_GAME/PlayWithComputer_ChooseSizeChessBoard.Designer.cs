
namespace PROJECT_CARO_GAME
{
    partial class PlayWithComputer_ChooseSizeChessBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayWithComputer_ChooseSizeChessBoard));
            this.cbbSizeChessBoard = new System.Windows.Forms.ComboBox();
            this.rbtName = new CustomButton.RJButton();
            this.rjButton1 = new CustomButton.RJButton();
            this.btConfirm = new CustomButton.RJButton();
            this.SuspendLayout();
            // 
            // cbbSizeChessBoard
            // 
            this.cbbSizeChessBoard.FormattingEnabled = true;
            this.cbbSizeChessBoard.Items.AddRange(new object[] {
            "20",
            "15",
            "10"});
            this.cbbSizeChessBoard.Location = new System.Drawing.Point(30, 191);
            this.cbbSizeChessBoard.Name = "cbbSizeChessBoard";
            this.cbbSizeChessBoard.Size = new System.Drawing.Size(460, 24);
            this.cbbSizeChessBoard.TabIndex = 0;
            // 
            // rbtName
            // 
            this.rbtName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rbtName.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rbtName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtName.BorderRadius = 20;
            this.rbtName.BorderSize = 0;
            this.rbtName.FlatAppearance.BorderSize = 0;
            this.rbtName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtName.ForeColor = System.Drawing.Color.White;
            this.rbtName.Location = new System.Drawing.Point(183, 105);
            this.rbtName.Name = "rbtName";
            this.rbtName.Size = new System.Drawing.Size(150, 42);
            this.rbtName.TabIndex = 3;
            this.rbtName.TextColor = System.Drawing.Color.White;
            this.rbtName.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(30, 12);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(460, 87);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "CHOOSE THE SIZE  OF CHESSBOARD!";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btConfirm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btConfirm.BorderRadius = 10;
            this.btConfirm.BorderSize = 0;
            this.btConfirm.FlatAppearance.BorderSize = 0;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.Location = new System.Drawing.Point(200, 245);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(113, 40);
            this.btConfirm.TabIndex = 1;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.TextColor = System.Drawing.Color.White;
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // PlayWithComputer_ChooseSizeChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 297);
            this.Controls.Add(this.rbtName);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.cbbSizeChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayWithComputer_ChooseSizeChessBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayWithComputer_ChooseSizeChessBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSizeChessBoard;
        private CustomButton.RJButton btConfirm;
        private CustomButton.RJButton rjButton1;
        private CustomButton.RJButton rbtName;
    }
}