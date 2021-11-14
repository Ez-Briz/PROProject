using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Информационная_система_проектной_организации
{
    public partial class AdminForm : Form
    {
        UsefullFuncs uff;
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'D:\!ПРОЕКТ ПО РПО\Информационная система проектной организации\" +
                    @"Информационная система проектной организации\MainDB.mdf';" +
                    @"Integrated Security=True";
        public AdminForm()
        {
            InitializeComponent();
            uff = new UsefullFuncs();
            managGroupBox.ForeColor = Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Application.Exit();
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
            this.closeButton.BackColor = uff.moveUpColor;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.BackColor = topPanel.BackColor;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                do
                {
                    dr = ShowDialog(new RegNewProjForm());


                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            throw new Exception("Отмена регистрации проекта.");
                            break;
                        case DialogResult.OK:
                            throw new Exception("Регистрация проекта завершена.");
                            break;
                        case DialogResult.Retry:
                            MessageBox.Show("Проект зарегистрирован. Регистрация ещё одного проекта.");
                            break;
                        case DialogResult.Abort:
                            throw new Exception("Принудительное завершение регистрации проекта.");
                            break;
                    }
                }
                while (dr == DialogResult.Retry);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDialog(new ShowAllForm());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void proj_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void proj_button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = ShowDialog(new RegNewSubForm());
                switch (dr)
                {
                    case DialogResult.Cancel:
                        throw new Exception("Отмена регистрации субподрядной организации.");
                        break;
                    case DialogResult.OK:
                        throw new Exception("Регистрация субподрядной организации завершена.");
                        break;
                    default:
                        throw new Exception("Принудительное завершение регистрации субподрядной организации.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void proj_button5_Click(object sender, EventArgs e)
        {
            ShowDialog(new ManageSubForm());
        }

        private DialogResult ShowDialog(Form form)
        {
            return form.ShowDialog();
        }
        private void managItemsButton_Click(object sender, EventArgs e)
        {
            ShowDialog(new ManageItemForm());
        }

        private void regNewItemButton_Click(object sender, EventArgs e)
        {
            RegNewItemForm regItemForm = new RegNewItemForm();
            try
            {
                DialogResult dr;
                dr = regItemForm.ShowDialog();
                switch (dr)
                {
                    case DialogResult.Cancel:
                        throw new Exception("Отмена добавления инвентарного предмета.");
                        break;
                    case DialogResult.OK:
                        throw new Exception("Добавление инвентарного предмета завершена.");
                        break;
                    default:
                        throw new Exception("Принудительное завершение добавления инвентарного предмета.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void managGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.Black);
        }


        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, topPanel.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);
                g.Clear(this.BackColor);

                g.DrawString(box.Text, topPanel.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void proj_button1_Click(object sender, EventArgs e)
        {
            ShowDialog(new UseItemForm());
        }

        private void proj_button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Name, Price FROM Project WHERE Done = 'True'", connection))
                    {
                        float result = 0;
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<string> list = new List<string>();
                        while (dr.Read())
                        {
                            list.Add(dr.GetString(0).Trim() + " - " + Convert.ToString(dr.GetValue(1)).Trim());
                            result += dr.GetFloat(1);
                        }
                        if (list.Count != 0)
                        {
                            list.Add(string.Format("Прибыль со всех проектов = {0}", result));
                            ShowDialog(new ShowInfoForm(list, "Прибыль с проектов"));
                        }
                        else
                            MessageBox.Show("Не найдено ни одного выполненного проекта!",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                }
            }
        }

        private void proj_button3_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ManagerFIO FROM Suborg", connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<string> list = new List<string>();
                        while(dr.Read())
                        {
                            list.Add(dr.GetString(0).Trim());
                        }
                        if (list.Count != 0)
                            ShowDialog(new ShowInfoForm(list, "Руководители суборганизаций"));
                        else
                            MessageBox.Show("Не найдено ни одного руководителя субподрядных организаций!",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                }
            }
        }

        private void proj_button5_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string cmdStr = "SELECT Item.[Name], A.itemCount FROM(" +
                        "SELECT[ItemId], SUM([Count]) AS itemCount " +
                        "FROM ItemInUse " +
                        "GROUP BY[ItemId] " +
                        ") AS A, Item WHERE Item.[Id] = A.[ItemID]";




    


                    using (SqlCommand cmd = new SqlCommand(cmdStr, connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<string> list = new List<string>();
                        while (dr.Read())
                        {
                            list.Add(dr.GetString(0).Trim() + " - " + dr.GetValue(1).ToString().Trim());
                        }
                        if (list.Count != 0)
                            ShowDialog(new ShowInfoForm(list, "Распределённые предметы"));
                        else
                            MessageBox.Show("Не найдено ни одного распределённого предмета!",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                }
            }
        }

        private void proj_button4_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Name FROM Project", connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<string> list = new List<string>();
                        while (dr.Read())
                        {
                            list.Add(dr.GetString(0).Trim());
                        }
                        if (list.Count != 0)
                            ShowDialog(new ShowInfoForm(list, "Названия проектов"));
                        else
                            MessageBox.Show("Не найдено ни одного зарегистрированного проекта!",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                }
            }
        }

        private void proj_button7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                do
                {
                    dr = ShowDialog(new RegNewEmpForm());


                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            throw new Exception("Отмена регистрации сотрудника.");
                            break;
                        case DialogResult.OK:
                            throw new Exception("Регистрация сотрудника завершена.");
                            break;
                        case DialogResult.Retry:
                            MessageBox.Show("сотрудник зарегистрирован. Регистрация ещё одного сотрудника.");
                            break;
                        case DialogResult.Abort:
                            throw new Exception("Принудительное завершение регистрации сотрудника.");
                            break;
                    }
                }
                while (dr == DialogResult.Retry);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void proj_button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                do
                {
                    dr = ShowDialog(new RegNewOtdelForm());


                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            throw new Exception("Отмена регистрации отдела.");
                            break;
                        case DialogResult.OK:
                            throw new Exception("Регистрация отдела завершена.");
                            break;
                        case DialogResult.Retry:
                            MessageBox.Show("Отдел зарегистрирован. Регистрация ещё одного отдела.");
                            break;
                        case DialogResult.Abort:
                            throw new Exception("Принудительное завершение регистрации отдела.");
                            break;
                    }
                }
                while (dr == DialogResult.Retry);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void proj_button8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                do
                {
                    dr = ShowDialog(new RegNewContrForm());


                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            throw new Exception("Отмена регистрации договора.");
                            break;
                        case DialogResult.OK:
                            throw new Exception("Регистрация договора завершена.");
                            break;
                        case DialogResult.Retry:
                            MessageBox.Show("Договор зарегистрирован. Регистрация ещё одного договора.");
                            break;
                        case DialogResult.Abort:
                            throw new Exception("Принудительное завершение регистрации договора.");
                            break;
                    }
                }
                while (dr == DialogResult.Retry);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void proj_button11_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ManagerFIO FROM Otdel", connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<string> list = new List<string>();
                        while (dr.Read())
                        {
                            list.Add(dr.GetString(0).Trim());
                        }
                        if (list.Count != 0)
                            ShowDialog(new ShowInfoForm(list, "Руководители отделов"));
                        else
                            MessageBox.Show("Не найдено ни одного руководителя отделов!",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                }
            }
        }

        private void proj_button12_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ManagerFIO FROM Contract", connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<string> list = new List<string>();
                        while (dr.Read())
                        {
                            list.Add(dr.GetString(0).Trim());
                        }
                        if (list.Count != 0)
                            ShowDialog(new ShowInfoForm(list, "Руководители договоров"));
                        else
                            MessageBox.Show("Не найдено ни одного руководителя договоров!",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                }
            }
        }

        private void proj_button9_Click(object sender, EventArgs e)
        {
            ShowDialog(new ManageEmpForm());
        }

        private void proj_button10_Click(object sender, EventArgs e)
        {
            ShowDialog(new ManageOtdelForm());
        }

        private void proj_button13_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Name, ProjCount FROM Contract", connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        List<string> list = new List<string>();
                        while (dr.Read())
                        {
                            list.Add(dr.GetString(0).Trim() + " - " + dr.GetValue(1).ToString().Trim());
                        }
                        if (list.Count != 0)
                            ShowDialog(new ShowInfoForm(list, "Названия договоров"));
                        else
                            MessageBox.Show("Не найдено ни одного договора!",
                                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                        connection.Close();
                }
            }
        }
    }
}
