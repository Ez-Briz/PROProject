using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Информационная_система_проектной_организации
{
    public partial class ManageEmpForm : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'|DataDirectory|\MainDB.mdf'";
        UsefullFuncs uff;
        public ManageEmpForm()
        {
            InitializeComponent();
            uff = new UsefullFuncs();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT [Name], Surname, Patronymic FROM Employee", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    listBox1.Items.Add(dr.GetValue(1) + " " + dr.GetValue(0) + " " + dr.GetValue(2));
                dr.Close();
                SqlCommand otdels = new SqlCommand("SELECT Otdel.[Name], Spec.[Name] FROM Otdel, Spec", connection);
                SqlDataReader otdelsR = otdels.ExecuteReader();
                while (otdelsR.Read())
                {
                    if (!otdelComboBox.Items.Contains(otdelsR.GetValue(0)))
                        otdelComboBox.Items.Add(otdelsR.GetValue(0));
                    if (!specComboBox.Items.Contains(otdelsR.GetValue(1)))
                        specComboBox.Items.Add(otdelsR.GetValue(1));
                }
                otdelsR.Close();
                connection.Close();
            }
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
        int pointCount = 1;
        private void UpdateCurrentEmpInfo()
        {
            try
            {
                string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
                if (name == null)
                {
                    return;
                }
                string[] fio = name.Split(' ');
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {   
                        connection.Open();
                        string infoCmd = "SELECT * FROM Employee WHERE Name = @Name and Surname = @Sur and Patronymic = @Patr";
                        using(SqlCommand cmd = new SqlCommand(infoCmd, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", fio[1]);
                            cmd.Parameters.AddWithValue("@Sur", fio[0]);
                            cmd.Parameters.AddWithValue("@Patr", fio[2]);
                            SqlDataReader dr = cmd.ExecuteReader();
                            infoPanel.Visible = true;
                            if (dr.Read())
                            {
                                nameTextBox.Text = dr.GetValue(1).ToString();
                                surnameTextBox.Text = dr.GetValue(2).ToString();
                                patrTextBox.Text = dr.GetValue(3).ToString();
                                ageUpDown.Value = Convert.ToInt32(dr.GetValue(5));
                                bdTimePicker.Value = Convert.ToDateTime(dr.GetValue(6));
                                int otdelId = dr.GetInt32(4);
                                int specId = dr.GetInt32(7);
                                dr.Close();
                                using(SqlCommand selectCmd = new SqlCommand("SELECT Otdel.[Name], Spec.[Name] FROM Otdel, Spec " +
                                    "WHERE Otdel.[Id] = @cid and Spec.[Id] = @sid", connection))
                                {
                                    selectCmd.Parameters.AddWithValue("@cid", otdelId);
                                    selectCmd.Parameters.AddWithValue("@sid", specId);
                                    SqlDataReader selReader = selectCmd.ExecuteReader();
                                    if(selReader.Read())
                                    {
                                        specComboBox.SelectedItem = selReader.GetValue(1);
                                        otdelComboBox.SelectedItem = selReader.GetValue(0);
                                    }
                                    selReader.Close();
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (connection.State != ConnectionState.Closed)
                            connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editable)
                ChangeState();
            if (listBox1.SelectedIndex == -1)
                return;
            UpdateCurrentEmpInfo();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (name == null)
                        throw new Exception("Ошибка при удалении выбранного сотрудника! Для удаления выберите одного из списка.");
                    connection.Open();
                    string sqlCmd = "DELETE FROM Suborg WHERE [Name] = @Name";
                    using (SqlCommand delCmd = new SqlCommand(sqlCmd, connection))
                    {
                        delCmd.Parameters.AddWithValue("@Name", name);
                        if (delCmd.ExecuteNonQuery() == 0)
                        {
                            throw new Exception("Выбранный сотрудник не найден в БД!");
                        }
                        else
                        {
                            listBox1.Items.Remove(name);
                            infoPanel.Visible = false;
                            MessageBox.Show("Сотрудник успешно удалён из БД!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch(Exception ex)
                {
                    infoPanel.Visible = false;
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
        bool editable = false;
        bool isAnyFieldChanged = false;
        private void ChangeState()
        {
            if (infoPanel.Visible == false)
                return;
            editable = !editable;
            saveButton.Visible = editable;
            delButton.Enabled = !editable;
            foreach (Control control in infoPanel.Controls)
            {
                if (control.Name.Contains("Label"))
                    continue;   
                if(control.Name.Contains("UpDown") || control.Name.Contains("TimePicker") || 
                    control.Name.Contains("ComboBox"))
                {
                    ComboBox up = control as ComboBox;
                    control.Enabled = editable;
                    continue;
                }
                TextBox tb = control as TextBox;
                tb.ReadOnly = !editable;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            UpdateCurrentEmpInfo();
            ChangeState();
        }

        private void infoTextBoxes_TextChanged(object sender, EventArgs e)
        {
            isAnyFieldChanged = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!isAnyFieldChanged)
                return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
                    if (name == null)
                    {
                        throw new Exception("Ошибка сохранения выбранного сотрудника!");
                    }
                    if (specComboBox.SelectedIndex == -1 && otdelComboBox.SelectedIndex == -1)
                        throw new Exception("Не выбран отдел или специальность сотрудника!");
                    string sqlCmd = "UPDATE Employee SET [Name] = @NewName, Surname = @NewSur, SpecId = @Spec, Patronymic = @NewPatr, " +
                        "OtdelId = @Otdel, Age = @Age, BirthdayDate = @BD" +
                        " WHERE Name = @Name and Surname = @Surname and Patronymic = @Patr";
                    using (SqlCommand updateCmd = new SqlCommand(sqlCmd, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@NewName", nameTextBox.Text);
                        updateCmd.Parameters.AddWithValue("@NewSur", surnameTextBox.Text);
                        updateCmd.Parameters.AddWithValue("@NewPatr", patrTextBox.Text);
                        updateCmd.Parameters.AddWithValue("@Age", ageUpDown.Value);
                        updateCmd.Parameters.AddWithValue("@BD", bdTimePicker.Value);
                        string[] fio = name.Split(' ');
                        updateCmd.Parameters.AddWithValue("@Name", fio[1]);
                        updateCmd.Parameters.AddWithValue("@Surname", fio[0]);
                        updateCmd.Parameters.AddWithValue("@Patr", fio[2]);
                        updateCmd.Parameters.AddWithValue("@Spec", new SqlCommand(string.Format("SELECT [Id] FROM Spec " +
                            "WHERE [Name] = N'{0}'", specComboBox.SelectedItem.ToString().Trim()), connection).ExecuteScalar());
                        updateCmd.Parameters.AddWithValue("@Otdel", new SqlCommand(string.Format("SELECT [Id] FROM Otdel " +
                            "WHERE [Name] = N'{0}'", otdelComboBox.SelectedItem.ToString().Trim()), connection).ExecuteScalar());

                        updateCmd.ExecuteNonQuery();
                        listBox1.Items.Remove(fio[0] + " " + fio[1] + " " + fio[2]);
                        listBox1.Items.Add(surnameTextBox.Text + " " + nameTextBox.Text + " " + patrTextBox.Text);
                        listBox1.SelectedItem = surnameTextBox.Text + " " + nameTextBox.Text + " " + patrTextBox.Text;
                    }
                }
                catch(Exception ex)
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

        private void ShowAllForm_Load(object sender, EventArgs e)
        {

        }
        private int id = -1;

        private void countUpDown_ValueChanged(object sender, EventArgs e)
        {
            isAnyFieldChanged = true;
        }
    }
}
