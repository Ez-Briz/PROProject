using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Информационная_система_проектной_организации
{
    public partial class RegNewOtdelForm : Form
    {
        UsefullFuncs uff;
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'|DataDirectory|\MainDB.mdf'";
        public RegNewOtdelForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            uff = new UsefullFuncs();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT [Name], [Surname], [Patronymic] FROM Employee", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    fioComboBox.Items.Add(dr.GetValue(1) + " " + dr.GetValue(0) + " " + dr.GetValue(2));
                dr.Close();

                connection.Close();
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private bool checkAllFields()
        {
            bool ok;
            if (nameTextBox.Text.Length > 0 || specTextBox.Text.Length > 0 ||
                fioComboBox.SelectedIndex != -1)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkAllFields())
            {
                RegisterNewOtdel();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля перед регистрацией нового отдела!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkAllFields())
            {
                RegisterNewOtdel();
                this.DialogResult = DialogResult.Retry;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля перед регистрацией нового отдела!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void RegisterNewOtdel()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string cmdStr = "INSERT INTO Otdel([Name], [Spec], [ManagerFIO]) VALUES" +
                        "(@Name, @Spec, @FIO)";
                    string checkValueCmd = "SELECT [ID] FROM [Otdel]" +
                        "WHERE @Name = [Name]";
                    bool alreadyExist = false;
                    
                    using(SqlCommand checkCmd = new SqlCommand(checkValueCmd, connection))
                    { 
                        checkCmd.Parameters.AddWithValue("@Name", 
                            nameTextBox.Text.Length > 0 ? nameTextBox.Text : "None");
                        SqlDataReader dr = checkCmd.ExecuteReader();
                        if (dr.Read())
                            alreadyExist = true;
                        dr.Close();
                    }
                    if (!alreadyExist)
                    {
                        using (SqlCommand insertCmd = new SqlCommand(cmdStr, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@Name",
                                nameTextBox.Text.Length > 0 ? nameTextBox.Text : "None");
                            insertCmd.Parameters.AddWithValue("@Spec",
                                specTextBox.Text);
                            insertCmd.Parameters.AddWithValue("@FIO",
                                fioComboBox.SelectedItem.ToString().Trim());
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                    else
                        throw new Exception("Отдел с таким названием уже существует!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
