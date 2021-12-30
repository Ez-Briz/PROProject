using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Информационная_система_проектной_организации
{
    public partial class ShowAllForm : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'|DataDirectory|\MainDB.mdf'";
        UsefullFuncs uff;
        List<Control> Points;
        int pointCount = 1;
        bool done = false;
        int currentProjId = -1;
        Point last;
        private int id = -2;
        bool editable = false;
        bool isAnyFieldChanged = false;
        public ShowAllForm()
        {
            InitializeComponent();
            uff = new UsefullFuncs();
            Points = new List<Control>();
            DateTime dt = DateTime.Now;
            startDatePicker.MinDate = dt.AddYears(-1);
            endDatePicker.MinDate = dt.AddYears(-1);
            dt = dt.AddYears(1);
            endDatePicker.MaxDate = dt;
            startDatePicker.MaxDate = dt;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlCmd = "SELECT * FROM [Project]";
                    using (SqlCommand selectCmd = new SqlCommand(sqlCmd, connection))
                    {
                        SqlDataReader dr = selectCmd.ExecuteReader();
                        while (dr.Read())
                        {
                            listBox1.Items.Add(dr.GetValue(1));
                        }
                        dr.Close();
                    }
                    string orgCmdStr = "SELECT [Name] FROM [Suborg]";
                    using (SqlCommand orgCmd = new SqlCommand(orgCmdStr, connection))
                    {
                        SqlDataReader dr1 = orgCmd.ExecuteReader();
                        while (dr1.Read())
                        {
                            orgComboBox.Items.Add(dr1.GetValue(0));
                        }
                        dr1.Close();
                    }
                }
                catch (Exception ex)
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
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
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
        private void UpdateCurrentProjectInfo()
        {
            try
            {
                if (Points.Count > 0)
                {
                    List<Control> toDelete = new List<Control>();
                    for (int i = 0; i < Points.Count; i++)
                    {
                        Control control = Points[i];
                        toDelete.Add(control);
                        pointsGroupBox.Controls.Remove(control);
                    }
                    if (pointCount > 5)
                    {
                        this.Height -= (pointCount - 6) * 60;
                        pointsGroupBox.Height -= (pointCount - 6) * 60;
                        infoPanel.Height -= (pointCount - 6) * 60;

                    }
                    pointCount -= toDelete.Count / 2;
                    foreach (var a in toDelete)
                    {
                        Points.Remove(a);
                        a.Dispose();
                    }
                }
                string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
                if (name == null)
                {
                    return;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        int SubOrgID = -1;
                        connection.Open();
                        string sqlCmd = "SELECT [Subject], [Price], [Points], [SubOrgID], [Done], [StartDate], [EndDate], [Id]FROM [Project] WHERE @Name = [Name]";
                        using (SqlCommand selectCmd = new SqlCommand(sqlCmd, connection))
                        {
                            selectCmd.Parameters.AddWithValue("@Name", name);
                            SqlDataReader dr = selectCmd.ExecuteReader();
                            if (dr.Read())
                            {
                                infoPanel.Visible = true;
                                subjTextBox.Text = dr.GetValue(0).ToString();
                                priceTextBox.Text = dr.GetValue(1).ToString();
                                string[] arr = dr.GetValue(2).ToString().Split('\n');
                                ChangeProjState(dr.GetBoolean(4));
                                done = dr.GetBoolean(4);
                                SubOrgID = Convert.ToInt32(dr.GetValue(3));
                                startDatePicker.Value = dr.GetDateTime(5);
                                endDatePicker.Value = dr.GetDateTime(6);
                                currentProjId = Convert.ToInt32(dr.GetValue(7));

                                for (int i = 0; i < arr.Length - 1; i++)
                                {
                                    if (i > 0)
                                    {
                                        if (i > 5)
                                        {
                                            this.Height += 60;
                                            pointsGroupBox.Height += 60;
                                            infoPanel.Height += 60;
                                        }
                                        Label label = new Label();
                                        TextBox textbox = new TextBox();
                                        textbox.Text = arr[i];
                                        Point textlocation = pointTextBox0.Location;
                                        textlocation.Y += pointCount * 40;
                                        textbox.Location = textlocation;
                                        textbox.Width = pointTextBox0.Width;
                                        label.Text = ":" + "Цель " + (pointCount + 1).ToString();
                                        label.RightToLeft = RightToLeft.Yes;
                                        label.Width = pointLabel0.Width;
                                        Point location = pointLabel0.Location;
                                        location.Y += pointCount++ * 40;
                                        label.Location = location;
                                        label.Name = "pointLabel" + pointCount.ToString();
                                        textbox.Name = "pointTextBox" + pointCount.ToString();
                                        textbox.ReadOnly = !editable;
                                        textbox.TextChanged += new System.EventHandler(this.infoTextBoxes_TextChanged);
                                        pointsGroupBox.Controls.Add(label);
                                        pointsGroupBox.Controls.Add(textbox);
                                        Points.Add(label);
                                        Points.Add(textbox);
                                    }
                                    else
                                    {
                                        pointTextBox0.Text = arr[i];
                                    }
                                }
                            }
                            dr.Close();
                        }
                        if (SubOrgID != -1)
                        {
                            string orgCmdStr = "SELECT [Name] FROM [Suborg] WHERE @Id = [Id]";
                            using (SqlCommand orgCmd = new SqlCommand(orgCmdStr, connection))
                            {
                                orgCmd.Parameters.AddWithValue("@Id", SubOrgID);
                                object orgName = orgCmd.ExecuteScalar();
                                orgComboBox.SelectedItem = orgName;
                            }
                        }
                        else
                        {
                            orgComboBox.SelectedItem = null;
                            orgComboBox.Text = "Отсутствует";
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
        private void ChangeProjState(bool boolean)
        {
            if (boolean)
            {
                currentStateLabel.Text = "завершён";
                currentStateLabel.ForeColor = Color.Green;
            }
            else
            {
                currentStateLabel.Text = "в процессе выполнения";
                currentStateLabel.ForeColor = Color.Red;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editable)
                ChangeState();
            if (listBox1.SelectedIndex == -1)
                return;
            UpdateCurrentProjectInfo();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (name == null)
                        throw new Exception("Ошибка при удалении выбранного проекта! Для удаления выберите один из проектов.");
                    connection.Open();
                    string sqlCmd = "DELETE FROM Project WHERE [Name] = @Name";
                    using (SqlCommand delCmd = new SqlCommand(sqlCmd, connection))
                    {
                        delCmd.Parameters.AddWithValue("@Name", name);
                        if (delCmd.ExecuteNonQuery() == 0)
                        {
                            throw new Exception("Выбранный проект не найден в БД!");
                        }
                        else
                        {
                            listBox1.Items.Remove(name);
                            infoPanel.Visible = false;
                            currentStateLabel.Text = "не выбран";
                            currentStateLabel.ForeColor = Color.Black;
                            MessageBox.Show("Проект успешно удалён из БД!", "Успех",
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
        private void ChangeState()
        {
            if (infoPanel.Visible == false)
                return;
            editable = !editable;
            changeStateButton.Visible = editable;
            saveButton.Visible = editable;
            delButton.Enabled = !editable;
            foreach (Control control in infoPanel.Controls)
            {
                if (control.Name.Contains("Label") || control.Name.Contains("GroupBox"))
                    continue;
                if (control.Name.Contains("ComboBox") || control.Name.Contains("Button") || control.Name.Contains("DatePicker"))
                {
                    control.Enabled = editable;
                    continue;
                }
                TextBox tb = control as TextBox;
                tb.ReadOnly = !editable;    
            }
            foreach (Control control in pointsGroupBox.Controls)
            {
                if (control.Name.Contains("Label") || control.Name.Contains("GroupBox"))
                    continue;
                TextBox tb = control as TextBox;
                tb.ReadOnly = !editable;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            UpdateCurrentProjectInfo();
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
                    bool alreadyInUse = false;
                    connection.Open();
                    string checkCmd = "SELECT COUNT(*) FROM Project WHERE SubOrgID = @sub and Name <> @Name";
                    using (SqlCommand check = new SqlCommand(checkCmd, connection))
                    {
                        if (id > 0)
                        {
                            check.Parameters.AddWithValue("@sub", id);
                            check.Parameters.AddWithValue("@Name", listBox1.SelectedItem);
                            object a = check.ExecuteScalar();
                            if (a != null)
                                if (Convert.ToInt32(a) > 0)
                                    alreadyInUse = true;
                        }
                    }
                    if (alreadyInUse)
                    {
                        MessageBox.Show("Выбранная субподрядная организация уже задейстована в одном из проектов!", "Ошибка"
                            ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string sqlCmd;
                    if (!done)
                         sqlCmd = "UPDATE Project SET Subject=@Subj, Price=@Price, " +
                        "Points=@Points, SubOrgID = @Org, Done = @Done, StartDate = @SD, EndDate = @ED, WhenEnded = NULL WHERE Name = @Name";
                    else
                        sqlCmd = "UPDATE Project SET Subject=@Subj, Price=@Price, " +
                        "Points=@Points, SubOrgID = @Org, Done = @Done, StartDate = @SD, EndDate = @ED, WhenEnded = @WD WHERE Name = @Name";

                    using (SqlCommand updateCmd = new SqlCommand(sqlCmd, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@Subj", subjTextBox.Text);
                        updateCmd.Parameters.AddWithValue("@Price", priceTextBox.Text);
                        string pointsStr = pointTextBox0.Text + '\n';
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
                        updateCmd.Parameters.AddWithValue("@Points", pointsStr);
                        string name = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : null;
                        if (name == null)
                            return;
                        updateCmd.Parameters.AddWithValue("@Name", name);
                        updateCmd.Parameters.AddWithValue("@Done", done);
                        if (done)
                            updateCmd.Parameters.AddWithValue("@WD", DateTime.Now);
                        updateCmd.Parameters.AddWithValue("@Org", id);
                        updateCmd.Parameters.AddWithValue("@SD", startDatePicker.Value);
                        updateCmd.Parameters.AddWithValue("@ED", endDatePicker.Value);
                        updateCmd.ExecuteNonQuery();
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
            ChangeState();
        }
        private void ShowAllForm_Load(object sender, EventArgs e)
        {

        }
        private void orgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orgComboBox.SelectedIndex == -1)
            {
                id = -2;
                return;
            }
            isAnyFieldChanged = true;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Id FROM Suborg WHERE Name = @Name", connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", orgComboBox.SelectedItem);
                        id = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
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
        private void proj_button1_Click(object sender, EventArgs e)
        {
            orgComboBox.SelectedItem = null;
            orgComboBox.Text = "Отсутствует";
            id = -1;
        }
        private void proj_button1_Click_1(object sender, EventArgs e)
        {
            done = !done;
            ChangeProjState(done);
        }
        private void proj_button1_Click_2(object sender, EventArgs e)
        {
            RegNewProjToContrForm form = new RegNewProjToContrForm(currentProjId);
            form.ShowDialog();
        }
    }
}
