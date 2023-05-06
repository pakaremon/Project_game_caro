
namespace PROJECT_CARO_GAME
{
    partial class GUIDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIDE));
            this.label1 = new System.Windows.Forms.Label();
            this.rtbGuide = new System.Windows.Forms.RichTextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUIDE";
            // 
            // rtbGuide
            // 
            this.rtbGuide.BackColor = System.Drawing.Color.White;
            this.rtbGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGuide.Location = new System.Drawing.Point(69, 77);
            this.rtbGuide.Name = "rtbGuide";
            this.rtbGuide.ReadOnly = true;
            this.rtbGuide.Size = new System.Drawing.Size(668, 341);
            this.rtbGuide.TabIndex = 1;
            this.rtbGuide.Text = resources.GetString("rtbGuide.Text");
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btConfirm.FlatAppearance.BorderSize = 2;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(342, 440);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(107, 47);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // GUIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.rtbGuide);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUIDE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUIDE_FormClosed);
            this.Load += new System.EventHandler(this.GUIDE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbGuide;
        private System.Windows.Forms.Button btConfirm;
    }
}