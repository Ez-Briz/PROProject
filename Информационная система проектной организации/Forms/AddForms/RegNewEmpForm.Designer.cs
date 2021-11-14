
namespace Информационная_система_проектной_организации
{
    partial class RegNewEmpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegNewEmpForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.subjLabel = new System.Windows.Forms.Label();
            this.patrTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.repeatProjButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.regNewProjButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.startLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endLabel = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.profLabel = new System.Windows.Forms.Label();
            this.profComboBox = new System.Windows.Forms.ComboBox();
            this.otdelComboBox = new System.Windows.Forms.ComboBox();
            this.otdelLabel = new System.Windows.Forms.Label();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.CloseButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(717, 40);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.CloseButton.Location = new System.Drawing.Point(677, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 0;
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(33, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(150, 16);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Введите имя сотрудника";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(189, 15);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(247, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(189, 55);
            this.surnameTextBox.MaxLength = 50;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(247, 22);
            this.surnameTextBox.TabIndex = 1;
            // 
            // subjLabel
            // 
            this.subjLabel.AutoSize = true;
            this.subjLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjLabel.Location = new System.Drawing.Point(1, 58);
            this.subjLabel.Name = "subjLabel";
            this.subjLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subjLabel.Size = new System.Drawing.Size(182, 16);
            this.subjLabel.TabIndex = 9;
            this.subjLabel.Text = "Введите фамилию сотрудника";
            // 
            // patrTextBox
            // 
            this.patrTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrTextBox.Location = new System.Drawing.Point(189, 95);
            this.patrTextBox.Name = "patrTextBox";
            this.patrTextBox.Size = new System.Drawing.Size(247, 22);
            this.patrTextBox.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(8, 98);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceLabel.Size = new System.Drawing.Size(175, 16);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Введите отчество сотрудника";
            // 
            // repeatProjButton
            // 
            this.repeatProjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatProjButton.BackColor = System.Drawing.Color.White;
            this.repeatProjButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatProjButton.ForeColor = System.Drawing.Color.Black;
            this.repeatProjButton.Location = new System.Drawing.Point(486, 174);
            this.repeatProjButton.Name = "repeatProjButton";
            this.repeatProjButton.Size = new System.Drawing.Size(219, 42);
            this.repeatProjButton.TabIndex = 6;
            this.repeatProjButton.Text = "Зарегистрировать и начать заново";
            this.repeatProjButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // regNewProjButton
            // 
            this.regNewProjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.regNewProjButton.BackColor = System.Drawing.Color.White;
            this.regNewProjButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNewProjButton.ForeColor = System.Drawing.Color.Black;
            this.regNewProjButton.Location = new System.Drawing.Point(486, 227);
            this.regNewProjButton.Name = "regNewProjButton";
            this.regNewProjButton.Size = new System.Drawing.Size(219, 27);
            this.regNewProjButton.TabIndex = 5;
            this.regNewProjButton.Text = "Зарегистрировать";
            this.regNewProjButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLabel.Location = new System.Drawing.Point(84, 178);
            this.startLabel.Name = "startLabel";
            this.startLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startLabel.Size = new System.Drawing.Size(99, 16);
            this.startLabel.TabIndex = 21;
            this.startLabel.Text = "Дата рождения";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ageNumericUpDown);
            this.panel1.Controls.Add(this.endLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.birthDatePicker);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.startLabel);
            this.panel1.Controls.Add(this.subjLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.patrTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 208);
            this.panel1.TabIndex = 0;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endLabel.Location = new System.Drawing.Point(129, 138);
            this.endLabel.Name = "endLabel";
            this.endLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endLabel.Size = new System.Drawing.Size(54, 16);
            this.endLabel.TabIndex = 22;
            this.endLabel.Text = "Возраст";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Location = new System.Drawing.Point(189, 175);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(138, 22);
            this.birthDatePicker.TabIndex = 0;
            // 
            // profLabel
            // 
            this.profLabel.AutoSize = true;
            this.profLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profLabel.Location = new System.Drawing.Point(486, 50);
            this.profLabel.Name = "profLabel";
            this.profLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profLabel.Size = new System.Drawing.Size(70, 16);
            this.profLabel.TabIndex = 25;
            this.profLabel.Text = "Профессия";
            // 
            // profComboBox
            // 
            this.profComboBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profComboBox.FormattingEnabled = true;
            this.profComboBox.Location = new System.Drawing.Point(486, 69);
            this.profComboBox.Name = "profComboBox";
            this.profComboBox.Size = new System.Drawing.Size(166, 24);
            this.profComboBox.TabIndex = 4;
            this.profComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // otdelComboBox
            // 
            this.otdelComboBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otdelComboBox.FormattingEnabled = true;
            this.otdelComboBox.Location = new System.Drawing.Point(486, 130);
            this.otdelComboBox.Name = "otdelComboBox";
            this.otdelComboBox.Size = new System.Drawing.Size(166, 24);
            this.otdelComboBox.TabIndex = 26;
            this.otdelComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // otdelLabel
            // 
            this.otdelLabel.AutoSize = true;
            this.otdelLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otdelLabel.Location = new System.Drawing.Point(486, 111);
            this.otdelLabel.Name = "otdelLabel";
            this.otdelLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.otdelLabel.Size = new System.Drawing.Size(43, 16);
            this.otdelLabel.TabIndex = 27;
            this.otdelLabel.Text = "Отдел";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageNumericUpDown.Location = new System.Drawing.Point(189, 136);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(78, 22);
            this.ageNumericUpDown.TabIndex = 25;
            // 
            // RegNewEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(717, 266);
            this.Controls.Add(this.otdelComboBox);
            this.Controls.Add(this.otdelLabel);
            this.Controls.Add(this.profComboBox);
            this.Controls.Add(this.profLabel);
            this.Controls.Add(this.repeatProjButton);
            this.Controls.Add(this.regNewProjButton);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegNewEmpForm";
            this.Text = "Окно добавления проекта";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label subjLabel;
        private System.Windows.Forms.TextBox patrTextBox;
        private System.Windows.Forms.Label priceLabel;
        private CustomElements.proj_button regNewProjButton;
        private CustomElements.proj_button repeatProjButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label profLabel;
        private System.Windows.Forms.ComboBox profComboBox;
        private System.Windows.Forms.ComboBox otdelComboBox;
        private System.Windows.Forms.Label otdelLabel;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
    }
}

