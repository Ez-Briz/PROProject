
namespace Информационная_система_проектной_организации
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.pass2TextBox = new System.Windows.Forms.TextBox();
            this.regAdmLabel = new System.Windows.Forms.Label();
            this.showhidePassPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regButton = new Информационная_система_проектной_организации.CustomElements.proj_button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showhidePassPic)).BeginInit();
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
            this.topPanel.Size = new System.Drawing.Size(467, 40);
            this.topPanel.TabIndex = 5;
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
            this.CloseButton.Location = new System.Drawing.Point(427, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = " X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(140, 112);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(215, 33);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.WordWrap = false;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
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
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(140, 222);
            this.passTextBox.MaxLength = 30;
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '•';
            this.passTextBox.Size = new System.Drawing.Size(276, 33);
            this.passTextBox.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.passTextBox, "Пароль для авторизации администратора");
            this.passTextBox.WordWrap = false;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // pass2TextBox
            // 
            this.pass2TextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass2TextBox.Location = new System.Drawing.Point(140, 277);
            this.pass2TextBox.MaxLength = 30;
            this.pass2TextBox.Multiline = true;
            this.pass2TextBox.Name = "pass2TextBox";
            this.pass2TextBox.PasswordChar = '•';
            this.pass2TextBox.Size = new System.Drawing.Size(276, 33);
            this.pass2TextBox.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.pass2TextBox, "Пароль для авторизации администратора");
            this.pass2TextBox.WordWrap = false;
            this.pass2TextBox.TextChanged += new System.EventHandler(this.pass2TextBox_TextChanged);
            // 
            // regAdmLabel
            // 
            this.regAdmLabel.AutoSize = true;
            this.regAdmLabel.BackColor = System.Drawing.Color.Transparent;
            this.regAdmLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regAdmLabel.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Bold);
            this.regAdmLabel.Location = new System.Drawing.Point(51, 53);
            this.regAdmLabel.Name = "regAdmLabel";
            this.regAdmLabel.Size = new System.Drawing.Size(364, 26);
            this.regAdmLabel.TabIndex = 5;
            this.regAdmLabel.Text = "Регистрация администратора";
            // 
            // showhidePassPic
            // 
            this.showhidePassPic.BackColor = System.Drawing.Color.LightGray;
            this.showhidePassPic.Image = ((System.Drawing.Image)(resources.GetObject("showhidePassPic.Image")));
            this.showhidePassPic.Location = new System.Drawing.Point(425, 223);
            this.showhidePassPic.Name = "showhidePassPic";
            this.showhidePassPic.Size = new System.Drawing.Size(30, 31);
            this.showhidePassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showhidePassPic.TabIndex = 2;
            this.showhidePassPic.TabStop = false;
            this.showhidePassPic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(60, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(49, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Повторите \r\nпароль";
            // 
            // regButton
            // 
            this.regButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.regButton.BackColor = System.Drawing.Color.White;
            this.regButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.Color.Black;
            this.regButton.Location = new System.Drawing.Point(91, 334);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(284, 42);
            this.regButton.TabIndex = 4;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Почта";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(140, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(467, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass2TextBox);
            this.Controls.Add(this.showhidePassPic);
            this.Controls.Add(this.regAdmLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.Text = "Окно регистрации";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showhidePassPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Label regAdmLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.PictureBox showhidePassPic;
        private System.Windows.Forms.TextBox pass2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomElements.proj_button regButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

