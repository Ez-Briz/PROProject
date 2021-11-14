using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Информационная_система_проектной_организации
{
    public partial class RegNewEmpForm : Form
    {
        UsefullFuncs uff;
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'D:\!ПРОЕКТ ПО РПО\Информационная система проектной организации\" +
                    @"Информационная система проектной организации\MainDB.mdf';" +
                    @"Integrated Security=True";
        int otdelId;
        int specId;
        public RegNewEmpForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            uff = new UsefullFuncs();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string cmdStr = "SELECT Name From Spec";
                    

                    using (SqlCommand fillCmd = new SqlCommand(cmdStr, connection))
                    {
                        SqlDataReader dr = fillCmd.ExecuteReader();
                        while (dr.Read())
                        {
                            profComboBox.Items.Add(dr.GetValue(0).ToString().Trim());
                        }
                        dr.Close();
                    }
                    string cmdStr2 = "SELECT Name FROM Otdel";
                    using (SqlCommand fillCmd1 = new SqlCommand(cmdStr2, connection))
                    {
                        SqlDataReader dr1 = fillCmd1.ExecuteReader();
                        while (dr1.Read())
                        {
                            otdelComboBox.Items.Add(dr1.GetValue(0).ToString().Trim());
                        }
                        dr1.Close();
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Abort;
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                }
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
            if (nameTextBox.Text.Length > 0 || surnameTextBox.Text.Length > 0 ||
                patrTextBox.Text.Length > 0 || ageNumericUpDown.Value > 18 || birthDatePicker.Value < DateTime.Now
                || profComboBox.SelectedIndex != -1 || otdelComboBox.SelectedIndex != -1)
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
                RegisterNewEmployee();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля перед регистрацией нового сотрудника!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkAllFields())
            {
                RegisterNewEmployee();
                this.DialogResult = DialogResult.Retry;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля перед регистрацией нового сотрудника!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void RegisterNewEmployee()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string cmdStr = "INSERT INTO Employee([Name], [Surname], [Patronymic], [OtdelId], [Age], [BirthdayDate], [SpecId]) VALUES" +
                        "(@Name, @Surname, @Patr, @OtdelId, @Age, @BD, @SpecId)";
                    string checkValueCmd = "SELECT [ID] FROM [Employee]" +
                        "WHERE @Name = [Name] and @Surname = [Surname] and [Patronymic] = @Patr";
                    bool alreadyExist = false;
                    
                    using(SqlCommand checkCmd = new SqlCommand(checkValueCmd, connection))
                    { 
                        checkCmd.Parameters.AddWithValue("@Name", 
                            nameTextBox.Text.Length > 0 ? nameTextBox.Text : "None");
                        checkCmd.Parameters.AddWithValue("@Surname", 
                            surnameTextBox.Text.Length > 0 ? surnameTextBox.Text : "None");
                        checkCmd.Parameters.AddWithValue("@Patr", 
                            patrTextBox.Text.Length > 0 ? patrTextBox.Text : "None");
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
                            insertCmd.Parameters.AddWithValue("@Surname",
                                surnameTextBox.Text);
                            insertCmd.Parameters.AddWithValue("@Patr",
                                patrTextBox.Text);
                            insertCmd.Parameters.AddWithValue("@OtdelId",
                                otdelId);
                            insertCmd.Parameters.AddWithValue("@Age", ageNumericUpDown.Value);
                            insertCmd.Parameters.AddWithValue("@BD", birthDatePicker.Value);
                            insertCmd.Parameters.AddWithValue("@SpecId", specId);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                    else
                        throw new Exception("Сотрудник с таким ФИО уже существует!");
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

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox send = sender as ComboBox;
            if (send.SelectedIndex == -1)
                return;
            bool profOrNot = send.Name.Contains("prof") ? true : false;
            string cmd = string.Format("SELECT Id FROM {0} WHERE Name = @Name", profOrNot ? "Spec" : "Otdel");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand getIdCmd = new SqlCommand(cmd, connection))
                {
                    getIdCmd.Parameters.AddWithValue("@Name", send.SelectedItem.ToString());
                    if (profOrNot)
                        specId = Convert.ToInt32(getIdCmd.ExecuteScalar());
                    else
                        otdelId = Convert.ToInt32(getIdCmd.ExecuteScalar());
                }
            }
        }
    }
}
