using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_CARO_GAME
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            progressBar.Value = 0;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value.ToString() + "%";
            if(progressBar.Value==100)
            {
                timer1.Enabled = false;
                this.Hide();
                GUI_OPENGAME gui = new GUI_OPENGAME();
                gui.ShowDialog();
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lbLoading.Text == "LOADING")
            {
                lbLoading.Text = "LOADING.";
            }
            else if (lbLoading.Text == "LOADING.")
            {
                lbLoading.Text = "LOADING..";
            }
            else if (lbLoading.Text == "LOADING..")
            {
                lbLoading.Text = "LOADING...";
            }
            else if (lbLoading.Text == "LOADING...")
            {
                lbLoading.Text = "LOADING";
            }
        }
    }
}
