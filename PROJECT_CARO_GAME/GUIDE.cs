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
    public partial class GUIDE : Form
    {
        public GUIDE()
        {
            InitializeComponent();
        }

        //Sự kiện Confirm
        private void btConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new GUI_OPENGAME();
            f.ShowDialog();
        }

        //Sự kiện đóng form
        private void GUIDE_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new GUI_OPENGAME();
            f.ShowDialog();
        }

        //Không cho phép phóng to
        private void GUIDE_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
