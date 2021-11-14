using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Информационная_система_проектной_организации
{
    public partial class RegNewSubForm : Form
    {
        UsefullFuncs uff;
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'D:\!ПРОЕКТ ПО РПО\Информационная система проектной организации\" +
                    @"Информационная система проектной организации\MainDB.mdf';" +
                    @"Integrated Security=True";
        public RegNewSubForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
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
            DialogResult = DialogResult.Cancel;
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
            if (nameTextBox.Text.Length > 0 || fioComboBox.SelectedIndex != -1||
                counterUpDown.Value > 0 || specTextBox.Text.Length > 0)
                return true;
            else return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkAllFields())
            {
                RegisterNewOrg();
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля перед регистрацией проекта!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void RegisterNewOrg()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string cmdStr = "INSERT INTO Suborg([Name], [ManagerFIO], [Spec], [PersonalCount]) VALUES" +
                        "(@Name, @FIO, @Spec, @Count)";
                    string checkValueCmd = "SELECT COUNT([Suborg].[ID]) FROM [Suborg]" +
                        "WHERE @Name = [Suborg].[Name]";
                    bool alreadyExist = false;
                    using(SqlCommand checkCmd = new SqlCommand(checkValueCmd, connection))
                    { 
                        checkCmd.Parameters.AddWithValue("@Name", 
                            nameTextBox.Text.Length > 5 ? nameTextBox.Text : "None");
                        object a = checkCmd.ExecuteScalar();
                        if (a != null)
                            if (Convert.ToInt32(a) != 0)
                                alreadyExist = true;
                    }
                    if (!alreadyExist)
                    {
                        using (SqlCommand insertCmd = new SqlCommand(cmdStr, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@Name",
                                nameTextBox.Text.Length > 5 ? nameTextBox.Text : "None");
                            insertCmd.Parameters.AddWithValue("@Spec",
                                specTextBox.Text);
                            insertCmd.Parameters.AddWithValue("@FIO",
                                fioComboBox.SelectedItem.ToString().Trim());
                            insertCmd.Parameters.AddWithValue("@Count",
                                counterUpDown.Value);
                            if (insertCmd.ExecuteNonQuery() != 0)
                                DialogResult = DialogResult.OK;
                        }
                        Close();
                    }
                    else
                        throw new Exception("Субподрядная организация с таким названием уже существует!");
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
                }
            }
        }
    }
}
