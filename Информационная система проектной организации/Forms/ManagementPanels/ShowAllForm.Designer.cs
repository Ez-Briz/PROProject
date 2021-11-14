
namespace Информационная_система_проектной_организации
{
    partial class ShowAllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.saveButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.editButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.delButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.clearButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.orgComboBox = new System.Windows.Forms.ComboBox();
            this.subOrgLabel = new System.Windows.Forms.Label();
            this.pointsGroupBox = new System.Windows.Forms.GroupBox();
            this.pointTextBox0 = new System.Windows.Forms.TextBox();
            this.pointLabel0 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.subjLabel = new System.Windows.Forms.Label();
            this.subjTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.changeStateButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.contractsButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.pointsGroupBox.SuspendLayout();
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
            this.topPanel.Size = new System.Drawing.Size(1157, 40);
            this.topPanel.TabIndex = 3;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(798, 8);
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
            this.editButton.Location = new System.Drawing.Point(549, 8);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(243, 25);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редактировать выбранный проект";
            this.editButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.White;
            this.delButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delButton.ForeColor = System.Drawing.Color.Black;
            this.delButton.Location = new System.Drawing.Point(343, 8);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(200, 25);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "Удалить выбранный проект";
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
            this.CloseButton.Location = new System.Drawing.Point(1117, 0);
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
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 424);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.contractsButton);
            this.infoPanel.Controls.Add(this.endDatePicker);
            this.infoPanel.Controls.Add(this.startDatePicker);
            this.infoPanel.Controls.Add(this.endDateLabel);
            this.infoPanel.Controls.Add(this.startDateLabel);
            this.infoPanel.Controls.Add(this.clearButton);
            this.infoPanel.Controls.Add(this.orgComboBox);
            this.infoPanel.Controls.Add(this.subOrgLabel);
            this.infoPanel.Controls.Add(this.pointsGroupBox);
            this.infoPanel.Controls.Add(this.priceLabel);
            this.infoPanel.Controls.Add(this.priceTextBox);
            this.infoPanel.Controls.Add(this.subjLabel);
            this.infoPanel.Controls.Add(this.subjTextBox);
            this.infoPanel.Location = new System.Drawing.Point(339, 46);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(806, 367);
            this.infoPanel.TabIndex = 1;
            this.infoPanel.Visible = false;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(648, 129);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(137, 22);
            this.endDatePicker.TabIndex = 5;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(648, 38);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(137, 22);
            this.startDatePicker.TabIndex = 4;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateLabel.Location = new System.Drawing.Point(669, 101);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endDateLabel.Size = new System.Drawing.Size(95, 20);
            this.endDateLabel.TabIndex = 10;
            this.endDateLabel.Text = "Срок сдачи";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateLabel.Location = new System.Drawing.Point(662, 11);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startDateLabel.Size = new System.Drawing.Size(108, 20);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Дата начала";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Enabled = false;
            this.clearButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(524, 82);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 25);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.Click += new System.EventHandler(this.proj_button1_Click);
            // 
            // orgComboBox
            // 
            this.orgComboBox.Enabled = false;
            this.orgComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orgComboBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgComboBox.FormattingEnabled = true;
            this.orgComboBox.Location = new System.Drawing.Point(412, 48);
            this.orgComboBox.Name = "orgComboBox";
            this.orgComboBox.Size = new System.Drawing.Size(215, 28);
            this.orgComboBox.TabIndex = 2;
            this.orgComboBox.SelectedIndexChanged += new System.EventHandler(this.orgComboBox_SelectedIndexChanged);
            // 
            // subOrgLabel
            // 
            this.subOrgLabel.AutoSize = true;
            this.subOrgLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subOrgLabel.Location = new System.Drawing.Point(412, 21);
            this.subOrgLabel.Name = "subOrgLabel";
            this.subOrgLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subOrgLabel.Size = new System.Drawing.Size(215, 20);
            this.subOrgLabel.TabIndex = 7;
            this.subOrgLabel.Text = "Привязанная организация";
            // 
            // pointsGroupBox
            // 
            this.pointsGroupBox.Controls.Add(this.pointTextBox0);
            this.pointsGroupBox.Controls.Add(this.pointLabel0);
            this.pointsGroupBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsGroupBox.Location = new System.Drawing.Point(17, 110);
            this.pointsGroupBox.Name = "pointsGroupBox";
            this.pointsGroupBox.Size = new System.Drawing.Size(610, 239);
            this.pointsGroupBox.TabIndex = 7;
            this.pointsGroupBox.TabStop = false;
            this.pointsGroupBox.Text = "Цели";
            // 
            // pointTextBox0
            // 
            this.pointTextBox0.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointTextBox0.Location = new System.Drawing.Point(93, 25);
            this.pointTextBox0.Name = "pointTextBox0";
            this.pointTextBox0.ReadOnly = true;
            this.pointTextBox0.Size = new System.Drawing.Size(501, 27);
            this.pointTextBox0.TabIndex = 0;
            this.pointTextBox0.TextChanged += new System.EventHandler(this.infoTextBoxes_TextChanged);
            // 
            // pointLabel0
            // 
            this.pointLabel0.AutoSize = true;
            this.pointLabel0.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointLabel0.Location = new System.Drawing.Point(21, 28);
            this.pointLabel0.Name = "pointLabel0";
            this.pointLabel0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pointLabel0.Size = new System.Drawing.Size(65, 20);
            this.pointLabel0.TabIndex = 5;
            this.pointLabel0.Text = ":Цель 1";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(48, 69);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceLabel.Size = new System.Drawing.Size(71, 20);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Оплата:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(134, 66);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(191, 27);
            this.priceTextBox.TabIndex = 1;
            this.priceTextBox.TextChanged += new System.EventHandler(this.infoTextBoxes_TextChanged);
            // 
            // subjLabel
            // 
            this.subjLabel.AutoSize = true;
            this.subjLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjLabel.Location = new System.Drawing.Point(67, 24);
            this.subjLabel.Name = "subjLabel";
            this.subjLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subjLabel.Size = new System.Drawing.Size(52, 20);
            this.subjLabel.TabIndex = 1;
            this.subjLabel.Text = "Тема:";
            // 
            // subjTextBox
            // 
            this.subjTextBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjTextBox.Location = new System.Drawing.Point(134, 21);
            this.subjTextBox.Name = "subjTextBox";
            this.subjTextBox.ReadOnly = true;
            this.subjTextBox.Size = new System.Drawing.Size(248, 27);
            this.subjTextBox.TabIndex = 0;
            this.subjTextBox.TextChanged += new System.EventHandler(this.infoTextBoxes_TextChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.Location = new System.Drawing.Point(353, 432);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stateLabel.Size = new System.Drawing.Size(243, 20);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "Статус выбранного контракта:";
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStateLabel.Location = new System.Drawing.Point(602, 432);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentStateLabel.Size = new System.Drawing.Size(88, 20);
            this.currentStateLabel.TabIndex = 10;
            this.currentStateLabel.Text = "не выбран";
            // 
            // changeStateButton
            // 
            this.changeStateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changeStateButton.BackColor = System.Drawing.Color.White;
            this.changeStateButton.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.changeStateButton.ForeColor = System.Drawing.Color.Black;
            this.changeStateButton.Location = new System.Drawing.Point(902, 426);
            this.changeStateButton.Name = "changeStateButton";
            this.changeStateButton.Size = new System.Drawing.Size(243, 32);
            this.changeStateButton.TabIndex = 2;
            this.changeStateButton.Text = "Изменить статус контракта";
            this.changeStateButton.Visible = false;
            this.changeStateButton.Click += new System.EventHandler(this.proj_button1_Click_1);
            // 
            // contractsButton
            // 
            this.contractsButton.BackColor = System.Drawing.Color.White;
            this.contractsButton.Enabled = false;
            this.contractsButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractsButton.ForeColor = System.Drawing.Color.Black;
            this.contractsButton.Location = new System.Drawing.Point(648, 181);
            this.contractsButton.Name = "contractsButton";
            this.contractsButton.Size = new System.Drawing.Size(137, 40);
            this.contractsButton.TabIndex = 11;
            this.contractsButton.Text = "Привязанные проекты";
            this.contractsButton.Click += new System.EventHandler(this.proj_button1_Click_2);
            // 
            // ShowAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1157, 480);
            this.Controls.Add(this.changeStateButton);
            this.Controls.Add(this.currentStateLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowAllForm";
            this.Text = "Панель управления проектами";
            this.Load += new System.EventHandler(this.ShowAllForm_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.pointsGroupBox.ResumeLayout(false);
            this.pointsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label subjLabel;
        private System.Windows.Forms.TextBox subjTextBox;
        private System.Windows.Forms.Label pointLabel0;
        private System.Windows.Forms.TextBox pointTextBox0;
        private System.Windows.Forms.GroupBox pointsGroupBox;
        private CustomElements.proj_button saveButton;
        private CustomElements.proj_button editButton;
        private CustomElements.proj_button delButton;
        private System.Windows.Forms.ComboBox orgComboBox;
        private System.Windows.Forms.Label subOrgLabel;
        private CustomElements.proj_button clearButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label currentStateLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private CustomElements.proj_button changeStateButton;
        private CustomElements.proj_button contractsButton;
    }
}

