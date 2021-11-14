
namespace Информационная_система_проектной_организации
{
    partial class RegNewProjForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegNewProjForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.subjTextBox = new System.Windows.Forms.TextBox();
            this.subjLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.printPointLabel = new System.Windows.Forms.Label();
            this.PointTextBox = new System.Windows.Forms.TextBox();
            this.PointLabel = new System.Windows.Forms.Label();
            this.repeatProjButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.regNewProjButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.delPointButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.addPointButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.startLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.nameLabel.Location = new System.Drawing.Point(10, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(162, 16);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Введите название проекта";
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
            // subjTextBox
            // 
            this.subjTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjTextBox.Location = new System.Drawing.Point(189, 69);
            this.subjTextBox.MaxLength = 50;
            this.subjTextBox.Name = "subjTextBox";
            this.subjTextBox.Size = new System.Drawing.Size(247, 22);
            this.subjTextBox.TabIndex = 1;
            // 
            // subjLabel
            // 
            this.subjLabel.AutoSize = true;
            this.subjLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjLabel.Location = new System.Drawing.Point(38, 72);
            this.subjLabel.Name = "subjLabel";
            this.subjLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subjLabel.Size = new System.Drawing.Size(134, 16);
            this.subjLabel.TabIndex = 9;
            this.subjLabel.Text = "Введите тему проекта";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(189, 123);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(247, 22);
            this.priceTextBox.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(38, 126);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceLabel.Size = new System.Drawing.Size(134, 16);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Введите цену проекта";
            // 
            // printPointLabel
            // 
            this.printPointLabel.AutoSize = true;
            this.printPointLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printPointLabel.Location = new System.Drawing.Point(40, 229);
            this.printPointLabel.Name = "printPointLabel";
            this.printPointLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.printPointLabel.Size = new System.Drawing.Size(134, 16);
            this.printPointLabel.TabIndex = 13;
            this.printPointLabel.Text = "Введите цели проекта";
            // 
            // PointTextBox
            // 
            this.PointTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointTextBox.Location = new System.Drawing.Point(202, 266);
            this.PointTextBox.Name = "PointTextBox";
            this.PointTextBox.Size = new System.Drawing.Size(356, 22);
            this.PointTextBox.TabIndex = 3;
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointLabel.Location = new System.Drawing.Point(142, 269);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PointLabel.Size = new System.Drawing.Size(50, 16);
            this.PointLabel.TabIndex = 16;
            this.PointLabel.Text = ":Цель 1";
            // 
            // repeatProjButton
            // 
            this.repeatProjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatProjButton.BackColor = System.Drawing.Color.White;
            this.repeatProjButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatProjButton.ForeColor = System.Drawing.Color.Black;
            this.repeatProjButton.Location = new System.Drawing.Point(442, 307);
            this.repeatProjButton.Name = "repeatProjButton";
            this.repeatProjButton.Size = new System.Drawing.Size(265, 27);
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
            this.regNewProjButton.Location = new System.Drawing.Point(272, 307);
            this.regNewProjButton.Name = "regNewProjButton";
            this.regNewProjButton.Size = new System.Drawing.Size(164, 27);
            this.regNewProjButton.TabIndex = 5;
            this.regNewProjButton.Text = "Зарегистрировать";
            this.regNewProjButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // delPointButton
            // 
            this.delPointButton.BackColor = System.Drawing.Color.White;
            this.delPointButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delPointButton.ForeColor = System.Drawing.Color.Black;
            this.delPointButton.Location = new System.Drawing.Point(386, 226);
            this.delPointButton.Name = "delPointButton";
            this.delPointButton.Size = new System.Drawing.Size(151, 23);
            this.delPointButton.TabIndex = 2;
            this.delPointButton.Text = "Удалить цель";
            this.delPointButton.Click += new System.EventHandler(this.delPointButton_Click);
            // 
            // addPointButton
            // 
            this.addPointButton.BackColor = System.Drawing.Color.White;
            this.addPointButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPointButton.ForeColor = System.Drawing.Color.Black;
            this.addPointButton.Location = new System.Drawing.Point(202, 226);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(151, 23);
            this.addPointButton.TabIndex = 1;
            this.addPointButton.Text = "Добавить цель";
            this.addPointButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLabel.Location = new System.Drawing.Point(7, 18);
            this.startLabel.Name = "startLabel";
            this.startLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startLabel.Size = new System.Drawing.Size(84, 16);
            this.startLabel.TabIndex = 21;
            this.startLabel.Text = "Дата начала";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.subjLabel);
            this.panel1.Controls.Add(this.subjTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 166);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.endDatePicker);
            this.panel2.Controls.Add(this.startDatePicker);
            this.panel2.Controls.Add(this.endLabel);
            this.panel2.Controls.Add(this.startLabel);
            this.panel2.Location = new System.Drawing.Point(459, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 101);
            this.panel2.TabIndex = 11;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(99, 59);
            this.endDatePicker.MaxDate = new System.DateTime(2300, 1, 1, 0, 0, 0, 0);
            this.endDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(138, 22);
            this.endDatePicker.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(99, 15);
            this.startDatePicker.MaxDate = new System.DateTime(2300, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(138, 22);
            this.startDatePicker.TabIndex = 0;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endLabel.Location = new System.Drawing.Point(17, 62);
            this.endLabel.Name = "endLabel";
            this.endLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endLabel.Size = new System.Drawing.Size(74, 16);
            this.endLabel.TabIndex = 22;
            this.endLabel.Text = "Дата сдачи";
            // 
            // RegNewProjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(717, 346);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.repeatProjButton);
            this.Controls.Add(this.regNewProjButton);
            this.Controls.Add(this.delPointButton);
            this.Controls.Add(this.addPointButton);
            this.Controls.Add(this.PointTextBox);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.printPointLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegNewProjForm";
            this.Text = "Окно добавления проекта";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox subjTextBox;
        private System.Windows.Forms.Label subjLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label printPointLabel;
        private System.Windows.Forms.TextBox PointTextBox;
        private System.Windows.Forms.Label PointLabel;
        private CustomElements.proj_button addPointButton;
        private CustomElements.proj_button delPointButton;
        private CustomElements.proj_button regNewProjButton;
        private CustomElements.proj_button repeatProjButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endLabel;
    }
}

