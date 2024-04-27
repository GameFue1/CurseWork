namespace CurseWork
{
    partial class AutorisationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorisationForm));
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            CloseBut = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(57, 72);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Логин";
            textBox1.Size = new Size(181, 40);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 416);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 3;
            label1.Text = "Зарегестрироваться";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SpringGreen;
            button1.Location = new Point(78, 209);
            button1.Name = "button1";
            button1.Size = new Size(138, 56);
            button1.TabIndex = 2;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CloseBut
            // 
            CloseBut.BackColor = Color.Transparent;
            CloseBut.FlatStyle = FlatStyle.Flat;
            CloseBut.ForeColor = Color.Black;
            CloseBut.Location = new Point(251, 12);
            CloseBut.Name = "CloseBut";
            CloseBut.Size = new Size(30, 30);
            CloseBut.TabIndex = 4;
            CloseBut.Text = "X";
            CloseBut.UseVisualStyleBackColor = false;
            CloseBut.Click += CloseBut_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Lime;
            textBox2.Location = new Point(57, 138);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Пароль";
            textBox2.Size = new Size(181, 40);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(244, 138);
            button2.Name = "button2";
            button2.Size = new Size(37, 38);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AutorisationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(293, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(CloseBut);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(293, 450);
            Name = "AutorisationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutorisationForm";
            Load += AutorisationForm_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button CloseBut;
        private TextBox textBox2;
        private Button button2;
    }
}