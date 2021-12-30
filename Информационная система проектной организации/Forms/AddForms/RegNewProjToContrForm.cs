using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Информационная_система_проектной_организации
{
    public partial class RegNewProjToContrForm : Form
    {
        UsefullFuncs uff;
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    @"'|DataDirectory|\MainDB.mdf'";
        List<int> cIds;
        private int pid;
        public RegNewProjToContrForm(int projId)
        {
            InitializeComponent();
            pid = projId;
            this.DialogResult = DialogResult.Cancel;
            uff = new UsefullFuncs();
            cIds = new List<int>();
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            fillContracts();
        }
        private void fillContracts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string cmdStr = "SELECT Name From Contract";


                    using (SqlCommand fillCmd = new SqlCommand(cmdStr, connection))
                    {
                        SqlDataReader dr = fillCmd.ExecuteReader();
                        while (dr.Read())
                        {
                            listBox1.Items.Add(dr.GetValue(0).ToString().Trim());
                        }
                        dr.Close();
                    }
                    string selStr = "SELECT Contract.Name From Contract, ProjNContr " +
                        "WHERE contractId = Contract.Id and projectId = @pid"; // ПЕРЕПИСАТЬ
                    cIds.Clear();
                    using (SqlCommand selectCmd = new SqlCommand(selStr, connection))
                    {
                        selectCmd.Parameters.AddWithValue("@pid", pid);
                        SqlDataReader dr1 = selectCmd.ExecuteReader();
                        while (dr1.Read())
                        {
                            listBox1.SelectedItems.Add(dr1.GetValue(0).ToString());
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count != 0)
            { 
                RegisterNewLink();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите хотя бы один договор для привязки проекта!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void RegisterNewLink()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string cmdStr = "INSERT INTO ProjNContr(projectId, contractId) VALUES" +
                        "(@pid, @cid)";
                    string checkValueCmd = "SELECT [Id] FROM [ProjNContr]" +
                        "WHERE @pid = projectId and @cid = contractId";
                    foreach (var name in listBox1.Items)
                    {
                        using (SqlCommand getIdCmd = new SqlCommand("SELECT [Id] FROM Contract WHERE [Name] = @Name", connection))
                        {
                            getIdCmd.Parameters.Clear();
                            getIdCmd.Parameters.AddWithValue("@Name", name);
                            int id = -1;
                            SqlDataReader getDr = getIdCmd.ExecuteReader();
                            if (getDr.Read())
                                id = getDr.GetInt32(0);
                            getDr.Close();
                            if (id != -1)
                            {
                                if (!listBox1.SelectedItems.Contains(name))
                                {
                                    using (SqlCommand delCmd = new SqlCommand("DELETE FROM ProjNContr WHERE " +
                                        "projectId = @pid and contractId = @cid", connection))
                                    {
                                        delCmd.Parameters.Clear();
                                        delCmd.Parameters.AddWithValue("@pid", pid);
                                        delCmd.Parameters.AddWithValue("@cid", id);
                                        delCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    bool alreadyExist = false;
                                    using (SqlCommand checkCmd = new SqlCommand(checkValueCmd, connection))
                                    {
                                        checkCmd.Parameters.Clear();
                                        checkCmd.Parameters.AddWithValue("@cid", id);
                                        checkCmd.Parameters.AddWithValue("@pid", pid);
                                        SqlDataReader dr = checkCmd.ExecuteReader();
                                        while (dr.Read())
                                        {
                                            alreadyExist = true;
                                            break;
                                        }
                                        dr.Close();
                                    }
                                    if (!alreadyExist)
                                    {
                                        using (SqlCommand insertCmd = new SqlCommand(cmdStr, connection))
                                        {
                                            insertCmd.Parameters.AddWithValue("@cid", id);
                                            insertCmd.Parameters.AddWithValue("@pid", pid);
                                            insertCmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                            
                        }
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
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkStr = "SELECT COUNT(*) FROM ProjNContr WHERE contractId = @Id and projectId <> @pid";
                    string cmdstr = "SELECT [Id], [ProjCount], [Name] FROM Contract WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(cmdstr, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", listBox1.SelectedItem);
                        
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            using (SqlCommand checkCmd = new SqlCommand(checkStr, connection))
                            {
                                int count = Convert.ToInt32(dr.GetValue(1));
                                int id = Convert.ToInt32(dr.GetValue(0));
                                string name = dr.GetValue(2).ToString().Trim();
                                checkCmd.Parameters.AddWithValue("@Id", id);
                                checkCmd.Parameters.AddWithValue("@pid", pid);
                                dr.Close();
                                object b = checkCmd.ExecuteScalar();
                                if (b != null)
                                {
                                    if (b.GetType() != typeof(DBNull))
                                    {
                                        if (cIds.Contains(id))
                                        {
                                            cIds.Remove(id);
                                        }
                                        else if(!cIds.Contains(id))
                                        {
                                            if (Convert.ToInt32(b) < count)
                                                cIds.Add(id);
                                            else
                                            {
                                                listBox1.SelectedItems.Remove(listBox1.SelectedItem);
                                                throw new Exception("Выбранный проект уже имеет максимальное количество привязанных проектов!");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (listBox1.SelectedIndices.Count == 0)
                return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    cIds.Clear();
                    foreach (var name in listBox1.SelectedItems)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT [Id] FROM Contract WHERE Name = @Name", connection))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Name", name);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while(dr.Read())
                            {
                                int id = dr.GetInt32(0);
                                if (!cIds.Contains(id))
                                    cIds.Add(id);
                            }
                            dr.Close();
                        }
                    }
                    foreach (var id in cIds)
                    {
                        using (SqlCommand delCmd = new SqlCommand("DELETE FROM ProjNContr WHERE " +
                                                      "projectId = @pid and contractId = @cid", connection))
                        {
                            delCmd.Parameters.Clear();
                            delCmd.Parameters.AddWithValue("@cid", id);
                            delCmd.Parameters.AddWithValue("@pid", pid);
                            delCmd.ExecuteNonQuery();
                        }
                    }
                    cIds.Clear();
                    listBox1.SelectedItems.Clear();
                    MessageBox.Show("Привязанные договора успешно очищены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
