using CurseWork.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetGradientBackground(this, Color.Black, Color.White);
            CustomizeButton(button1);
            button1.BackColor = Color.Transparent;
            TextBoxTransparent();
        }
        private void CustomizeButton(Button button)
        {
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 227, 156);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 227, 156);
        }
        private void TextBoxTransparent()
        {

        }
        private void SetGradientBackground(Control control, Color startColor, Color endColor)
        {
            control.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(control.ClientRectangle, startColor, endColor, LinearGradientMode.ForwardDiagonal))
                {
                    e.Graphics.FillRectangle(brush, control.ClientRectangle);
                }
            };
        }
        public Users[]? getdata()
        {

            string response = ApiRequest.getJSON("/api/Users").Result;
            Users[] user = JsonConvert.DeserializeObject<Users[]>(response);
            return user;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();

            this.Hide();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var u in getdata())
            {

                if (textBox1.Text == u.Login.Trim() && textBox2.Text == u.Password.Trim())
                {
                    Form1 form = new Form1(u.UserRole.Trim());
                    this.Hide();

                    form.ShowDialog();
                }

            }
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool isDragging = false;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void AutorisationForm_Load(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.Transparent;
            textBox1.BorderStyle = BorderStyle.None;

        }
        private void CustTextbox(TextBox text)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
            else { textBox2.PasswordChar = '\0'; }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
