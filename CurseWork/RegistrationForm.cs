using CurseWork.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            SetGradientBackground(this, Color.Purple, Color.SpringGreen);

            SetGradientBackground(panel1, Color.Purple, Color.SpringGreen);
            CustomizeButton(button1);
            button1.BackColor = Color.Transparent;

            //  textBox1.BackColor = Color.FromArgb(0, Color.White);
        }

        private void CustomizeButton(Button button)
        {
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 227, 156);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 227, 156);
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





        private void button2_Click(object sender, EventArgs e)
        {
            if (tranBackTextBox2.PasswordChar == '\0')
            {
                tranBackTextBox2.PasswordChar = '*';
            }
            else { tranBackTextBox2.PasswordChar = '\0'; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tranBackTextBox3.PasswordChar == '\0')
            {
                tranBackTextBox3.PasswordChar = '*';
            }
            else { tranBackTextBox3.PasswordChar = '\0'; }
        }
        AutorisationForm form = new AutorisationForm();
        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                Login = textBox1.Text,
                Password = textBox1.Text,
                UserRole = null
            };
            var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            var response = ApiRequest.sendPostJSON("api/Users/UsersP", jsonData).Result;


            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("fuel-game-l@yandex.ru"); // Адрес отправителя
            mail.To.Add(new MailAddress("fuel-game-l@yandex.ru")); // Адрес получателя
            mail.Subject = "Новый пользователь";
            mail.Body = $"Новый пользователь зарегестрировался под логином {textBox1.Text}";

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.yandex.ru";
            client.Port = 587; // Обратите внимание что порт 587
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("fuel-game-l@yandex.ru", "icuznaxyhnziwlng"); // Ваши логин и пароль
            client.Send(mail);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
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

    }
    //
}
