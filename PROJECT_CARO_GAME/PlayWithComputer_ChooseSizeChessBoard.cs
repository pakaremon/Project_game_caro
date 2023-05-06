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
    public partial class PlayWithComputer_ChooseSizeChessBoard : Form
    {
        public PlayWithComputer_ChooseSizeChessBoard()
        {
            InitializeComponent();
        }

        public PlayWithComputer_ChooseSizeChessBoard(string name):this()
        {
            rbtName.Text = name;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (cbbSizeChessBoard.SelectedItem==null)
            {
                if(cbbSizeChessBoard.Text=="")
                {
                    MessageBox.Show("Please choose the size of the board chess which is supported to begin the game with computer!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }   
                else if(cbbSizeChessBoard.Text=="20")
                {
                    this.Hide();
                    Form playwithcomputer = new PlayWithComputer(rbtName.Text);
                    playwithcomputer.ShowDialog();
                }
                else if (cbbSizeChessBoard.Text == "15")
                {
                    this.Hide();
                    Form playwithcomputer = new PlayWithComputer15x15(rbtName.Text);
                    playwithcomputer.ShowDialog();
                }
                else if (cbbSizeChessBoard.Text == "10")
                {
                    this.Hide();
                    Form playwithcomputer = new PlayWithComputer10x10(rbtName.Text);
                    playwithcomputer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("That size is not supported! Please choose another one...", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (cbbSizeChessBoard.SelectedItem.ToString() == "20")
                {
                    this.Hide();
                    Form playwithcomputer = new PlayWithComputer(rbtName.Text);
                    playwithcomputer.ShowDialog();
                }
                else if (cbbSizeChessBoard.SelectedItem.ToString() == "15")
                {
                    this.Hide();
                    Form playwithcomputer15x15 = new PlayWithComputer15x15(rbtName.Text);
                    playwithcomputer15x15.ShowDialog();
                }
                else if (cbbSizeChessBoard.SelectedItem.ToString() == "10")
                {
                    this.Hide();
                    Form playwithcomputer10x10 = new PlayWithComputer10x10(rbtName.Text);
                    playwithcomputer10x10.ShowDialog();
                }
            }
            
        }
    }
}
