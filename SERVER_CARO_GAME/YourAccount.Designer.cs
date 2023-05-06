
namespace SERVER_CARO_GAME
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.gbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.dgvAccount);
            this.gbAccount.Location = new System.Drawing.Point(12, 70);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(625, 301);
            this.gbAccount.TabIndex = 0;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Account";
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeight = 40;
            this.dgvAccount.Location = new System.Drawing.Point(6, 21);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 40;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(613, 274);
            this.dgvAccount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOUR LIST OF ACCOUNTS";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(271, 378);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(113, 47);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 437);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.gbAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
    }
}

