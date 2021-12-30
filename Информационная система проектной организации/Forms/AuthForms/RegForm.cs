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

namespace Информационная_система_проектной_организации
{
    public partial class RegForm : Form
    {
        UsefullFuncs uff;
        string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'|DataDirectory|\MainDB.mdf'";
        public RegForm()
        {
            InitializeComponent();
            uff = new UsefullFuncs();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        Point last;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last.X;
                this.Top += e.Y - last.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            last = new Point(e.X, e.Y);
        }
        private void iconPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            last = new Point(e.X, e.Y);
        }

        private void iconPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last.X;
                this.Top += e.Y - last.Y;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.CloseButton.BackColor = uff.moveUpColor;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButton.BackColor = topPanel.BackColor;
        }
        bool onOfPass = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!onOfPass)
                passTextBox.PasswordChar = Convert.ToChar(0);
            else
                passTextBox.PasswordChar = '•';
            onOfPass = !onOfPass;
        }

        
        private void regButton_Click(object sender, EventArgs e)
        {
            if(this.passTextBox.Text == pass2TextBox.Text)
            {
                if (uff.IsPassValid(passTextBox.Text))
                    using (SqlConnection connect = new SqlConnection(sqlConnectionString))
                    {
                        try
                        {
                            if (uff.IsAlreadyInUse(loginTextBox.Text, connect))
                            {
                                MessageBox.Show("Указанный логин уже занят!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            connect.Open();
                            string sql = "INSERT INTO [User]([UserName],[Password],[EMail])" +
                                " VALUES (@Login, @Password, @EMail)";
                            SqlCommand cmd = new SqlCommand(sql, connect);
                            cmd.Parameters.AddWithValue("@Login", loginTextBox.Text);
                            cmd.Parameters.AddWithValue("@Password", passTextBox.Text);
                            cmd.Parameters.AddWithValue("@EMail", textBox1.Text);

                            if (cmd.ExecuteNonQuery() != 0)
                                MessageBox.Show("Вы успешно зарегистрировали пользователя!", "Успех!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (connect.State != ConnectionState.Closed)
                                connect.Close();
                        }

                    }
                else
                {
                    MessageBox.Show("Неправильный формат пароля, попробуйте ещё раз!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passTextBox.Text = "";
                    pass2TextBox.Text = "";
                    passTextBox.Focus();
                    return;
                }
            }
            
            this.Close();
        }


        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = uff.CheckForSpace(loginTextBox.Text);
            if (index == -1)
                return;
            if (Convert.ToBoolean(index) || index == 0)
                loginTextBox.Text = this.loginTextBox.Text.Remove(index, 1);
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = uff.CheckForSpace(passTextBox.Text);
            if (index == -1)
                return;
            if (Convert.ToBoolean(index) || index == 0)
                passTextBox.Text = this.passTextBox.Text.Remove(index, 1);
        }

        private void pass2TextBox_TextChanged(object sender, EventArgs e)
        {
            int index = uff.CheckForSpace(pass2TextBox.Text);
            if (index == -1)
                return;
            if (Convert.ToBoolean(index) || index == 0)
                pass2TextBox.Text = this.pass2TextBox.Text.Remove(index, 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
