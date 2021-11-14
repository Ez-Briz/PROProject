
namespace Информационная_система_проектной_организации
{
    partial class AdminForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.managGroupBox = new System.Windows.Forms.GroupBox();
            this.proj_button10 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button9 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button1 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.managProjButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.managItemsButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.managOrgButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proj_button8 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button6 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button7 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.regNewItemButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.regNewProjButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.regNewSubButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.proj_button13 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button3 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button12 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button2 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button11 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button4 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_button5 = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.proj_line1 = new Информационная_система_проектной_организации.CustomElements.proj_line();
            this.proj_line2 = new Информационная_система_проектной_организации.CustomElements.proj_line();
            this.exitButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.managGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Font = new System.Drawing.Font("Century Schoolbook", 11.25F);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(734, 40);
            this.topPanel.TabIndex = 7;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(694, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = " X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.Black;
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.InitialImage")));
            this.iconPictureBox.Location = new System.Drawing.Point(5, 5);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 4;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconPictureBox_MouseDown);
            this.iconPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconPictureBox_MouseMove);
            // 
            // mainToolTip
            // 
            this.mainToolTip.AutoPopDelay = 5000;
            this.mainToolTip.InitialDelay = 300;
            this.mainToolTip.IsBalloon = true;
            this.mainToolTip.ReshowDelay = 0;
            this.mainToolTip.ShowAlways = true;
            // 
            // managGroupBox
            // 
            this.managGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.managGroupBox.Controls.Add(this.proj_button10);
            this.managGroupBox.Controls.Add(this.proj_button9);
            this.managGroupBox.Controls.Add(this.proj_button1);
            this.managGroupBox.Controls.Add(this.managProjButton);
            this.managGroupBox.Controls.Add(this.managItemsButton);
            this.managGroupBox.Controls.Add(this.managOrgButton);
            this.managGroupBox.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managGroupBox.Location = new System.Drawing.Point(5, 208);
            this.managGroupBox.Name = "managGroupBox";
            this.managGroupBox.Size = new System.Drawing.Size(725, 138);
            this.managGroupBox.TabIndex = 1;
            this.managGroupBox.TabStop = false;
            this.managGroupBox.Text = "Панели управления";
            this.managGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.managGroupBox_Paint);
            // 
            // proj_button10
            // 
            this.proj_button10.BackColor = System.Drawing.Color.White;
            this.proj_button10.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button10.ForeColor = System.Drawing.Color.Black;
            this.proj_button10.Location = new System.Drawing.Point(367, 27);
            this.proj_button10.Name = "proj_button10";
            this.proj_button10.Size = new System.Drawing.Size(340, 30);
            this.proj_button10.TabIndex = 5;
            this.proj_button10.Text = "Панель управления отделами";
            this.proj_button10.Click += new System.EventHandler(this.proj_button10_Click);
            // 
            // proj_button9
            // 
            this.proj_button9.BackColor = System.Drawing.Color.White;
            this.proj_button9.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button9.ForeColor = System.Drawing.Color.Black;
            this.proj_button9.Location = new System.Drawing.Point(367, 63);
            this.proj_button9.Name = "proj_button9";
            this.proj_button9.Size = new System.Drawing.Size(340, 30);
            this.proj_button9.TabIndex = 4;
            this.proj_button9.Text = "Панель управления сотрудниками";
            this.proj_button9.Click += new System.EventHandler(this.proj_button9_Click);
            // 
            // proj_button1
            // 
            this.proj_button1.BackColor = System.Drawing.Color.White;
            this.proj_button1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button1.ForeColor = System.Drawing.Color.Black;
            this.proj_button1.Location = new System.Drawing.Point(367, 99);
            this.proj_button1.Name = "proj_button1";
            this.proj_button1.Size = new System.Drawing.Size(340, 30);
            this.proj_button1.TabIndex = 3;
            this.proj_button1.Text = "Панель распределения инвентаря";
            this.proj_button1.Click += new System.EventHandler(this.proj_button1_Click);
            // 
            // managProjButton
            // 
            this.managProjButton.BackColor = System.Drawing.Color.White;
            this.managProjButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managProjButton.ForeColor = System.Drawing.Color.Black;
            this.managProjButton.Location = new System.Drawing.Point(8, 27);
            this.managProjButton.Name = "managProjButton";
            this.managProjButton.Size = new System.Drawing.Size(340, 30);
            this.managProjButton.TabIndex = 0;
            this.managProjButton.Text = "Панель управления проектами";
            this.managProjButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // managItemsButton
            // 
            this.managItemsButton.BackColor = System.Drawing.Color.White;
            this.managItemsButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managItemsButton.ForeColor = System.Drawing.Color.Black;
            this.managItemsButton.Location = new System.Drawing.Point(8, 99);
            this.managItemsButton.Name = "managItemsButton";
            this.managItemsButton.Size = new System.Drawing.Size(340, 30);
            this.managItemsButton.TabIndex = 2;
            this.managItemsButton.Text = "Панель управления инвентарём";
            this.managItemsButton.Click += new System.EventHandler(this.managItemsButton_Click);
            // 
            // managOrgButton
            // 
            this.managOrgButton.BackColor = System.Drawing.Color.White;
            this.managOrgButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managOrgButton.ForeColor = System.Drawing.Color.Black;
            this.managOrgButton.Location = new System.Drawing.Point(8, 63);
            this.managOrgButton.Name = "managOrgButton";
            this.managOrgButton.Size = new System.Drawing.Size(340, 30);
            this.managOrgButton.TabIndex = 1;
            this.managOrgButton.Text = "Панель управления организациями";
            this.managOrgButton.Click += new System.EventHandler(this.proj_button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.proj_button8);
            this.groupBox1.Controls.Add(this.proj_button6);
            this.groupBox1.Controls.Add(this.proj_button7);
            this.groupBox1.Controls.Add(this.regNewItemButton);
            this.groupBox1.Controls.Add(this.regNewProjButton);
            this.groupBox1.Controls.Add(this.regNewSubButton);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(5, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню добавления";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.managGroupBox_Paint);
            // 
            // proj_button8
            // 
            this.proj_button8.BackColor = System.Drawing.Color.White;
            this.proj_button8.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button8.ForeColor = System.Drawing.Color.Black;
            this.proj_button8.Location = new System.Drawing.Point(367, 25);
            this.proj_button8.Name = "proj_button8";
            this.proj_button8.Size = new System.Drawing.Size(340, 30);
            this.proj_button8.TabIndex = 6;
            this.proj_button8.Text = "Заключить новый договор";
            this.proj_button8.Click += new System.EventHandler(this.proj_button8_Click);
            // 
            // proj_button6
            // 
            this.proj_button6.BackColor = System.Drawing.Color.White;
            this.proj_button6.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button6.ForeColor = System.Drawing.Color.Black;
            this.proj_button6.Location = new System.Drawing.Point(367, 68);
            this.proj_button6.Name = "proj_button6";
            this.proj_button6.Size = new System.Drawing.Size(340, 30);
            this.proj_button6.TabIndex = 5;
            this.proj_button6.Text = "Добавить новый отдел";
            this.proj_button6.Click += new System.EventHandler(this.proj_button6_Click);
            // 
            // proj_button7
            // 
            this.proj_button7.BackColor = System.Drawing.Color.White;
            this.proj_button7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button7.ForeColor = System.Drawing.Color.Black;
            this.proj_button7.Location = new System.Drawing.Point(367, 112);
            this.proj_button7.Name = "proj_button7";
            this.proj_button7.Size = new System.Drawing.Size(340, 30);
            this.proj_button7.TabIndex = 3;
            this.proj_button7.Text = "Зарегистрировать нового сотрудника";
            this.proj_button7.Click += new System.EventHandler(this.proj_button7_Click);
            // 
            // regNewItemButton
            // 
            this.regNewItemButton.BackColor = System.Drawing.Color.White;
            this.regNewItemButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNewItemButton.ForeColor = System.Drawing.Color.Black;
            this.regNewItemButton.Location = new System.Drawing.Point(8, 112);
            this.regNewItemButton.Name = "regNewItemButton";
            this.regNewItemButton.Size = new System.Drawing.Size(340, 30);
            this.regNewItemButton.TabIndex = 2;
            this.regNewItemButton.Text = "Добавить новый инвентарный предмет";
            this.regNewItemButton.Click += new System.EventHandler(this.regNewItemButton_Click);
            // 
            // regNewProjButton
            // 
            this.regNewProjButton.BackColor = System.Drawing.Color.White;
            this.regNewProjButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNewProjButton.ForeColor = System.Drawing.Color.Black;
            this.regNewProjButton.Location = new System.Drawing.Point(8, 25);
            this.regNewProjButton.Name = "regNewProjButton";
            this.regNewProjButton.Size = new System.Drawing.Size(340, 30);
            this.regNewProjButton.TabIndex = 0;
            this.regNewProjButton.Text = "Зарегистрировать новый проект";
            this.regNewProjButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // regNewSubButton
            // 
            this.regNewSubButton.BackColor = System.Drawing.Color.White;
            this.regNewSubButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNewSubButton.ForeColor = System.Drawing.Color.Black;
            this.regNewSubButton.Location = new System.Drawing.Point(8, 61);
            this.regNewSubButton.Name = "regNewSubButton";
            this.regNewSubButton.Size = new System.Drawing.Size(340, 45);
            this.regNewSubButton.TabIndex = 1;
            this.regNewSubButton.Text = "Зарегистрировать новую субподрядную организацию";
            this.regNewSubButton.Click += new System.EventHandler(this.proj_button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.proj_button13);
            this.groupBox2.Controls.Add(this.proj_button3);
            this.groupBox2.Controls.Add(this.proj_button12);
            this.groupBox2.Controls.Add(this.proj_button2);
            this.groupBox2.Controls.Add(this.proj_button11);
            this.groupBox2.Controls.Add(this.proj_button4);
            this.groupBox2.Controls.Add(this.proj_button5);
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(5, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 137);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информационные панели";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.managGroupBox_Paint);
            // 
            // proj_button13
            // 
            this.proj_button13.BackColor = System.Drawing.Color.White;
            this.proj_button13.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button13.ForeColor = System.Drawing.Color.Black;
            this.proj_button13.Location = new System.Drawing.Point(581, 25);
            this.proj_button13.Name = "proj_button13";
            this.proj_button13.Size = new System.Drawing.Size(138, 47);
            this.proj_button13.TabIndex = 21;
            this.proj_button13.Text = "Список всех договоров";
            this.proj_button13.Click += new System.EventHandler(this.proj_button13_Click);
            // 
            // proj_button3
            // 
            this.proj_button3.BackColor = System.Drawing.Color.White;
            this.proj_button3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button3.ForeColor = System.Drawing.Color.Black;
            this.proj_button3.Location = new System.Drawing.Point(233, 25);
            this.proj_button3.Name = "proj_button3";
            this.proj_button3.Size = new System.Drawing.Size(156, 47);
            this.proj_button3.TabIndex = 3;
            this.proj_button3.Text = "Руководители организаций";
            this.proj_button3.Click += new System.EventHandler(this.proj_button3_Click_1);
            // 
            // proj_button12
            // 
            this.proj_button12.BackColor = System.Drawing.Color.White;
            this.proj_button12.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button12.ForeColor = System.Drawing.Color.Black;
            this.proj_button12.Location = new System.Drawing.Point(513, 78);
            this.proj_button12.Name = "proj_button12";
            this.proj_button12.Size = new System.Drawing.Size(206, 47);
            this.proj_button12.TabIndex = 20;
            this.proj_button12.Text = "Руководители договоров";
            this.proj_button12.Click += new System.EventHandler(this.proj_button12_Click);
            // 
            // proj_button2
            // 
            this.proj_button2.BackColor = System.Drawing.Color.White;
            this.proj_button2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button2.ForeColor = System.Drawing.Color.Black;
            this.proj_button2.Location = new System.Drawing.Point(8, 25);
            this.proj_button2.Name = "proj_button2";
            this.proj_button2.Size = new System.Drawing.Size(219, 47);
            this.proj_button2.TabIndex = 2;
            this.proj_button2.Text = "Прибыль с готовых проектов";
            this.proj_button2.Click += new System.EventHandler(this.proj_button2_Click);
            // 
            // proj_button11
            // 
            this.proj_button11.BackColor = System.Drawing.Color.White;
            this.proj_button11.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button11.ForeColor = System.Drawing.Color.Black;
            this.proj_button11.Location = new System.Drawing.Point(395, 25);
            this.proj_button11.Name = "proj_button11";
            this.proj_button11.Size = new System.Drawing.Size(180, 47);
            this.proj_button11.TabIndex = 19;
            this.proj_button11.Text = "Руководители отделов";
            this.proj_button11.Click += new System.EventHandler(this.proj_button11_Click);
            // 
            // proj_button4
            // 
            this.proj_button4.BackColor = System.Drawing.Color.White;
            this.proj_button4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button4.ForeColor = System.Drawing.Color.Black;
            this.proj_button4.Location = new System.Drawing.Point(315, 78);
            this.proj_button4.Name = "proj_button4";
            this.proj_button4.Size = new System.Drawing.Size(192, 47);
            this.proj_button4.TabIndex = 5;
            this.proj_button4.Text = "Список всех проектов";
            this.proj_button4.Click += new System.EventHandler(this.proj_button4_Click_1);
            // 
            // proj_button5
            // 
            this.proj_button5.BackColor = System.Drawing.Color.White;
            this.proj_button5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proj_button5.ForeColor = System.Drawing.Color.Black;
            this.proj_button5.Location = new System.Drawing.Point(8, 78);
            this.proj_button5.Name = "proj_button5";
            this.proj_button5.Size = new System.Drawing.Size(301, 47);
            this.proj_button5.TabIndex = 4;
            this.proj_button5.Text = "Количество распределённых предметов";
            this.proj_button5.Click += new System.EventHandler(this.proj_button5_Click_1);
            // 
            // proj_line1
            // 
            this.proj_line1.BackColor = System.Drawing.Color.Black;
            this.proj_line1.Location = new System.Drawing.Point(-1, 352);
            this.proj_line1.Name = "proj_line1";
            this.proj_line1.Size = new System.Drawing.Size(735, 5);
            this.proj_line1.TabIndex = 18;
            this.proj_line1.Text = "proj_line1";
            // 
            // proj_line2
            // 
            this.proj_line2.BackColor = System.Drawing.Color.Black;
            this.proj_line2.Location = new System.Drawing.Point(-1, 197);
            this.proj_line2.Name = "proj_line2";
            this.proj_line2.Size = new System.Drawing.Size(735, 5);
            this.proj_line2.TabIndex = 11;
            this.proj_line2.Text = "proj_line2";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(622, 506);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.proj_button3_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(734, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.proj_line1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.managGroupBox);
            this.Controls.Add(this.proj_line2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.managGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private CustomElements.proj_button regNewProjButton;
        private CustomElements.proj_button managProjButton;
        private CustomElements.proj_button exitButton;
        private CustomElements.proj_line proj_line2;
        private CustomElements.proj_button regNewSubButton;
        private CustomElements.proj_button managOrgButton;
        private CustomElements.proj_button regNewItemButton;
        private CustomElements.proj_button managItemsButton;
        private System.Windows.Forms.GroupBox managGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomElements.proj_button proj_button1;
        private CustomElements.proj_line proj_line1;
        private CustomElements.proj_button proj_button2;
        private CustomElements.proj_button proj_button3;
        private CustomElements.proj_button proj_button4;
        private CustomElements.proj_button proj_button5;
        private CustomElements.proj_button proj_button6;
        private CustomElements.proj_button proj_button7;
        private CustomElements.proj_button proj_button8;
        private CustomElements.proj_button proj_button9;
        private CustomElements.proj_button proj_button10;
        private CustomElements.proj_button proj_button11;
        private CustomElements.proj_button proj_button12;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomElements.proj_button proj_button13;
    }
}

