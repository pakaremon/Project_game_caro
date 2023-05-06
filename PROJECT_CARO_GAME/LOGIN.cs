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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        //Sự kiện khi bấm login
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");


                string name = tbUserName.Text;
                string password = tbPassword.Text;

                if (tbUserName.Text.Equals("") || tbPassword.Text.Equals(""))
                {
                    MessageBox.Show("You haven't typed all infomation!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    
                }

                string sql = "Select * from tbUser where Name = '" + name + "' and Password = '" + password + "'";
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    this.Hide();
                    MessageBox.Show("Welcom "+tbUserName.Text + "! Play game now...", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form playmode = new PlayMode(tbUserName.Text);
                    playmode.ShowDialog();

                }
                else
                {
                    MessageBox.Show("The login failed!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are some errors!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện Exit
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new GUI_OPENGAME();
            f.ShowDialog();
            
        }

        //Sự kiểm khi bấm ô ShowPassword
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        //Sự kiện đóng form
        private void LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new GUI_OPENGAME();
            f.ShowDialog();
        }

        //Không cho phép phóng to
        private void LOGIN_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
