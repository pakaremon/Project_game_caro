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
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }

        //Sự kiện khi bấm Register
        private void btRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\PROJECT_CARO_GAME\PROJECT_CARO_GAME\Database_Caro.mdf;Integrated Security=True");


                string name = tbUserName.Text;
                string password = tbPassword.Text;

                if (tbUserName.Text.Equals("") || tbPassword.Text.Equals("") || tbRetypePassword.Text.Equals(""))
                {
                    MessageBox.Show("You have't typed all infomation!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tbPassword.Text != tbRetypePassword.Text)
                {
                    MessageBox.Show("First password and second password are not the same!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "Insert into tbUser values ('" + name + "', '" + password + "', 0, 0)";


                SqlCommand cmd = new SqlCommand(sql, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                cmd.Dispose();
                this.Hide();
                MessageBox.Show("Registered an account successfully with user name is " + tbUserName.Text + "!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form f = new GUI_OPENGAME();
                f.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("There are some errors! So the account can't be created...", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Sự kiện Exit
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new GUI_OPENGAME();
            f.ShowDialog();
        }

        //Sự kiện khi bấm ô ShowPassword
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbRetypePassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbRetypePassword.UseSystemPasswordChar = true;
            }
        }

        //Sự kiện đóng form
        private void REGISTER_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new GUI_OPENGAME();
            f.ShowDialog();
        }

        //Không cho phép phóng to
        private void REGISTER_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
