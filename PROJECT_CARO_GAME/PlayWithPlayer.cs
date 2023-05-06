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
using System.IO;
using System.Data.SqlClient;

namespace PROJECT_CARO_GAME
{
    public partial class PlayWithPlayer : Form
    {
        CaroChess _CR;
        Graphics _gp;
        ConnectLanNetwork LAN;
        Socket _Socket;
        int scoreX = 0, scoreO = 0, myPiece = 1; //1 : cờ X, 2 : cờ O
        string myIPAdress = "127.0.0.1";
        string Uname; // Lấy tên của người chơi từ form trước đó
        int Player = -1; // Phân biệt điểm giữa 2 người chơi


        public PlayWithPlayer()
        {
            InitializeComponent();
        }

        public PlayWithPlayer(string name):this()
        {
            Uname = name;
        }

        private void PlayWithPlayer_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            _CR = new CaroChess();
            _gp = pnlChessBoard.CreateGraphics();
            LAN = new ConnectLanNetwork();
            myIPAdress = getMyIPv4();
            
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
                string[] data = { "played", e.Y.ToString(), e.X.ToString(), myPiece.ToString() };
                LAN.sentData(_Socket, data);
                checkWinner();
            }
        }

        private void btLanConnect_Click(object sender, EventArgs e)
        {
            btLanConnect.Enabled = false;
            if (string.IsNullOrEmpty(tbIPAddress.Text))
            {
                Socket skServer = LAN.createServer((int)NudPort.Value);
                if (skServer == null)
                {
                    addChatBox("System", "Create Server failed!");
                    btLanConnect.Enabled = true;
                }
                else
                {
                    Player = 1;
                    addChatBox("System", "Server created, waiting connection...");
                    addChatBox("System", Uname+ " will play red X chess!");
                    tbIPAddress.Text = myIPAdress;
                    tbScoreX.ForeColor = Color.Red;
                    waitConnect(skServer);
                }
            }
            else
            {
                _Socket = LAN.connectServer(tbIPAddress.Text, (int)NudPort.Value);
                if (_Socket == null)
                {
                    addChatBox("System", "Connection failed!");
                    btLanConnect.Enabled = true;
                }
                else
                {
                    Player = 2;
                    myPiece = 2;
                    tbScoreO.ForeColor = Color.Red;
                    addChatBox("System", Uname + " will play purple O chess!");
                    receiveData(_Socket);   
                }
            }
        }

        //Server chờ client kết nối
        private void waitConnect(Socket socket)
        {
            Thread waitThread = new Thread(() =>
            {
                socket.Listen(1);
                _Socket = socket.Accept();
                receiveData(_Socket);

                socket.Close();
            });
            waitThread.IsBackground = true;
            waitThread.Start();
        }

        //Nhận dữ liệu gửi qua socket
        private void receiveData(Socket socket)
        {
            Thread receiveThread = new Thread(() =>
            {
                try
                {
                    addChatBox("System", "Connected, Let's fight!");
                    eventNewGame(false);
                    _CR.readyPlay = true;
                    //Vòng lặp để lắng nghe và nhận dữ liệu socket
                    while (true)
                    {
                        byte[] data = new byte[2048];
                        socket.Receive(data);
                        analysisData(LAN.byteToObj(data));
                    }
                }
                catch
                {
                    Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show(this, "The enemy is out game. The game will be ended.", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlChessBoard.Enabled = false;
                        lvMessage.Enabled = false;
                        tbEnterMessage.Enabled = false;
                        menuToolStripMenuItem.Enabled = false;
                    });
                }
            });
            receiveThread.IsBackground = true;
            receiveThread.Start();
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

        //Lấy địa chỉ IP của máy
        private string getMyIPv4()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        //Cập nhật list chatbox
        private void addChatBox(string from, string content)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    addChatBox(from, content);
                });
                return;
            }
            ListViewItem item = new ListViewItem(from);
            item.SubItems.Add(content);
            lvMessage.Items.Add(item);
            lvMessage.Items[lvMessage.Items.Count - 1].EnsureVisible();
        }
  

        //Phân tích dữ liệu nhận được
        private void analysisData(object data)
        {
            string[] str = data as string[];
            switch (str[0])
            {
                case "message":
                    addChatBox(str[2], str[1]);
                    break;
                case "played":
                    _CR.readyPlay = true;
                    int row = int.Parse(str[1]), column = int.Parse(str[2]), piece = int.Parse(str[3]);
                    _CR._playChess(row, column, _gp, piece);
                    checkWinner();
                    break;
                case "ready":
                    _CR.readyPlay = true;
                    break;
                case "undo":
                    eventUndo();
                    _CR.readyPlay = false;
                    break;
            }
        }

        //Xác định player chiến thắng
        private bool checkWinner()
        {
            int check = _CR._checkWins();
            if (check != -1)
            {
                endGames(check);
                
                string[] data = { "ready" };
                LAN.sentData(_Socket, data);
                eventNewGame(true);
                _CR.readyPlay = false;
                return true;
            }
            else
                return false;
        }

        //Thao tác undo trong Menu
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CR.readyPlay)
                return;
            if (eventUndo())
            {
                _CR.readyPlay = true;
                string[] data = { "undo" };
                LAN.sentData(_Socket, data);
            } 
        }

        //Thao tác Help trong Menu
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On PlayWithPlayer mode, before playing, 2 players need to set up connection by entering IP and Port.\n\nThe player creating the server first will play chess first and his chess color will be red.\nThe other will play chess second and his chess color will be purple!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Thao tác Exit trong Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Player==1)
            {
                MessageBox.Show(Uname + " got " + tbScoreX.Text + " point/points in this session!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");
                    string name = Uname;
                    string sql = "Select * from tbUser where Name = '" + name + "'";
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

                    DataTable mytable = new DataTable();
                    adapter.Fill(mytable);
                    if (mytable.Rows[0]["Record-Player"].ToString() == null)
                    {
                        string newsql = "Update tbUser set [Record-Player] = '" + tbScoreX.Text + "' where Name = '" + name + "'";
                        SqlCommand cmd = new SqlCommand(newsql, connect);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Int32.Parse(tbScoreX.Text) > Int32.Parse(mytable.Rows[0]["Record-Player"].ToString()))
                        {
                            string newsql = "Update tbUser set [Record-Player] = '" + tbScoreX.Text + "' where Name = '" + name + "'";
                            SqlCommand cmd = new SqlCommand(newsql, connect);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There are some errors! Your record with PC can't be updated!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    

            else if(Player==2)
            {
                MessageBox.Show(Uname + " got " + tbScoreO.Text + " point/points in this session!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");
                    string name = Uname;
                    string sql = "Select * from tbUser where Name = '" + name + "'";
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

                    DataTable mytable = new DataTable();
                    adapter.Fill(mytable);
                    if (mytable.Rows[0]["Record-Player"].ToString() == null)
                    {
                        string newsql = "Update tbUser set [Record-Player] = '" + tbScoreO.Text + "' where Name = '" + name + "'";
                        SqlCommand cmd = new SqlCommand(newsql, connect);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Int32.Parse(tbScoreO.Text) > Int32.Parse(mytable.Rows[0]["Record-Player"].ToString()))
                        {
                            string newsql = "Update tbUser set [Record-Player] = '" + tbScoreO.Text + "' where Name = '" + name + "'";
                            SqlCommand cmd = new SqlCommand(newsql, connect);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There are some errors! Your record with PC can't be updated!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Hide();
        }

        //Tạo presskey cho phím Enter thay thế nút gửi
        private void tbEnterMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                addChatBox(Uname, tbEnterMessage.Text);
                string[] data = { "message", tbEnterMessage.Text, Uname };
                LAN.sentData(_Socket, data);
                tbEnterMessage.Text = "";
            }
        }

        //Hành động đóng form
        private void PlayWithPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Player==1)
            {
                MessageBox.Show(Uname + " got " + tbScoreX.Text + " point/points in this session!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");
                    string name = Uname;
                    string sql = "Select * from tbUser where Name = '" + name + "'";
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

                    DataTable mytable = new DataTable();
                    adapter.Fill(mytable);
                    if (mytable.Rows[0]["Record-Player"].ToString() == null)
                    {
                        string newsql = "Update tbUser set [Record-Player] = '" + tbScoreX.Text + "' where Name = '" + name + "'";
                        SqlCommand cmd = new SqlCommand(newsql, connect);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Int32.Parse(tbScoreX.Text) > Int32.Parse(mytable.Rows[0]["Record-Player"].ToString()))
                        {
                            string newsql = "Update tbUser set [Record-Player] = '" + tbScoreX.Text + "' where Name = '" + name + "'";
                            SqlCommand cmd = new SqlCommand(newsql, connect);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There are some errors! Your record with Player can't be updated!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (Player==2)
            {
                MessageBox.Show(Uname+ " got " + tbScoreO.Text + " point/points in this session!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");
                    string name = Uname;
                    string sql = "Select * from tbUser where Name = '" + name + "'";
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

                    DataTable mytable = new DataTable();
                    adapter.Fill(mytable);
                    if (mytable.Rows[0]["Record-Player"].ToString() == null)
                    {
                        string newsql = "Update tbUser set [Record-Player] = '" + tbScoreO.Text + "' where Name = '" + name + "'";
                        SqlCommand cmd = new SqlCommand(newsql, connect);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Int32.Parse(tbScoreO.Text) > Int32.Parse(mytable.Rows[0]["Record-Player"].ToString()))
                        {
                            string newsql = "Update tbUser set [Record-Player] = '" + tbScoreO.Text + "' where Name = '" + name + "'";
                            SqlCommand cmd = new SqlCommand(newsql, connect);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There are some errors! Your record with Player can't be updated!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            this.Hide();
            
        }

        //Hàm kết thúc game
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
                    addChatBox("System", Uname+" and the enemy are drew!");                  
                    MessageBox.Show(this, "New game begins!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    addChatBox("System", "Player X win!"); 
                    tbScoreX.Text = (scoreX += 1).ToString();                  
                    MessageBox.Show(this, "New game begins!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    addChatBox("System", "Player O win!");
                    tbScoreO.Text = (scoreO += 1).ToString();
                    MessageBox.Show(this, "New game begins!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        //Hàm xử lý thao tác undo
        private bool eventUndo()
        {
            bool undo = _CR._undoPlay();
            if (undo)
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        pnlChessBoard.Refresh();
                    });
                else
                    pnlChessBoard.Refresh();
            }
            return undo;
        }
    }
}
