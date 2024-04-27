namespace CurseWork
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            CloseBut = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(65, 227);
            button1.Name = "button1";
            button1.Size = new Size(188, 62);
            button1.TabIndex = 0;
            button1.Text = "Зарегестрировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(282, 135);
            button2.Name = "button2";
            button2.Size = new Size(37, 39);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(282, 181);
            button3.Name = "button3";
            button3.Size = new Size(37, 39);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CloseBut);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 390);
            panel1.TabIndex = 7;
            panel1.MouseDown += Form1_MouseDown;
            panel1.MouseMove += Form1_MouseMove;
            panel1.MouseUp += Form1_MouseUp;
            // 
            // CloseBut
            // 
            CloseBut.BackColor = Color.Transparent;
            CloseBut.FlatStyle = FlatStyle.Flat;
            CloseBut.ForeColor = Color.Red;
            CloseBut.Location = new Point(291, 3);
            CloseBut.Name = "CloseBut";
            CloseBut.Size = new Size(30, 30);
            CloseBut.TabIndex = 9;
            CloseBut.Text = "X";
            CloseBut.UseVisualStyleBackColor = false;
            CloseBut.Click += CloseBut_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Cyan;
            button4.Location = new Point(65, 295);
            button4.Name = "button4";
            button4.Size = new Size(188, 55);
            button4.TabIndex = 8;
            button4.Text = "Вернуться";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(34, 181);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Повторите пароль";
            textBox3.Size = new Size(242, 40);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(34, 135);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Введите пароль";
            textBox2.Size = new Size(242, 40);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(34, 67);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите логин";
            textBox1.Size = new Size(242, 40);
            textBox1.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 389);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TranBackTextBox tranBackTextBox1;
        private TranBackTextBox tranBackTextBox2;
        private TranBackTextBox tranBackTextBox3;
        private TranBackTextBox tranBackTextBox4;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button4;
        private Button CloseBut;
    }
}