using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Информационная_система_проектной_организации
{
    public partial class ResetPassForm : Form
    {
        UsefullFuncs uff;
        const int maxPassLength = 50;
        string resetcode = "";
        string password = "";
        string sqlConnectionCmd =  @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'D:\!ПРОЕКТ ПО РПО\Информационная система проектной организации\" +
                    @"Информационная система проектной организации\MainDB.mdf';" +
                    @"Integrated Security=True";
        readonly Color moveUpColor;
        public ResetPassForm()
        {
            InitializeComponent();
            moveUpColor = SystemColors.ControlDarkDark;
            uff = new UsefullFuncs();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resetPassPanel.Visible = false;
            textBox1.Text = "";
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
            if (emailTextBox.Text == "" && loginTextBox.Text == "")
            {
                return;
            }
            using (var connect = new SqlConnection(sqlConnectionCmd))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT [EMail], [Password] FROM [User] WHERE [UserName] = @Login and [EMail] = @Email";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.Parameters.AddWithValue("@Login", loginTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        this.resetPassPanel.Visible = true;
                        resetPassPanel.Enabled = true;
                        Random rand = new Random();
                        password = dr.GetValue(1).ToString();
                        resetcode = rand.Next(1000, 10000).ToString();
                        string message = "Your recovery code - " + resetcode.ToString() + "\nNOTIFICATION:\n" +
                            "If you are not requesting recovery code - just ignore this message.";
                        uff.SendMail(message, emailTextBox.Text, "Password reminder");

                    }
                    else
                        MessageBox.Show("Неверно введён логин или почта!\r\nПопробуйте ещё раз.", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Contains(' '))
            {
                loginTextBox.Text = loginTextBox.Text.Remove(loginTextBox.Text.Length - 1, 1);
                resetButton.Focus();
            }
            else if (loginTextBox.Text.Contains('\n'))
            {
                loginTextBox.Text = loginTextBox.Text.Remove(loginTextBox.Text.Length - 2, 2);
                resetButton.Focus();
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Contains(' '))
            {
                emailTextBox.Text = emailTextBox.Text.Remove(emailTextBox.Text.Length - 1, 1);
                resetButton.Focus();
            }
            else if (emailTextBox.Text.Contains('\n'))
            {
                emailTextBox.Text = emailTextBox.Text.Remove(emailTextBox.Text.Length - 2, 2);
                resetButton.Focus();
            }
            if (emailTextBox.Text.Length / 8 >= 1)
            {
                emailTextBox.Font = new Font(emailTextBox.Font.FontFamily,
                    Convert.ToSingle(16.0 - 2.0 * emailTextBox.Text.Length / 8),
                    FontStyle.Bold);
            }
            else
            {
                emailTextBox.Font = new Font(emailTextBox.Font.FontFamily,
                    Convert.ToSingle(16.0),
                    FontStyle.Bold);
            }
            if (emailTextBox.Text.Contains("@mail.ru") || emailTextBox.Text.Contains("@gmail.com"))
                emailTextBox.ForeColor = ForeColor;
            else
                emailTextBox.ForeColor = Color.Red;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = "";
            loginTextBox.Text = "";
            resetPassPanel.Visible = false;
            textBox1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == resetcode)
            {
                resetPassPanel.Visible = false;
                resetPassPanel.Enabled = false;
                string message = "Your password - " + password + ". Do not forget it!";
                uff.SendMail(message, emailTextBox.Text, "Password reminder");
                MessageBox.Show("Пароль отправлен вам на почту!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }

}
