
namespace Информационная_система_проектной_организации
{
    partial class ManageEmpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmpForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.saveButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.editButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.delButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageLabel = new System.Windows.Forms.Label();
            this.specLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patrTextBox = new System.Windows.Forms.TextBox();
            this.patrLabel = new System.Windows.Forms.Label();
            this.bdLabel = new System.Windows.Forms.Label();
            this.specComboBox = new System.Windows.Forms.ComboBox();
            this.bdTimePicker = new System.Windows.Forms.DateTimePicker();
            this.otdelComboBox = new System.Windows.Forms.ComboBox();
            this.otdelLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.saveButton);
            this.topPanel.Controls.Add(this.editButton);
            this.topPanel.Controls.Add(this.delButton);
            this.topPanel.Controls.Add(this.CloseButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(970, 40);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(741, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(165, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(470, 8);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(265, 25);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редактировать выбранного сотрудника";
            this.editButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.White;
            this.delButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delButton.ForeColor = System.Drawing.Color.Black;
            this.delButton.Location = new System.Drawing.Point(235, 8);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(229, 25);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "Удалить выбранного сотрудника";
            this.delButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(930, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = " X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
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
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(5, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.otdelComboBox);
            this.infoPanel.Controls.Add(this.otdelLabel);
            this.infoPanel.Controls.Add(this.bdTimePicker);
            this.infoPanel.Controls.Add(this.specComboBox);
            this.infoPanel.Controls.Add(this.bdLabel);
            this.infoPanel.Controls.Add(this.patrTextBox);
            this.infoPanel.Controls.Add(this.patrLabel);
            this.infoPanel.Controls.Add(this.surnameTextBox);
            this.infoPanel.Controls.Add(this.surnameLabel);
            this.infoPanel.Controls.Add(this.ageUpDown);
            this.infoPanel.Controls.Add(this.ageLabel);
            this.infoPanel.Controls.Add(this.specLabel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Controls.Add(this.nameTextBox);
            this.infoPanel.Location = new System.Drawing.Point(339, 46);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(619, 244);
            this.infoPanel.TabIndex = 1;
            this.infoPanel.Visible = false;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Enabled = false;
            this.ageUpDown.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ageUpDown.Location = new System.Drawing.Point(153, 148);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.ReadOnly = true;
            this.ageUpDown.Size = new System.Drawing.Size(77, 27);
            this.ageUpDown.TabIndex = 1;
            this.ageUpDown.ValueChanged += new System.EventHandler(this.countUpDown_ValueChanged);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(66, 151);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(69, 20);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Возраст";
            // 
            // specLabel
            // 
            this.specLabel.AutoSize = true;
            this.specLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specLabel.Location = new System.Drawing.Point(293, 150);
            this.specLabel.Name = "specLabel";
            this.specLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.specLabel.Size = new System.Drawing.Size(133, 20);
            this.specLabel.TabIndex = 3;
            this.specLabel.Text = "Специализация";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(92, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(153, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(324, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.infoTextBoxes_TextChanged);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(53, 67);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(82, 20);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Фамилия";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(153, 64);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(324, 27);
            this.surnameTextBox.TabIndex = 6;
            // 
            // patrTextBox
            // 
            this.patrTextBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrTextBox.Location = new System.Drawing.Point(153, 106);
            this.patrTextBox.Name = "patrTextBox";
            this.patrTextBox.ReadOnly = true;
            this.patrTextBox.Size = new System.Drawing.Size(324, 27);
            this.patrTextBox.TabIndex = 8;
            // 
            // patrLabel
            // 
            this.patrLabel.AutoSize = true;
            this.patrLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrLabel.Location = new System.Drawing.Point(57, 109);
            this.patrLabel.Name = "patrLabel";
            this.patrLabel.Size = new System.Drawing.Size(78, 20);
            this.patrLabel.TabIndex = 7;
            this.patrLabel.Text = "Отчество";
            // 
            // bdLabel
            // 
            this.bdLabel.AutoSize = true;
            this.bdLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdLabel.Location = new System.Drawing.Point(7, 193);
            this.bdLabel.Name = "bdLabel";
            this.bdLabel.Size = new System.Drawing.Size(128, 20);
            this.bdLabel.TabIndex = 9;
            this.bdLabel.Text = "Дата рождения";
            // 
            // specComboBox
            // 
            this.specComboBox.Enabled = false;
            this.specComboBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specComboBox.FormattingEnabled = true;
            this.specComboBox.Location = new System.Drawing.Point(432, 147);
            this.specComboBox.Name = "specComboBox";
            this.specComboBox.Size = new System.Drawing.Size(161, 28);
            this.specComboBox.TabIndex = 10;
            // 
            // bdTimePicker
            // 
            this.bdTimePicker.Enabled = false;
            this.bdTimePicker.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdTimePicker.Location = new System.Drawing.Point(153, 188);
            this.bdTimePicker.Name = "bdTimePicker";
            this.bdTimePicker.Size = new System.Drawing.Size(184, 27);
            this.bdTimePicker.TabIndex = 11;
            // 
            // otdelComboBox
            // 
            this.otdelComboBox.Enabled = false;
            this.otdelComboBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otdelComboBox.FormattingEnabled = true;
            this.otdelComboBox.Location = new System.Drawing.Point(432, 188);
            this.otdelComboBox.Name = "otdelComboBox";
            this.otdelComboBox.Size = new System.Drawing.Size(161, 28);
            this.otdelComboBox.TabIndex = 13;
            // 
            // otdelLabel
            // 
            this.otdelLabel.AutoSize = true;
            this.otdelLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otdelLabel.Location = new System.Drawing.Point(370, 191);
            this.otdelLabel.Name = "otdelLabel";
            this.otdelLabel.Size = new System.Drawing.Size(56, 20);
            this.otdelLabel.TabIndex = 12;
            this.otdelLabel.Text = "Отдел";
            // 
            // ManageEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(970, 301);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageEmpForm";
            this.Text = "Панель управления сотрудниками";
            this.Load += new System.EventHandler(this.ShowAllForm_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label specLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private CustomElements.proj_button saveButton;
        private CustomElements.proj_button editButton;
        private CustomElements.proj_button delButton;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.ComboBox otdelComboBox;
        private System.Windows.Forms.Label otdelLabel;
        private System.Windows.Forms.DateTimePicker bdTimePicker;
        private System.Windows.Forms.ComboBox specComboBox;
        private System.Windows.Forms.Label bdLabel;
        private System.Windows.Forms.TextBox patrTextBox;
        private System.Windows.Forms.Label patrLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
    }
}

