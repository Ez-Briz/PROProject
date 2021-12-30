using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Информационная_система_проектной_организации
{
    public partial class ManageItemForm : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'|DataDirectory|\MainDB.mdf'";
        UsefullFuncs uff;
        private int id = -1;
        public ManageItemForm()
        {
            InitializeComponent();
            uff = new UsefullFuncs();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Item", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    listBox1.Items.Add(dr.GetValue(0));
                dr.Close();
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
        private void UpdateCurrentItemInfo()
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
                        string infoCmd = "SELECT * FROM Item WHERE Name = @Name";
                        using(SqlCommand cmd = new SqlCommand(infoCmd, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", listBox1.SelectedItem.ToString());
                            SqlDataReader dr = cmd.ExecuteReader();
                            infoPanel.Visible = true;
                            if (dr.Read())
                            {
                                descTextBox.Text = dr.GetValue(2).ToString();
                                countUpDown.Value = Convert.ToInt32(dr.GetValue(3));
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
            UpdateCurrentItemInfo();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (name == null)
                        throw new Exception("Ошибка при удалении выбранного инвентарного предмета! Для удаления выберите один из списка.");
                    connection.Open();
                    string sqlCmd = "DELETE FROM Item WHERE [Name] = @Name";
                    using (SqlCommand delCmd = new SqlCommand(sqlCmd, connection))
                    {
                        delCmd.Parameters.AddWithValue("@Name", name);
                        if (delCmd.ExecuteNonQuery() == 0)
                        {
                            throw new Exception("Выбранный инвентарный предмет не найден в БД!");
                        }
                        else
                        {
                            listBox1.Items.Remove(name);
                            infoPanel.Visible = false;
                            MessageBox.Show("Инвентарный предмет успешно удалён из БД!", "Успех",
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
                if (control.Name.Contains("Label") || control.Name.Contains("GroupBox"))
                    continue;
                if(control.Name.Contains("UpDown"))
                {
                    NumericUpDown up = control as NumericUpDown;
                    control.Enabled = editable;
                    continue;
                }
                TextBox tb = control as TextBox;
                tb.ReadOnly = !editable;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            UpdateCurrentItemInfo();
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
                        throw new Exception("Ошибка сохранения выбранного инвентарного предмета!");
                    }
                    string sqlCmd = "UPDATE Item SET Description = @Desc, Count = @Count" +
                        " WHERE Name = @Name";
                    using (SqlCommand updateCmd = new SqlCommand(sqlCmd, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@Desc", descTextBox.Text);
                        updateCmd.Parameters.AddWithValue("@Count", countUpDown.Value);
                        updateCmd.Parameters.AddWithValue("@Name", name);
                        updateCmd.ExecuteNonQuery();
                    }
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
            ChangeState();
        }
        

        private void countUpDown_ValueChanged(object sender, EventArgs e)
        {
            isAnyFieldChanged = true;
        }
    }
}
