using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Информационная_система_проектной_организации
{
    public partial class ManageOtdelForm : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'D:\!ПРОЕКТ ПО РПО\Информационная система проектной организации\" +
                    @"Информационная система проектной организации\MainDB.mdf';" +
                    @"Integrated Security=True";
        UsefullFuncs uff;
        public ManageOtdelForm()
        {
            InitializeComponent();
            uff = new UsefullFuncs();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Otdel", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    listBox1.Items.Add(dr.GetValue(0));
                dr.Close();
                cmd.CommandText = "SELECT [Name], [Surname], [Patronymic] FROM Employee";
                SqlDataReader empDr = cmd.ExecuteReader();
                while (empDr.Read())
                    fioComboBox.Items.Add(empDr.GetValue(1) + " " + empDr.GetValue(0) + " " + empDr.GetValue(2));
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
        private void UpdateCurrentOtdelInfo()
        {
            try
            {
                string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
                if (name == null)
                {
                    return;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {   
                        connection.Open();
                        string infoCmd = "SELECT * FROM Otdel WHERE Name = @Name";
                        using(SqlCommand cmd = new SqlCommand(infoCmd, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", listBox1.SelectedItem.ToString());
                            SqlDataReader dr = cmd.ExecuteReader();
                            infoPanel.Visible = true;
                            if (dr.Read())
                            {
                                nameTextBox.Text = dr.GetValue(1).ToString();
                                fioComboBox.SelectedItem = dr.GetValue(3).ToString();
                                specTextBox.Text = dr.GetValue(2).ToString();
                            }
                            dr.Close();
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
            UpdateCurrentOtdelInfo();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (name == null)
                        throw new Exception("Ошибка при удалении выбранного отдела! Для удаления выберите один из списка.");
                    connection.Open();
                    string sqlCmd = "DELETE FROM Otdel WHERE [Name] = @Name";
                    using (SqlCommand delCmd = new SqlCommand(sqlCmd, connection))
                    {
                        delCmd.Parameters.AddWithValue("@Name", name);
                        if (delCmd.ExecuteNonQuery() == 0)
                        {
                            throw new Exception("Выбранный отдел не найден в БД!");
                        }
                        else
                        {
                            listBox1.Items.Remove(name);
                            infoPanel.Visible = false;
                            MessageBox.Show("Субподрядная организация успешно удалёна из БД!", "Успех",
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
                if(control.Name.Contains("ComboBox"))
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
            UpdateCurrentOtdelInfo();
            ChangeState();
        }

        private void infoTextBoxes_TextChanged(object sender, EventArgs e)
        {
            isAnyFieldChanged = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
                    if (name == null)
                    {
                        throw new Exception("Ошибка сохранения выбранного отдела!");
                    }
                    string sqlCmd = "UPDATE Otdel SET [Name] = @NewName, ManagerFIO = @Manager, Spec = @Spec" +
                        " WHERE Name = @Name";
                    using (SqlCommand updateCmd = new SqlCommand(sqlCmd, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@Manager", fioComboBox.SelectedItem.ToString().Trim());
                        updateCmd.Parameters.AddWithValue("@Spec", specTextBox.Text);
                        updateCmd.Parameters.AddWithValue("@Name", name);
                        updateCmd.Parameters.AddWithValue("@NewName", nameTextBox.Text);
                        updateCmd.ExecuteNonQuery();
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        listBox1.Items.Add(nameTextBox.Text);
                        listBox1.SelectedItem = nameTextBox.Text;
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
