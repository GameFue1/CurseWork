namespace CurseWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            Furniture = new Button();
            button4 = new Button();
            button5 = new Button();
            button15 = new Button();
            HumanContainer = new Panel();
            button17 = new Button();
            button11 = new Button();
            ClientBut = new Button();
            button3 = new Button();
            brigadeBut = new Button();
            button16 = new Button();
            panel1 = new Panel();
            button18 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button19 = new Button();
            button20 = new Button();
            panel2 = new Panel();
            button23 = new Button();
            button22 = new Button();
            button21 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            HumanTimer = new System.Windows.Forms.Timer(components);
            ProcTimer = new System.Windows.Forms.Timer(components);
            MenuTimer = new System.Windows.Forms.Timer(components);
            CloseTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            HumanContainer.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 2, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8920536F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.10795F));
            tableLayoutPanel1.Size = new Size(1050, 670);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            tableLayoutPanel1.MouseDown += Form1_MouseDown;
            tableLayoutPanel1.MouseMove += Form1_MouseMove;
            tableLayoutPanel1.MouseUp += Form1_MouseUp;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(3, 3);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(220, 105);
            button1.TabIndex = 2;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("GOST type B", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(229, 3);
            label1.Name = "label1";
            label1.Size = new Size(612, 105);
            label1.TabIndex = 0;
            label1.Text = "Швейная мастерская";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += Form1_MouseDown;
            label1.MouseMove += Form1_MouseMove;
            label1.MouseUp += Form1_MouseUp;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(Furniture);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button15);
            flowLayoutPanel1.Controls.Add(HumanContainer);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 114);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(214, 550);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(205, 32);
            button2.TabIndex = 1;
            button2.Text = "Заказы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Client_OrderBut_Click;
            // 
            // Furniture
            // 
            Furniture.AutoSize = true;
            Furniture.FlatStyle = FlatStyle.Flat;
            Furniture.ForeColor = Color.White;
            Furniture.Location = new Point(3, 41);
            Furniture.Name = "Furniture";
            Furniture.Size = new Size(205, 32);
            Furniture.TabIndex = 4;
            Furniture.Text = "Фурнитура";
            Furniture.UseVisualStyleBackColor = true;
            Furniture.Click += Furniture_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 79);
            button4.Name = "button4";
            button4.Size = new Size(205, 32);
            button4.TabIndex = 5;
            button4.Text = "Фунитура на модель";
            button4.UseVisualStyleBackColor = true;
            button4.Click += FurnitureForModel_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 117);
            button5.Name = "button5";
            button5.Size = new Size(205, 32);
            button5.TabIndex = 6;
            button5.Text = "Цвета";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Colour_Click;
            // 
            // button15
            // 
            button15.AutoSize = true;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.White;
            button15.Location = new Point(3, 155);
            button15.Name = "button15";
            button15.Size = new Size(205, 32);
            button15.TabIndex = 13;
            button15.Text = "Оборудование";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // HumanContainer
            // 
            HumanContainer.Controls.Add(button17);
            HumanContainer.Controls.Add(button11);
            HumanContainer.Controls.Add(ClientBut);
            HumanContainer.Controls.Add(button3);
            HumanContainer.Controls.Add(brigadeBut);
            HumanContainer.Controls.Add(button16);
            HumanContainer.ForeColor = Color.White;
            HumanContainer.Location = new Point(3, 193);
            HumanContainer.MaximumSize = new Size(205, 192);
            HumanContainer.MinimumSize = new Size(191, 32);
            HumanContainer.Name = "HumanContainer";
            HumanContainer.Size = new Size(205, 32);
            HumanContainer.TabIndex = 8;
            // 
            // button17
            // 
            button17.AutoSize = true;
            button17.BackColor = Color.DimGray;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = Color.White;
            button17.Location = new Point(0, 160);
            button17.Margin = new Padding(0);
            button17.Name = "button17";
            button17.Size = new Size(191, 32);
            button17.TabIndex = 15;
            button17.Text = "Пользователи";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button11
            // 
            button11.AutoSize = true;
            button11.BackColor = Color.DimGray;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.White;
            button11.Location = new Point(0, 128);
            button11.Name = "button11";
            button11.Size = new Size(191, 32);
            button11.TabIndex = 12;
            button11.Text = "Должность";
            button11.UseVisualStyleBackColor = false;
            button11.Click += Post_Click;
            // 
            // ClientBut
            // 
            ClientBut.AutoSize = true;
            ClientBut.BackColor = Color.DimGray;
            ClientBut.FlatStyle = FlatStyle.Flat;
            ClientBut.ForeColor = Color.White;
            ClientBut.Location = new Point(0, 96);
            ClientBut.Margin = new Padding(0);
            ClientBut.Name = "ClientBut";
            ClientBut.Size = new Size(191, 32);
            ClientBut.TabIndex = 0;
            ClientBut.Text = "Клиент";
            ClientBut.UseVisualStyleBackColor = false;
            ClientBut.Click += ClientBut_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 64);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(191, 32);
            button3.TabIndex = 2;
            button3.Text = "Работники";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // brigadeBut
            // 
            brigadeBut.AutoSize = true;
            brigadeBut.BackColor = Color.DimGray;
            brigadeBut.FlatStyle = FlatStyle.Flat;
            brigadeBut.ForeColor = Color.White;
            brigadeBut.Location = new Point(0, 32);
            brigadeBut.Margin = new Padding(0);
            brigadeBut.Name = "brigadeBut";
            brigadeBut.Size = new Size(191, 32);
            brigadeBut.TabIndex = 3;
            brigadeBut.Text = "Бригада";
            brigadeBut.UseVisualStyleBackColor = false;
            brigadeBut.Click += brigadeBut_Click;
            // 
            // button16
            // 
            button16.AutoSize = true;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.White;
            button16.Location = new Point(0, 0);
            button16.Name = "button16";
            button16.Size = new Size(205, 32);
            button16.TabIndex = 14;
            button16.Text = "Люди";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button18);
            panel1.Location = new Point(3, 231);
            panel1.MaximumSize = new Size(205, 192);
            panel1.MinimumSize = new Size(191, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 32);
            panel1.TabIndex = 6;
            // 
            // button18
            // 
            button18.Dock = DockStyle.Top;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = Color.White;
            button18.Location = new Point(0, 0);
            button18.Name = "button18";
            button18.Size = new Size(205, 32);
            button18.TabIndex = 0;
            button18.Text = "Процессы";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.DimGray;
            button6.Dock = DockStyle.Top;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 32);
            button6.Name = "button6";
            button6.Size = new Size(205, 32);
            button6.TabIndex = 7;
            button6.Text = "Раскладка";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Layout_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.BackColor = Color.DimGray;
            button7.Dock = DockStyle.Top;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 160);
            button7.Name = "button7";
            button7.Size = new Size(205, 32);
            button7.TabIndex = 8;
            button7.Text = "Раскрой";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Cutting_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.Dock = DockStyle.Top;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 128);
            button8.Name = "button8";
            button8.Size = new Size(205, 32);
            button8.TabIndex = 9;
            button8.Text = "Пошив";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Tailoring_Click;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.BackColor = Color.DimGray;
            button9.Dock = DockStyle.Top;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(0, 96);
            button9.Name = "button9";
            button9.Size = new Size(205, 32);
            button9.TabIndex = 10;
            button9.Text = "ОТК";
            button9.UseVisualStyleBackColor = false;
            button9.Click += OTK_Click;
            // 
            // button10
            // 
            button10.AutoSize = true;
            button10.BackColor = Color.DimGray;
            button10.Dock = DockStyle.Top;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.White;
            button10.Location = new Point(0, 64);
            button10.Name = "button10";
            button10.Size = new Size(205, 32);
            button10.TabIndex = 11;
            button10.Text = "Упаковка";
            button10.UseVisualStyleBackColor = false;
            button10.Click += Packing_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button12);
            flowLayoutPanel2.Controls.Add(button13);
            flowLayoutPanel2.Controls.Add(button14);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(850, 114);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(194, 550);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // button12
            // 
            button12.AutoSize = true;
            button12.Dock = DockStyle.Top;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(3, 3);
            button12.Name = "button12";
            button12.Size = new Size(185, 42);
            button12.TabIndex = 5;
            button12.Text = "Добавить";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(3, 51);
            button13.Name = "button13";
            button13.Size = new Size(99, 0);
            button13.TabIndex = 6;
            button13.Text = "Изменить";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(3, 57);
            button14.Name = "button14";
            button14.Size = new Size(99, 0);
            button14.TabIndex = 7;
            button14.Text = "Удалить";
            button14.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(button19);
            flowLayoutPanel3.Controls.Add(button20);
            flowLayoutPanel3.Controls.Add(panel2);
            flowLayoutPanel3.Dock = DockStyle.Right;
            flowLayoutPanel3.Location = new Point(940, 6);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(104, 99);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Location = new Point(3, 3);
            button19.Name = "button19";
            button19.Size = new Size(27, 29);
            button19.TabIndex = 0;
            button19.Text = "-";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Location = new Point(36, 3);
            button20.Name = "button20";
            button20.Size = new Size(33, 29);
            button20.TabIndex = 1;
            button20.Text = "[]";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button23);
            panel2.Controls.Add(button22);
            panel2.Controls.Add(button21);
            panel2.Location = new Point(75, 3);
            panel2.MaximumSize = new Size(25, 87);
            panel2.MinimumSize = new Size(25, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 29);
            panel2.TabIndex = 3;
            // 
            // button23
            // 
            button23.Dock = DockStyle.Top;
            button23.Location = new Point(0, 58);
            button23.Name = "button23";
            button23.Size = new Size(25, 29);
            button23.TabIndex = 4;
            button23.Text = "button23";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // button22
            // 
            button22.Dock = DockStyle.Top;
            button22.Location = new Point(0, 29);
            button22.Name = "button22";
            button22.Size = new Size(25, 29);
            button22.TabIndex = 3;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button21
            // 
            button21.Dock = DockStyle.Top;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Location = new Point(0, 0);
            button21.Name = "button21";
            button21.Size = new Size(25, 29);
            button21.TabIndex = 2;
            button21.Text = "X";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(211, 24);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // HumanTimer
            // 
            HumanTimer.Interval = 1;
            HumanTimer.Tick += timer1_Tick;
            // 
            // ProcTimer
            // 
            ProcTimer.Interval = 1;
            ProcTimer.Tick += timer1_Tick_1;
            // 
            // MenuTimer
            // 
            MenuTimer.Tick += timer2_Tick;
            // 
            // CloseTimer
            // 
            CloseTimer.Tick += CloseTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 670);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Швейная мастерская";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            Resize += Form1_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            HumanContainer.ResumeLayout(false);
            HumanContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ClientBut;
        private Button button2;
        private Button button3;
        private Button brigadeBut;
        private Button Furniture;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button12;
        private Button button13;
        private Button button14;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button button15;
        private Panel HumanContainer;
        private Button button16;
        private System.Windows.Forms.Timer HumanTimer;
        private Button button17;
        private Panel panel1;
        private Button button18;
        private System.Windows.Forms.Timer ProcTimer;
        private System.Windows.Forms.Timer MenuTimer;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button19;
        private Button button20;
        private Button button21;
        private System.Windows.Forms.Timer CloseTimer;
        private Panel panel2;
        private Button button23;
        private Button button22;
    }
}