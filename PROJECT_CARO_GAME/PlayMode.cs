using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_CARO_GAME
{
    public partial class PlayMode : Form
    {
        public PlayMode()
        {
            InitializeComponent();
        }

        public PlayMode(string name) : this()
        {
            btUser.Text = name;
        }

        private void btPlayWithComputer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form playwithcomputer_sizechessboard = new PlayWithComputer_ChooseSizeChessBoard(btUser.Text);
            playwithcomputer_sizechessboard.ShowDialog();
        }

        private void btPlayWithPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form playwithplayer = new PlayWithPlayer(btUser.Text);
            playwithplayer.ShowDialog();
            
        }

        private void PlayMode_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            rbtRecordPC.Hide();
            rbtRecordPlayer.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rbtRecordPC.Show();
            rbtRecordPlayer.Show();
            try
            {
                DataSet ds = new DataSet();
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");
                connect.Open();
                string select = "SELECT * FROM tbUser WHERE Name = '" + btUser.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, connect);

                DataTable mytable = new DataTable();
                adapter.Fill(mytable);
                if (mytable.Rows[0]["Record-PC"].ToString() == null)
                {
                    rbtRecordPC.Text = "You have no record with PC!";
                }
                else
                {
                    rbtRecordPC.Text = "Record with PC: " + mytable.Rows[0]["Record-PC"].ToString();
                }
                if (mytable.Rows[0]["Record-Player"].ToString() == null)
                {
                    rbtRecordPlayer.Text = "You have no record with Player!";
                }
                else
                {
                    rbtRecordPlayer.Text = "Record with Player: " + mytable.Rows[0]["Record-Player"].ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You can't see your records!");
            }
        }

        //Hàm tạo màu sắc động
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel1.BackColor==Color.Red)
            {
                panel1.BackColor = Color.RoyalBlue;
            }
            else
            {
                panel1.BackColor = Color.Red;
            }

            if (panel2.BackColor == Color.RoyalBlue)
            {
                panel2.BackColor = Color.Red;
            }
            else
            {
                panel2.BackColor = Color.RoyalBlue;
            }
            if(rbtRecordPC.BackColor==Color.Red && rbtRecordPC.BorderColor==Color.Maroon)
            {
                rbtRecordPC.BackColor = Color.RoyalBlue;
                rbtRecordPC.BorderColor = Color.MediumBlue;
            }
            else
            {
                rbtRecordPC.BackColor = Color.Red;
                rbtRecordPC.BorderColor = Color.Maroon;
            }
            if (rbtRecordPlayer.BackColor == Color.RoyalBlue && rbtRecordPlayer.BorderColor == Color.MediumBlue)
            {
                rbtRecordPlayer.BackColor = Color.Red;
                rbtRecordPlayer.BorderColor = Color.Maroon;
            }
            else
            {
                rbtRecordPlayer.BackColor = Color.RoyalBlue;
                rbtRecordPlayer.BorderColor = Color.MediumBlue;
            }    
        }
    }
}
