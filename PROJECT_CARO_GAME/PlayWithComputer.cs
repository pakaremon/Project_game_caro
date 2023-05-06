using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Data.SqlClient;

namespace PROJECT_CARO_GAME
{
    public partial class PlayWithComputer : Form
    {
        CaroChess _CR;
        Graphics _gp;
        int scoreX = 0, scoreO = 0, myPiece = 1; //1 = cờ X, 2 = cờ O
        int gameMode = 1; //1: computer


        public PlayWithComputer()
        {
            InitializeComponent();
        }

        public PlayWithComputer(string name) : this()
        {
            lbUserName.Text = name;
        }

        private void PlayWithComputer_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            _CR = new CaroChess();
            _gp = pnlChessBoard.CreateGraphics();
        }     

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {         
            _CR._drawBoardChess(_gp);
        }

        private void pnlChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (_CR._playChess(e.Y, e.X, _gp, myPiece))
            {
                _CR.readyPlay = false;
                checkWinner();
                _CR._Computer(_gp, 2);
                if (checkWinner())
                    _CR._Computer(_gp, 2);
            }
        }

        // Chơi với máy
        private void btBeginComputer_Click(object sender, EventArgs e)
        {     
            eventNewGame(false);
            gameMode = 1;
            _CR._Computer(_gp, 2);
            btBeginComputer.Enabled = false;
        }

        //Sự kiện game mới
        private void eventNewGame(bool keepScore)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    eventNewGame(keepScore);
                });
                return;
            }
            _CR._newGames();
            pnlChessBoard.Refresh();
            if (!keepScore)
            {
                scoreX = 0; scoreO = 0;
                tbScoreX.Text = scoreX.ToString();
                tbScoreO.Text = scoreO.ToString();
            }
        }      

        //Xác định player chiến thắng
        private bool checkWinner()
        {
            int check = _CR._checkWins();
            if (check != -1)
            {
                endGames(check);
                eventNewGame(true);
                _CR.readyPlay = false;
                return true;
            }
            else
                return false;
        }

        //Thao tác Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameMode == 1)
            {
                _CR._undoPlay();
                if (_CR._undoPlay())
                    pnlChessBoard.Refresh();
            }
        }

        //Thao tác help
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On PlayWithComputer mode, Computer will play chess first. Once the match is over, it will continue to the next match.\nIf you are playing with Computer and you are bored, then you can click New Game to begin a new match!\n"
               + "If you play chess wrong, you can click Undo to play chess again!\nIf you don't want to play CaroGame anymore, you can click Exit to get out of the game!","Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        //Hàm endgame
        private void endGames(int win)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    endGames(win);
                });
                return;
            }
            switch (win)
            {
                case 0:
                    MessageBox.Show(this, "You and Computer are drew!", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(this, "New game begins!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    tbScoreX.Text = (scoreX += 1).ToString();
                    MessageBox.Show(this, "Congratulations!\nYou are the winner of this game!\n You are awesome!", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(this, "New game begins!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    tbScoreO.Text = (scoreO += 1).ToString();
                    MessageBox.Show(this, "You losed!\nComputer is the winner of this game!\nDon't worry, let play another game!", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(this, "New game begins!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        //Sự kiện đóng form
        private void PlayWithComputer_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Your score is " + tbScoreX.Text + " in this session!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");
                string ten = lbUserName.Text;
                string sql = "Select * from tbUser where Name = '" + ten + "'";
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

                DataTable mytable = new DataTable();
                adapter.Fill(mytable);
                if (mytable.Rows[0]["Record-PC"].ToString() == null)
                {
                    string newsql = "Update tbUser set [Record-PC] = '" + tbScoreX.Text + "' where Name = '" + ten + "'";
                    SqlCommand cmd = new SqlCommand(newsql, connect);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    if (Int32.Parse(tbScoreX.Text) > Int32.Parse(mytable.Rows[0]["Record-PC"].ToString()))
                    {
                        string newsql = "Update tbUser set [Record-PC] = '" + tbScoreX.Text + "' where Name = '" + ten + "'";
                        SqlCommand cmd = new SqlCommand(newsql, connect);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are some errors! Your record with PC can't be updated!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            Form gui_opengame = new GUI_OPENGAME();
            gui_opengame.ShowDialog();
        }

        //Thao tác new game
        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            eventNewGame(true);
            gameMode = 1;
            _CR._Computer(_gp, 2);
        }

        //Thao tác Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your score is " + tbScoreX.Text + " in this session!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");
                string ten = lbUserName.Text;
                string sql = "Select * from tbUser where Name = '" + ten + "'";
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

                DataTable mytable = new DataTable();
                adapter.Fill(mytable);
                if (mytable.Rows[0]["Record-PC"].ToString() == null)
                {
                    string newsql = "Update tbUser set [Record-PC] = '" + tbScoreX.Text + "' where Name = '" + ten + "'";
                    SqlCommand cmd = new SqlCommand(newsql, connect);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    if (Int32.Parse(tbScoreX.Text) > Int32.Parse(mytable.Rows[0]["Record-PC"].ToString()))
                    {
                        string newsql = "Update tbUser set [Record-PC] = '" + tbScoreX.Text + "' where Name = '" + ten + "'";
                        SqlCommand cmd = new SqlCommand(newsql, connect);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are some errors! Your record with PC can't be updated!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            Form gui_opengame = new GUI_OPENGAME();
            gui_opengame.ShowDialog();
        }

    }
}
