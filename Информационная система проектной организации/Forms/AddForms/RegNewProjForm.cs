using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Информационная_система_проектной_организации
{
    public partial class RegNewProjForm : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'D:\!ПРОЕКТ ПО РПО\Информационная система проектной организации\" +
                    @"Информационная система проектной организации\MainDB.mdf';" +
                    @"Integrated Security=True";
        UsefullFuncs uff;
        int contrId = -1;
        List<Control> Points;
        public RegNewProjForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            Points = new List<Control>();
            PointTextBox.Name = "pointTextBox0";
            Points.Add(PointTextBox);
            uff = new UsefullFuncs();
            //fillContracts();
        }
        //private void fillContracts()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            string cmdStr = "SELECT Name From Contract";


        //            using (SqlCommand fillCmd = new SqlCommand(cmdStr, connection))
        //            {
        //                SqlDataReader dr = fillCmd.ExecuteReader();
        //                while (dr.Read())
        //                {
        //                    typeComboBox.Items.Add(dr.GetValue(0).ToString().Trim());
        //                }
        //                dr.Close();
        //            }
        //            this.DialogResult = DialogResult.OK;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Ошибка",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            this.DialogResult = DialogResult.Abort;
        //        }
        //        finally
        //        {
        //            if (connection.State != ConnectionState.Closed)
        //                connection.Close();
        //        }
        //    }
        //}
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
            bool ok = true;
            if (nameTextBox.Text.Length > 0 || subjTextBox.Text.Length > 0 ||
                PointTextBox.Text.Length > 0 || priceTextBox.Text.Length > 0)
            {
                foreach (var a in Points)
                {
                    if (a.Name.Contains("TextBox") && a.Text.Length < 5)
                    {
                        ok = false;
                        break;
                    }
                }
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        //private void RegisterNewProjNContr()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            string cmdStr = "INSERT INTO ProjNContr(projectId, contractId) VALUES (@PID, @CID)";
        //            int projId = -1;
        //            using (SqlCommand getIdCmd = new SqlCommand("SELECT [Id] FROM Project WHERE Name = @Name", connection))
        //            {
        //                getIdCmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
        //                SqlDataReader dr = getIdCmd.ExecuteReader();
        //                if (dr.Read())
        //                    projId = dr.GetInt32(0);
        //                else
        //                {
        //                    dr.Close();
        //                    throw new Exception("Ошибка при обновлении Базы Данных!");
        //                }
        //                dr.Close();
        //            }
        //            using (SqlCommand fillCmd = new SqlCommand(cmdStr, connection))
        //            {
        //                fillCmd.Parameters.AddWithValue("@PID", projId);
        //                fillCmd.Parameters.AddWithValue("@CID", contrId);
        //                fillCmd.ExecuteNonQuery();
        //            }
        //            this.DialogResult = DialogResult.OK;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Ошибка",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            this.DialogResult = DialogResult.Abort;
        //        }
        //        finally
        //        {
        //            if (connection.State != ConnectionState.Closed)
        //                connection.Close();
        //        }
        //    }
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (checkAllFields())
            {
                RegisterNewProject();
                //RegisterNewProjNContr();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля перед регистрацией проекта!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkAllFields())
            {
                RegisterNewProject();
                this.DialogResult = DialogResult.Retry;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля перед регистрацией проекта!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void RegisterNewProject()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string cmdStr = "INSERT INTO Project([Name], [Price], [Subject], [Points], [StartDate], [EndDate]) VALUES" +
                        "(@Name, @Price, @Subject, @Points, @SD, @ED)";
                    string checkValueCmd = "SELECT [Project].[ID] FROM [Project]" +
                        "WHERE @Name = [Project].[Name]";
                    bool alreadyExist = false;
                    using(SqlCommand checkCmd = new SqlCommand(checkValueCmd, connection))
                    { 
                        checkCmd.Parameters.AddWithValue("@Name", 
                            nameTextBox.Text.Length > 1 ? nameTextBox.Text : "None");
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
                                nameTextBox.Text.Length > 1 ? nameTextBox.Text : "None");
                            insertCmd.Parameters.AddWithValue("@Price",
                                priceTextBox.Text);
                            insertCmd.Parameters.AddWithValue("@Subject",
                                subjTextBox.Text);
                            string pointsStr = "";
                            foreach (var control in Points)
                            {
                                if (control.Name.Contains("pointTextBox"))
                                {
                                    if (control.Text.Length > 5)
                                    {
                                        pointsStr += control.Text + '\n';
                                    }
                                }
                            }
                            insertCmd.Parameters.AddWithValue("@Points",
                                pointsStr);
                            insertCmd.Parameters.AddWithValue("@SD", startDatePicker.Value);
                            insertCmd.Parameters.AddWithValue("@ED", endDatePicker.Value);
                            insertCmd.ExecuteNonQuery();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                        throw new Exception("Проект с таким названием уже существует!");
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
                    Close();
                }
            }
        }


        int pointCount = 1;
        const int MAX_COUNT = 9;
        private void button3_Click(object sender, EventArgs e)
        {
            if (pointCount == MAX_COUNT)
            {
                MessageBox.Show("Достигнут лимит количества целей.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Label label = new Label();
            Font lastFont = PointLabel.Font;
            TextBox textbox = new TextBox();
            textbox.Text = "";
            Point textlocation = PointTextBox.Location;
            textlocation.Y += pointCount * 40;
            textbox.Location = textlocation;
            textbox.Width = PointTextBox.Width;
            label.RightToLeft = RightToLeft.Yes;
            label.Font = lastFont;
            textbox.Font = lastFont;
            label.Text = ":" + "Цель " + (pointCount + 1).ToString();
            label.Width = PointLabel.Width;
            Point location = PointLabel.Location;
            location.Y += pointCount++ * 40;
            label.Location = location;
            label.Name = "pointLabel" + pointCount.ToString();
            textbox.Name = "pointTextBox" + pointCount.ToString();
            this.Controls.Add(label);
            this.Controls.Add(textbox);
            Points.Add(label);
            Points.Add(textbox);
            
            this.Height += 40;
        }

        private void delPointButton_Click(object sender, EventArgs e)
        {
            if (pointCount == 1)
            {
                MessageBox.Show("Невозможно удалить первую строку целей.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Control> toDelete = new List<Control>();
            for(int i = 0; i<Points.Count; i++)
            {
                Control control = Points[i]; 
                if (control.Name == "pointLabel"+pointCount ||
                    control.Name == "pointTextBox"+pointCount)
                {
                    toDelete.Add(control);
                    this.Controls.Remove(control);
                    
                }
            }
            foreach (var a in toDelete)
            {
                Points.Remove(a);
                a.Dispose();
            }
            if (toDelete.Count != 0)
            {
                pointCount--;
                this.Height -= 40;
            }
        }

        //private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (typeComboBox.SelectedIndex == -1)
        //        return;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            string checkStr = "SELECT COUNT(*) FROM ProjNContr WHERE contractId = @Id";
        //            string cmdstr = "SELECT [Id], [ProjCount] FROM Contract WHERE Name = @Name";
        //            using (SqlCommand cmd = new SqlCommand(cmdstr, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@Name", typeComboBox.SelectedItem);
        //                SqlDataReader dr = cmd.ExecuteReader();
        //                if (dr.Read())
        //                {
        //                    using (SqlCommand checkCmd = new SqlCommand(checkStr, connection))
        //                    {
        //                        int count = Convert.ToInt32(dr.GetValue(1));
        //                        int id = Convert.ToInt32(dr.GetValue(0));
        //                        checkCmd.Parameters.AddWithValue("@Id", id);
        //                        dr.Close();
        //                        object b = checkCmd.ExecuteScalar();
        //                        if (b != null)
        //                            if (b.GetType() != typeof(DBNull))
        //                                if (Convert.ToInt32(b) < count)
        //                                    contrId = id;
        //                                else
        //                                    throw new Exception("Выбранный проект уже имеет максимальное количество привязанных проектов!");
        //                    }
        //                }
        //            }
        //        }
        //        catch(Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            contrId = -1;
        //        }
        //        finally
        //        {
        //            if (connection.State != ConnectionState.Closed)
        //                connection.Close();
        //        }
        //    }
        //}
    }
}
