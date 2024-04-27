
using CurseWork.Classes;
using CurseWork.Controls;
using CurseWork.Models;
using Newtonsoft.Json;
using System.Data.Common;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class Form1 : Form
    {
        public Form1(string Role)
        {
            InitializeComponent();
            //setList();
            this.DoubleBuffered = true;
            // SetGradientBackground(tableLayoutPanel1, Color.Black, Color.White);
            label1.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            // comboBox1.BackColor = System.Drawing.Color.Transparent;
            button1.BackColor = System.Drawing.Color.Black;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.Margin = new Padding(0);
            }
            CustomizeButton(button1);
            CustomizeButton(ClientBut);
            CustomizeButton(button3);
            CustomizeButton(Furniture);
            CustomizeButton(button5);
            CustomizeButton(button6);
            CustomizeButton(button7);
            CustomizeButton(button4);
            CustomizeButton(button2);
            CustomizeButton(button10);
            CustomizeButton(button2);
            CustomizeButton(button9);
            CustomizeButton(button8);
            CustomizeButton(button11);
            CustomizeButton(brigadeBut);
            CustomizeButton(button15);
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(button2);
            if (Role == "user") { flowLayoutPanel1.Hide(); flowLayoutPanel2.Hide(); button1.Hide(); }
            if (Role == "master") { button2.Hide(); button16.Hide(); HumanContainer.Hide(); button15.Hide(); }
            if (Role == "employee") { button2.Hide(); button16.Hide(); HumanContainer.Hide(); button12.Hide(); button15.Hide(); }


        }
        private void CustomizeButton(Button button)
        {
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 227, 156);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 227, 156);
        }
        public ClientControl clientControl = new ClientControl();
        public Controls.Client_Order client_OrderControl = new Controls.Client_Order();
        private void ClientBut_Click(object sender, EventArgs e)
        {

            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }



            clientControl.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(clientControl, 1, 1);

        }
        private void Client_OrderBut_Click(object sender, EventArgs e)
        {

            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            client_OrderControl.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Remove(clientControl);
            tableLayoutPanel1.Controls.Add(client_OrderControl, 1, 1);
        }
        //public void setList()
        //{
        //    string response = ApiRequest.getJSON("api/Client").Result;
        //    if (!string.IsNullOrEmpty(response))
        //    {
        //        List<client> clients = JsonConvert.DeserializeObject<List<client>>(response);
        //        clients.ForEach(x => x.FIO = x.FIO);
        //        if (clients.Count > 0)
        //        {
        //            comboBox1.DataSource = clients;
        //            comboBox1.ValueMember = "Id";
        //            comboBox1.DisplayMember = "FIO";

        //            comboBox1.SelectedValue = 1;
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Список пуст");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show($"Ответ от API -");
        //    }
        //}
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
        //if (tableLayoutPanel1.Controls.Count > 4)
        //   {
        //       tableLayoutPanel1.Controls.RemoveAt(4);
        //   }
        //   else { }
        private void button1_Click(object sender, EventArgs e)
        {

            MenuTimer.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var employeeControler = new Controls.EmployeeControl();
            employeeControler.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(employeeControler, 1, 1);
        }

        private void brigadeBut_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var brigadeControl = new Controls.BrigadeControl();
            brigadeControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(brigadeControl, 1, 1);
        }

        private void Furniture_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var accessoriesControl = new Controls.AccessoriesControl();
            accessoriesControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(accessoriesControl, 1, 1);
        }
        private void FurnitureForModel_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var accessoriesForModelControl = new Controls.AccessoriesForModelControl();
            accessoriesForModelControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(accessoriesForModelControl, 1, 1);
        }
        private void Colour_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var colourControl = new Controls.ColourControl();
            colourControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(colourControl, 1, 1);
        }
        private void Layout_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var layoutControl = new Controls.LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(layoutControl, 1, 1);
        }
        private void Cutting_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var cuttingControl = new Controls.CuttingControl();
            cuttingControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(cuttingControl, 1, 1);
        }
        private void Tailoring_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var tailoringControl = new Controls.TailoringControl();
            tailoringControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(tailoringControl, 1, 1);
        }
        private void OTK_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var OTKControl = new Controls.OTKControl();
            OTKControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(OTKControl, 1, 1);
        }
        private void Packing_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var packingControl = new Controls.PackingControl();
            packingControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(packingControl, 1, 1);
        }
        private void Post_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var postControl = new Controls.PostControl();
            postControl.Dock = DockStyle.Fill;

            tableLayoutPanel1.Controls.Add(postControl, 1, 1);


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {



        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is UserControl)
                {
                    UserControl userControl = (UserControl)control;
                    if (userControl.Visible)
                    {
                        Type type;
                        FieldInfo[] fields;

                        MessageBox.Show(userControl.Name);
                        switch (userControl.Name)
                        {
                            case "ClientControl":
                                ClientControl clientControl = new ClientControl();
                                type = typeof(client);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm = new AddForm(fields.Length, type.Name);
                                addForm.Show();

                                break;
                            case "Client_Order":
                                type = typeof(Classes.Client_Order);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm1 = new AddForm(fields.Length, type.Name);
                                addForm1.Show();
                                break;
                            case "EmployeeControl":
                                type = typeof(employee);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm2 = new AddForm(fields.Length, type.Name);
                                addForm2.Show();
                                break;
                            case "AccessoriesControl":
                                type = typeof(Accessories);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm3 = new AddForm(fields.Length, type.Name);
                                addForm3.Show();
                                break;
                            case "AccessoriesForModelControl":
                                type = typeof(Accessories);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm4 = new AddForm(fields.Length, type.Name);
                                addForm4.Show();
                                break;
                            case "BrigadeControl":
                                type = typeof(brigade);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm5 = new AddForm(fields.Length, type.Name);
                                addForm5.Show();
                                break;
                            case "PostControl":
                                type = typeof(post);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm6 = new AddForm(fields.Length, type.Name);
                                addForm6.Show();
                                break;
                            case "ColourControl":
                                type = typeof(Colour);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm7 = new AddForm(fields.Length, type.Name);
                                addForm7.Show();
                                break;
                            case "LayoutControl":
                                type = typeof(Layout);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm8 = new AddForm(fields.Length, type.Name);
                                addForm8.Show();
                                break;
                            case "CuttingControl":
                                type = typeof(Cutting);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm9 = new AddForm(fields.Length, type.Name);
                                addForm9.Show();
                                break;
                            case "TailoringControl":
                                type = typeof(Tailoring);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm10 = new AddForm(fields.Length, type.Name);
                                addForm10.Show();
                                break;
                            case "OTKControl":
                                type = typeof(OTK);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm11 = new AddForm(fields.Length, type.Name);
                                addForm11.Show();
                                break;
                            case "PackingControl":
                                type = typeof(Packing);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm12 = new AddForm(fields.Length, type.Name);
                                addForm12.Show();
                                break;
                            case "EquipmentControl":
                                type = typeof(Equipment);
                                fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                                AddForm addForm13 = new AddForm(fields.Length, type.Name);
                                addForm13.Show();
                                break;
                            default: break;
                        }

                    }
                }
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            var dvaControl = tableLayoutPanel1.Controls.OfType<DvaControl>().FirstOrDefault();
            if (dvaControl != null)
            {
                tableLayoutPanel1.Controls.Remove(dvaControl);
            }
            if (tableLayoutPanel1.Controls.Count <= 4)
            {

            }
            else { tableLayoutPanel1.Controls.RemoveAt(4); }
            var equipmentControl = new Controls.EquipmentControl();
            equipmentControl.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Controls.RemoveAt(4);
            tableLayoutPanel1.Controls.Add(equipmentControl, 1, 1);
        }
        public bool Human = true;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Human == true)
            {
                HumanContainer.Height = HumanContainer.Height + 10;
                if (HumanContainer.Height == HumanContainer.MaximumSize.Height)
                {
                    Human = false;
                    HumanTimer.Stop();
                }
            }
            else
            {

                HumanContainer.Height -= 10;
                if (HumanContainer.Height == HumanContainer.MinimumSize.Height)
                {
                    Human = true;
                    HumanTimer.Stop();
                }


            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            HumanTimer.Start();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            ProcTimer.Start();
        }
        public bool Proc = true;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Proc == true)
            {
                panel1.Height = panel1.Height + 10;
                if (panel1.Height == panel1.MaximumSize.Height)
                {
                    Proc = false;
                    ProcTimer.Stop();
                }
            }
            else
            {

                panel1.Height -= 10;
                if (panel1.Height == panel1.MinimumSize.Height)
                {
                    Proc = true;
                    ProcTimer.Stop();
                }


            }
        }
        public bool Menu = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Menu == true)
            {
                tableLayoutPanel1.ColumnStyles[0].Width -= 5;

                if (tableLayoutPanel1.ColumnStyles[0].Width <= 30)
                {
                    Menu = false;
                    MenuTimer.Stop();
                }
            }
            else
            {

                tableLayoutPanel1.ColumnStyles[0].Width += 10;
                if (tableLayoutPanel1.ColumnStyles[0].Width >= 214)
                {
                    Menu = true;
                    MenuTimer.Stop();
                }


            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CloseTimer.Start();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
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

        private void button17_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            Type type;
            FieldInfo[] fields;
            type = typeof(Users);
            fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            AddForm addForm = new AddForm(2, type.Name);
            addForm.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AutorisationForm form = new AutorisationForm();
            form.Show();
            this.Close();
        }
        bool close = true;
        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (close == true)
            {
                panel2.Height += 15;

                if (panel2.Height >= panel2.MaximumSize.Height)
                {
                    close = false;
                    CloseTimer.Stop();
                }
            }
            else
            {

                panel2.Height -= 15;
                if (panel2.Height <= panel2.MinimumSize.Height)
                {
                    close = true;
                    CloseTimer.Stop();
                }


            }
        }
    }
}
