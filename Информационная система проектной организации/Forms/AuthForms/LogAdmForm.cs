using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Информационная_система_проектной_организации
{
    public partial class LogAdmForm : Form
    {
        UsefullFuncs uff;
        string sqlConnectionCmd = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'D:\!ПРОЕКТ ПО РПО\Информационная система проектной организации\" +
                    @"Информационная система проектной организации\MainDB.mdf';" +
                    @"Integrated Security=True";

        public LogAdmForm()
        {
            CustomElements.Animator.Start();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (passTextBox.Text == "" && loginTextBox.Text == "")
            {
                return;
            }
            using (var connect = new SqlConnection(sqlConnectionCmd))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT [UserName] FROM [User] WHERE [UserName] = @Login and [Password] = @Password";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.Parameters.AddWithValue("@Login", loginTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passTextBox.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Вы успешно авторизовались!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AdminForm af = new AdminForm();
                        Visible = false;
                        if (af.ShowDialog() != DialogResult.Abort)
                            Visible = true;
                    }
                    else
                        MessageBox.Show("Неверно введён логин или пароль!\r\nПопробуйте ещё раз.", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State != System.Data.ConnectionState.Closed)
                        connect.Close();
                }
            }
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
            {
                passTextBox.PasswordChar = Convert.ToChar(0);
                pictureBox3.Image = Image.FromFile("Pictures/blackEye.png");
            }
            else
            {
                passTextBox.PasswordChar = '•';
                pictureBox3.Image = Image.FromFile("Pictures/blackEye (2).png");
            }
            onOfPass = !onOfPass;
        }
        private void regNewLabel_MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.ForeColor = uff.moveDownColor;
        }

        private void regNewLabel_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.ForeColor = uff.moveUpColor;
        }

        private void regNewLabel_Click(object sender, EventArgs e)
        {
            RegForm rf = new RegForm();
            this.Visible = false;
            DialogResult dr = rf.ShowDialog();
            this.Visible = true;
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

        private void label2_Click(object sender, EventArgs e)
        {
            ResetPassForm rpf = new ResetPassForm();
            rpf.ShowDialog();
        }
    }
}
