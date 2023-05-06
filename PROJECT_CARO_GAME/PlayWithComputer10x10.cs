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
    public partial class PlayWithComputer10x10 : Form
    {
        CaroChess10x10 _CR10x10;
        Graphics _gp;
        int scoreX = 0, scoreO = 0, myPiece = 1; //1 = cờ X, 2 = cờ O
        int gameMode = 1; //1: computer

        public PlayWithComputer10x10()
        {
            InitializeComponent();
        }

        public PlayWithComputer10x10(string name):this()
        {
            lbUserName.Text = name;
        }      

        private void pnlChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (_CR10x10._playChess(e.Y, e.X, _gp, myPiece))
            {
                _CR10x10.readyPlay = false;
                checkWinner();

                if (gameMode == 1)
                {
                    _CR10x10._Computer(_gp, 2);
                    if (checkWinner())
                        _CR10x10._Computer(_gp, 2);
                }
            }
        }


        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {
            _CR10x10._drawBoardChess(_gp);
        }

        //Sự kiện khi ấn nút Begin
        private void btBeginComputer_Click(object sender, EventArgs e)
        {
            eventNewGame(false);
            gameMode = 1;
            _CR10x10._Computer(_gp, 2);
            btBeginComputer.Enabled = false;
        }

        private void PlayWithComputer10x10_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            _CR10x10 = new CaroChess10x10();
            _gp = pnlChessBoard.CreateGraphics();
        }

        //Thao tác Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameMode == 1)
            {
                _CR10x10._undoPlay();
                if (_CR10x10._undoPlay())
                    pnlChessBoard.Refresh();
            }
        }

        //Thao tác help
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On PlayWithComputer mode, Computer will play chess first. Once the match is over, it will continue to the next match.\nIf you are playing with Computer and you are bored, then you can click New Game to begin a new match!\n"
               + "If you play chess wrong, you can click Undo to play chess again!\nIf you don't want to play CaroGame anymore, you can click Exit to get out of the game!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Sự kiện đóng form
        private void PlayWithComputer10x10_FormClosed(object sender, FormClosedEventArgs e)
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
            _CR10x10._newGames();
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
            int check = _CR10x10._checkWins();
            if (check != -1)
            {
                endGames(check);
                eventNewGame(true);
                _CR10x10.readyPlay = false;
                return true;
            }
            else
                return false;
        }

        //Thao tác newgame
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventNewGame(true);
            gameMode = 1;
            _CR10x10._Computer(_gp, 2);
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
    }
}
