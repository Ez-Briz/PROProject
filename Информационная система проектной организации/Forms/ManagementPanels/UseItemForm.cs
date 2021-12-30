using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Информационная_система_проектной_организации
{
    public partial class UseItemForm : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'|DataDirectory|\MainDB.mdf'";
        UsefullFuncs uff;
        private int id = -1;
        private int projId = -1;
        public UseItemForm()
        {
            InitializeComponent();
            uff = new UsefullFuncs();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand itemCmd = new SqlCommand("SELECT Name FROM Item", connection);
                SqlDataReader itemDr = itemCmd.ExecuteReader();
                while (itemDr.Read())
                    listBox1.Items.Add(itemDr.GetValue(0));
                itemDr.Close();

                SqlCommand projCmd = new SqlCommand("SELECT Name FROM Project", connection);
                SqlDataReader dr = projCmd.ExecuteReader();
                while (dr.Read())
                    listBox2.Items.Add(dr.GetValue(0));
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    object name = listBox1.SelectedItem;
                    
                    if (name == null)
                        throw new Exception("Произошла ошибка при выборе инвентарного предмета!");
                    connection.Open();
                    string sqlCmd = "SELECT [Id] FROM Item WHERE [Name] = @Name";
                    using (SqlCommand getCmd = new SqlCommand(sqlCmd, connection))
                    {
                        getCmd.Parameters.AddWithValue("@Name", name);
                        object a = getCmd.ExecuteScalar();
                        if (a != null)
                            id = Convert.ToInt32(a);
                        else
                            throw new Exception("Произошла ошибка при выборе инвентарного предмета!");
                        listBox2.Visible = true;
                        label1.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (name == null)
                        throw new Exception("Ошибка при удалении выбранного инвентарного предмета со всех проектов! Для удаления выберите один из списка.");
                    connection.Open();
                    string sqlCmd = "DELETE FROM ItemInUse WHERE [ItemID] = @ID";
                    using (SqlCommand delCmd = new SqlCommand(sqlCmd, connection))
                    {
                        delCmd.Parameters.AddWithValue("@ID", id);
                        if (delCmd.ExecuteNonQuery() == 0)
                        {
                            throw new Exception("Выбранный инвентарный предмет не выделен ни на один существующий проект!");
                        }
                        else
                        {
                            MessageBox.Show("Инвентарный предмет успешно удалён из всех проектов!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panel1.Visible = false;
                            listBox1.SelectedItem = null;
                            listBox2.SelectedItem = null;
                        }
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
        private void button1_Click_2(object sender, EventArgs e)
        {
            bool isExist = false;
            if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1)
                return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string cmdStr = "SELECT COUNT(Id) FROM ItemInUse WHERE [ItemID] = @Iid and ProjectID = @Id";
                    using (SqlCommand checkcmd = new SqlCommand(cmdStr, connection))
                    {
                        checkcmd.Parameters.AddWithValue("@Iid", id);
                        checkcmd.Parameters.AddWithValue("@Id", projId);
                        object count = checkcmd.ExecuteScalar();
                        if (Convert.ToInt32(count) > 0)
                            isExist = true;
                    }
                    int inUse = 0;
                    int maxUse = 0;
                    using (SqlCommand getNumber = new SqlCommand("SELECT Count FROM ItemInUse WHERE ItemID = @id", connection))
                    {
                        getNumber.Parameters.AddWithValue("@id", id);
                        SqlDataReader dr = getNumber.ExecuteReader();
                        while(dr.Read())
                            inUse += Convert.ToInt32(dr.GetValue(0));
                        dr.Close();
                    }
                    using (SqlCommand getNumber = new SqlCommand("SELECT Count FROM Item WHERE Id = @id", connection))
                    {
                        getNumber.Parameters.AddWithValue("@id", id);
                        object a = getNumber.ExecuteScalar();
                        if (a != null)
                            maxUse = Convert.ToInt32(a);
                    }
                    int lines = 0;
                    if (maxUse < inUse + countUpDown.Value)
                        throw new Exception("Выбранное количество инвентарных предметов не доступно!\n" +
                            "На данный момент доступно '" + (maxUse - inUse).ToString() + "' единиц.");
                    if (isExist)
                    {
                        if (countUpDown.Value == 0)
                        {
                            string delStr = "DELETE FROM ItemInUse WHERE @IID = ItemID and ProjectID = @PID";
                            using (SqlCommand delCmd = new SqlCommand(delStr, connection))
                            {
                                delCmd.Parameters.AddWithValue("@IID", id);
                                delCmd.Parameters.AddWithValue("@PID", projId);
                                delCmd.ExecuteNonQuery();
                                MessageBox.Show("Выбранный инвентарный предмет удалён с выбранного проекта!", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            string updStr = "UPDATE ItemInUse SET Count = Count + @Count WHERE [ItemID] = @id and ProjectID = @projId";
                            using (SqlCommand updateCmd = new SqlCommand(updStr, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@id", id);
                                updateCmd.Parameters.AddWithValue("@projId", projId);
                                updateCmd.Parameters.AddWithValue("@Count", countUpDown.Value);
                                lines = updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        if (countUpDown.Value == 0)
                            throw new Exception("Выбранный инвентарный предмет не добавлен выбранному проекту." +
                                " Измените количество выдялеяемых инвентарных предметов.");
                        string insStr = "INSERT INTO ItemInUse(Count, ItemID, ProjectID, Date) VALUES (@Count, @id, @projId, @Date)";
                        using (SqlCommand insCmd = new SqlCommand(insStr, connection))
                        {
                            insCmd.Parameters.AddWithValue("@id", id);
                            insCmd.Parameters.AddWithValue("@projId", projId);
                            insCmd.Parameters.AddWithValue("@Count", countUpDown.Value);
                            insCmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                            lines = insCmd.ExecuteNonQuery();
                        }
                    }
                    if (lines > 0)
                    {
                        MessageBox.Show("Инвентарный предмет выделен для нового проекта.", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        throw new Exception("Произошла ошибка при выделении предмета для выбранного проекта!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1 || listBox1.SelectedIndex == -1)
                return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    object name = listBox2.SelectedItem;

                    if (name == null)
                        throw new Exception("Произошла ошибка при выборе проекта!");
                    connection.Open();
                    string sqlCmd = "SELECT [Id] FROM Project WHERE [Name] = @Name";
                    using (SqlCommand getCmd = new SqlCommand(sqlCmd, connection))
                    {
                        getCmd.Parameters.AddWithValue("@Name", name.ToString());
                        object a = getCmd.ExecuteScalar();
                        if (a != null)
                            projId = Convert.ToInt32(a);
                        else
                            throw new Exception("Произошла ошибка при выборе проекта!");
                    }
                    string sqlShowCmd = "SELECT [Count] FROM ItemInUse WHERE ProjectID = @PID and ItemID = @IID";
                    using (SqlCommand getCmd = new SqlCommand(sqlShowCmd, connection))
                    {
                        getCmd.Parameters.AddWithValue("@PID", projId);
                        getCmd.Parameters.AddWithValue("@IID", id);
                        object a = getCmd.ExecuteScalar();
                        if (a != null)
                            countUpDown.Value = Convert.ToInt32(a);
                        else
                            countUpDown.Value = 0;
                    }
                    panel1.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
