
namespace Информационная_система_проектной_организации
{
    partial class RegNewSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegNewSubForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.specLabel = new System.Windows.Forms.Label();
            this.regNewOrgButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.countLabel = new System.Windows.Forms.Label();
            this.counterUpDown = new System.Windows.Forms.NumericUpDown();
            this.fioComboBox = new System.Windows.Forms.ComboBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterUpDown)).BeginInit();
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
            this.topPanel.Size = new System.Drawing.Size(555, 40);
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
            this.CloseButton.Location = new System.Drawing.Point(515, 0);
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
            this.nameLabel.Location = new System.Drawing.Point(11, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(225, 16);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Название субподрядной организации";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(245, 64);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(72, 121);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fioLabel.Size = new System.Drawing.Size(164, 16);
            this.fioLabel.TabIndex = 9;
            this.fioLabel.Text = "Руководитель организации";
            // 
            // specTextBox
            // 
            this.specTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specTextBox.Location = new System.Drawing.Point(245, 172);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(262, 22);
            this.specTextBox.TabIndex = 2;
            // 
            // specLabel
            // 
            this.specLabel.AutoSize = true;
            this.specLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specLabel.Location = new System.Drawing.Point(59, 175);
            this.specLabel.Name = "specLabel";
            this.specLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.specLabel.Size = new System.Drawing.Size(177, 16);
            this.specLabel.TabIndex = 11;
            this.specLabel.Text = "Специализация организации";
            // 
            // regNewOrgButton
            // 
            this.regNewOrgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.regNewOrgButton.BackColor = System.Drawing.Color.White;
            this.regNewOrgButton.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNewOrgButton.ForeColor = System.Drawing.Color.Black;
            this.regNewOrgButton.Location = new System.Drawing.Point(379, 226);
            this.regNewOrgButton.Name = "regNewOrgButton";
            this.regNewOrgButton.Size = new System.Drawing.Size(164, 27);
            this.regNewOrgButton.TabIndex = 4;
            this.regNewOrgButton.Text = "Зарегистрировать";
            this.regNewOrgButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(89, 229);
            this.countLabel.Name = "countLabel";
            this.countLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countLabel.Size = new System.Drawing.Size(147, 16);
            this.countLabel.TabIndex = 19;
            this.countLabel.Text = "Количество сотрудников";
            // 
            // counterUpDown
            // 
            this.counterUpDown.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterUpDown.Location = new System.Drawing.Point(245, 226);
            this.counterUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.counterUpDown.Name = "counterUpDown";
            this.counterUpDown.Size = new System.Drawing.Size(60, 22);
            this.counterUpDown.TabIndex = 3;
            this.counterUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fioComboBox
            // 
            this.fioComboBox.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.fioComboBox.FormattingEnabled = true;
            this.fioComboBox.Location = new System.Drawing.Point(245, 118);
            this.fioComboBox.Name = "fioComboBox";
            this.fioComboBox.Size = new System.Drawing.Size(262, 24);
            this.fioComboBox.TabIndex = 26;
            // 
            // RegNewSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(555, 265);
            this.Controls.Add(this.fioComboBox);
            this.Controls.Add(this.counterUpDown);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.regNewOrgButton);
            this.Controls.Add(this.specTextBox);
            this.Controls.Add(this.specLabel);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegNewSubForm";
            this.Text = "Окно добавления организации";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterUpDown)).EndInit();
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
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.Label specLabel;
        private CustomElements.proj_button regNewOrgButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.NumericUpDown counterUpDown;
        private System.Windows.Forms.ComboBox fioComboBox;
    }
}

