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
    public partial class GUI_OPENGAME : Form
    {
        public GUI_OPENGAME()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new LOGIN();
            login.ShowDialog();
            this.Close();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form register = new REGISTER();
            register.ShowDialog();
            this.Close();
        }

        private void btGuide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form guide = new GUIDE();
            guide.ShowDialog();
            this.Close();
        }

        private void GUI_OPENGAME_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        public int x = 10;
        public int y = -10;
        public int z = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbX.Left += x;
            lbO.Left += y;
            lbWelcom.Left += x;
            if(lbX.Left>=400||lbX.Left<=25)
            {
               
                if(lbX.Text == "X")
                {
                    rbt1.BackColor = Color.MediumOrchid;
                    rbt2.BackColor = Color.MediumAquamarine;
                    lbX.Text = "O";
                }    
                else
                {
                    rbt1.BackColor = Color.MediumSlateBlue;
                    rbt2.BackColor = Color.MediumSlateBlue;
                    lbX.Text = "X";
                }    
                x = -x;
            }
            if (lbO.Left <= 25 || lbO.Left >= 405)
            {
                if(lbO.Text == "O")
                {
                    lbO.Text = "X";
                }
                else
                {
                    lbO.Text = "O";
                } 
                    
                y = -y;
            }
            if(lbWelcom.Left>=400|| lbWelcom.Left<=25)
            {
                z = -z;
            }    
        }
    }
}
