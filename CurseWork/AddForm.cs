using CurseWork.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using CurseWork.Models;
using System.Reflection;
using System.Net.Sockets;

namespace CurseWork
{
    public partial class AddForm : Form
    {
        public string classFromN;

        private List<TextBox> textBoxesList = new List<TextBox>();
        public AddForm(int columnCount, string classFrom1)
        {
            InitializeComponent();

            classFromN = classFrom1;
            CustomizeButton(button1);
            List<string> placeHolders = new List<string>();
            switch (classFromN)
            {
                case "client":
                    placeHolders.Add("Код");
                    placeHolders.Add("ФИО");
                    placeHolders.Add("Телефон");
                    placeHolders.Add("Почта");
                    placeHolders.Add("Адрес");
                    break;
                case "Client_Order":
                    placeHolders.Add("Код");
                    placeHolders.Add("Модель");
                    placeHolders.Add("Кол-во");
                    placeHolders.Add("Дата");
                    placeHolders.Add("Код клиента");
                    placeHolders.Add("Код бригады");

                    break;
                case "employee":
                    placeHolders.Add("Код");
                    placeHolders.Add("ФИО");
                    placeHolders.Add("Номер телефона");
                    placeHolders.Add("Код бригады");
                    placeHolders.Add("Код должности");



                    break;

                case "Accessories":
                    placeHolders.Add("Код");
                    placeHolders.Add("Название");
                    placeHolders.Add("Кол-во упаковок");
                    placeHolders.Add("Кол-во в одной упаковке");

                    break;
                case "AccessoriesForModel":
                    placeHolders.Add("Код пошива");
                    placeHolders.Add("Код фурнитуры");
                    placeHolders.Add("Кол-во");
                    break;
                case "brigade":
                    placeHolders.Add("Код");
                    placeHolders.Add("Название");
                    break;
                case "post":
                    placeHolders.Add("Код");
                    placeHolders.Add("Название");
                    break;
                case "Colour":
                    placeHolders.Add("Код");
                    placeHolders.Add("Название");

                    break;
                case "Layout":

                    placeHolders.Add("Код");
                    placeHolders.Add("Код заказа");
                    placeHolders.Add("Кол-во");
                    placeHolders.Add("Код основного цвета");
                    placeHolders.Add("Код отделочного цвета");
                    placeHolders.Add("Код оборудования");

                    break;
                case "Cutting":
                    placeHolders.Add("Код");
                    placeHolders.Add("Код раскладки");
                    placeHolders.Add("Кол-во");

                    placeHolders.Add("Код оборудования");

                    break;
                case "Tailoring":

                    placeHolders.Add("Код");
                    placeHolders.Add("Кол-во");
                    placeHolders.Add("Код раскроя");
                    placeHolders.Add("Код оборудования");


                    break;
                case "OTK":

                    placeHolders.Add("Код");
                    placeHolders.Add("Соответствие");
                    placeHolders.Add("Код пошива");
                    break;
                case "Packing":

                    placeHolders.Add("Код");
                    placeHolders.Add("Маркировка");
                    placeHolders.Add("Код ОТК");
                    break;
                case "Users":

                    placeHolders.Add("Код");
                    placeHolders.Add("Роль");
                    
                    break;
                default:
                    break;
            }
            CreateTextBoxes(columnCount, placeHolders);
        }
        private void CustomizeButton(Button button)
        {
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 227, 156);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 227, 156);
        }
        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateTextBoxes(int columnCount, List<string> str)
        {
            int leftMargin = 20;
            int topMargin = 50;
            int textBoxWidth = 200;
            int textBoxHeight = 32;

            for (int i = 0; i < columnCount; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + i;
                textBox.Location = new System.Drawing.Point(leftMargin, topMargin + i * (textBoxHeight + 5));
                textBox.Size = new System.Drawing.Size(textBoxWidth, textBoxHeight);
                textBox.PlaceholderText = str[i];

                textBoxesList.Add(textBox);
                this.Controls.Add(textBox);
            }

        }
        public string GetTextFromTextBox(int index)
        {
            if (index >= 0 && index < textBoxesList.Count)
            {
                return textBoxesList[index].Text;
            }
            return string.Empty;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var jsonData = "";
            var response = "";
            switch (classFromN)
            {
                case "client":
                    client client = new client
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        FIO = GetTextFromTextBox(1),
                        phone = GetTextFromTextBox(2),
                        Email = GetTextFromTextBox(3),
                        Adress = GetTextFromTextBox(4)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(client);
                    response = ApiRequest.sendPostJSON("api/Client/ClientP", jsonData).Result;
                    break;
                case "Client_Order":
                    Client_Order client_order = new Client_Order
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        model = GetTextFromTextBox(1),
                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        date_order = Convert.ToDateTime(GetTextFromTextBox(3)),
                        id_client = Convert.ToInt32(GetTextFromTextBox(4)),
                        id_brigade = Convert.ToInt32(GetTextFromTextBox(5)),
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(client_order);
                    response = ApiRequest.sendPostJSON("api/ClientOrder/ClientOrderP", jsonData).Result;

                    break;
                case "employee":
                    employee emp = new employee
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        FIO = GetTextFromTextBox(1),
                        Phone = GetTextFromTextBox(2),
                        id_Post = Convert.ToInt32(GetTextFromTextBox(3)),
                        id_brigade = Convert.ToInt32(GetTextFromTextBox(4)),
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(emp);
                    response = ApiRequest.sendPostJSON("api/employee/EmployeeP", jsonData).Result;
                    break;
                case "Accessories":
                    Accessories accessories = new Accessories
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        name = GetTextFromTextBox(1),

                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        UnitsOfMeasurement = Convert.ToDouble(GetTextFromTextBox(3)),

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(accessories);
                    response = ApiRequest.sendPostJSON("api/Accessories/AccessoriesP", jsonData).Result;
                    break;
                case "AccessoriesForModel":
                    Accessories_For_Model accessoriesFM = new Accessories_For_Model
                    {
                        id_Accessories = Convert.ToInt32(GetTextFromTextBox(0)),
                        id_Tailoring = Convert.ToInt32(GetTextFromTextBox(1)),

                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(accessoriesFM);
                    response = ApiRequest.sendPostJSON("api/Accessories_For_Model/AccessoriesFM", jsonData).Result;
                    break;
                case "brigade":
                    brigade Brigade = new brigade
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Name = GetTextFromTextBox(1)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(Brigade);
                    response = ApiRequest.sendPostJSON("api/brigade/brigadeP", jsonData).Result;
                    break;
                case "post":
                    post Post = new post
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        name = GetTextFromTextBox(1)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(Post);
                    response = ApiRequest.sendPostJSON("api/post/postP", jsonData).Result;
                    break;
                case "Colour":
                    Colour colour = new Colour
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        name = GetTextFromTextBox(1)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(colour);
                    response = ApiRequest.sendPostJSON("api/Colour/ColourP", jsonData).Result;
                    break;
                case "Layout":
                    Layout layout = new Layout
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        id_order = Convert.ToInt32(GetTextFromTextBox(1)),
                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        id_main_colour = Convert.ToInt32(GetTextFromTextBox(3)),
                        id_additional_colour = Convert.ToInt32(GetTextFromTextBox(4)),
                        id_Equipment = Convert.ToInt32(GetTextFromTextBox(5))

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(layout);
                    response = ApiRequest.sendPostJSON("api/Colour/LayoutP", jsonData).Result;
                    break;
                case "Cutting":
                    Cutting cutting = new Cutting
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        id_Layout = Convert.ToInt32(GetTextFromTextBox(1)),
                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        id_Equipment = Convert.ToInt32(GetTextFromTextBox(3))

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(cutting);
                    response = ApiRequest.sendPostJSON("api/Colour/CuttingP", jsonData).Result;
                    break;
                case "Tailoring":
                    Tailoring tailoring = new Tailoring
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Quantity = Convert.ToInt32(GetTextFromTextBox(1)),
                        id_Cutting = Convert.ToInt32(GetTextFromTextBox(2)),
                        id_Equipment = Convert.ToInt32(GetTextFromTextBox(3))
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(tailoring);
                    response = ApiRequest.sendPostJSON("api/Colour/TailoringP", jsonData).Result;
                    break;
                case "OTK":
                    OTK otk = new OTK
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Quality = GetTextFromTextBox(1),
                        id_Tailoring = Convert.ToInt32(GetTextFromTextBox(2)),

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(otk);
                    response = ApiRequest.sendPostJSON("api/Colour/OTKP", jsonData).Result;
                    break;
                case "Packing":
                    Packing packing = new Packing
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Mark = GetTextFromTextBox(1),
                        id_OTK = Convert.ToInt32(GetTextFromTextBox(2)),

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(packing);
                    response = ApiRequest.sendPostJSON("api/Colour/PackingP", jsonData).Result;
                    break;
                default: break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var jsonData = "";
            var response = "";
            switch (classFromN)
            {
                case "client":
                    client client = new client
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        FIO = GetTextFromTextBox(1),
                        phone = GetTextFromTextBox(2),
                        Email = GetTextFromTextBox(3),
                        Adress = GetTextFromTextBox(4)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(client);
                    response = ApiRequest.sendPostJSON("api/Client/ClientU", jsonData).Result;
                    break;
                case "Client_Order":
                    Client_Order client_order = new Client_Order
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        model = GetTextFromTextBox(1),
                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        date_order = Convert.ToDateTime(GetTextFromTextBox(3)),
                        id_client = Convert.ToInt32(GetTextFromTextBox(4)),
                        id_brigade = Convert.ToInt32(GetTextFromTextBox(5)),
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(client_order);
                    response = ApiRequest.sendPostJSON("api/ClientOrder/ClientOrderU", jsonData).Result;

                    break;
                case "employee":
                    employee emp = new employee
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        FIO = GetTextFromTextBox(1),
                        Phone = GetTextFromTextBox(2),
                        id_Post = Convert.ToInt32(GetTextFromTextBox(3)),
                        id_brigade = Convert.ToInt32(GetTextFromTextBox(4)),
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(emp);
                    response = ApiRequest.sendPostJSON("api/employee/EmployeeU", jsonData).Result;
                    break;
                case "Accessories":
                    Accessories accessories = new Accessories
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        name = GetTextFromTextBox(1),

                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        UnitsOfMeasurement = Convert.ToDouble(GetTextFromTextBox(3)),
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(accessories);
                    response = ApiRequest.sendPostJSON("api/Accessories/AccessoriesU", jsonData).Result;
                    break;
                case "AccessoriesForModel":
                    Accessories_For_Model accessoriesFM = new Accessories_For_Model
                    {
                        id_Accessories = Convert.ToInt32(GetTextFromTextBox(0)),
                        id_Tailoring = Convert.ToInt32(GetTextFromTextBox(1)),

                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(accessoriesFM);
                    response = ApiRequest.sendPostJSON("api/Accessories_For_Model/AccessoriesFMU", jsonData).Result;
                    break;
                case "brigade":
                    brigade Brigade = new brigade
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Name = GetTextFromTextBox(1)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(Brigade);
                    response = ApiRequest.sendPostJSON("api/brigade/brigadeU", jsonData).Result;
                    break;
                case "post":
                    post Post = new post
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        name = GetTextFromTextBox(1)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(Post);
                    response = ApiRequest.sendPostJSON("api/post/postU", jsonData).Result;
                    break;
                case "Colour":
                    Colour colour = new Colour
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        name = GetTextFromTextBox(1)
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(colour);
                    response = ApiRequest.sendPostJSON("api/Colour/ColourU", jsonData).Result;
                    break;
                case "Layout":
                    Layout layout = new Layout
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        id_order = Convert.ToInt32(GetTextFromTextBox(1)),
                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        id_main_colour = Convert.ToInt32(GetTextFromTextBox(3)),
                        id_additional_colour = Convert.ToInt32(GetTextFromTextBox(4)),
                        id_Equipment = Convert.ToInt32(GetTextFromTextBox(5))

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(layout);
                    response = ApiRequest.sendPostJSON("api/Colour/LayoutU", jsonData).Result;
                    break;
                case "Cutting":
                    Cutting cutting = new Cutting
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        id_Layout = Convert.ToInt32(GetTextFromTextBox(1)),
                        quantity = Convert.ToInt32(GetTextFromTextBox(2)),
                        id_Equipment = Convert.ToInt32(GetTextFromTextBox(3))
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(cutting);
                    response = ApiRequest.sendPostJSON("api/Colour/CuttingU", jsonData).Result;
                    break;
                case "Tailoring":
                    Tailoring tailoring = new Tailoring
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Quantity = Convert.ToInt32(GetTextFromTextBox(1)),
                        id_Cutting = Convert.ToInt32(GetTextFromTextBox(2)),
                        id_Equipment = Convert.ToInt32(GetTextFromTextBox(3))
                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(tailoring);
                    response = ApiRequest.sendPostJSON("api/Colour/TailoringU", jsonData).Result;
                    break;
                case "OTK":
                    OTK otk = new OTK
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Quality = GetTextFromTextBox(1),
                        id_Tailoring = Convert.ToInt32(GetTextFromTextBox(2)),

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(otk);
                    response = ApiRequest.sendPostJSON("api/Colour/OTKU", jsonData).Result;
                    break;
                case "Packing":
                    Packing packing = new Packing
                    {
                        Id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Mark = GetTextFromTextBox(1),
                        id_OTK = Convert.ToInt32(GetTextFromTextBox(2)),

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(packing);
                    response = ApiRequest.sendPostJSON("api/Colour/PackingU", jsonData).Result;
                    break;
                case "Users":
                    Users user = new Users
                    {
                        id = Convert.ToInt32(GetTextFromTextBox(0)),
                        Login = "",
                        Password = "",
                        UserRole = GetTextFromTextBox(1),
                     

                    };
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(user);
                    response = ApiRequest.sendPostJSON("api/Users/UsersU", jsonData).Result;
                    break;
                default: break;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var jsonData = "";
            var response = "";
            var data = new
            {
                Id = Convert.ToInt32(GetTextFromTextBox(0))
            };
            switch (classFromN)
            {
                case "client":
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Client/ClientD", jsonData).Result;
                    break;
                case "Client_Order":
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/ClientOrder/ClientOrderD", jsonData).Result;

                    break;
                case "employee":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/employee/EmployeeD", jsonData).Result;
                    break;
                case "Accessories":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Accessories/AccessoriesD", jsonData).Result;
                    break;
                case "AccessoriesForModel":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Accessories_For_Model/AccessoriesFMD", jsonData).Result;
                    break;
                case "brigade":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/brigade/brigadeD", jsonData).Result;
                    break;
                case "post":
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/post/postD", jsonData).Result;
                    break;
                case "Colour":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Colour/ColourD", jsonData).Result;
                    break;
                case "Layout":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Colour/LayoutD", jsonData).Result;
                    break;
                case "Cutting":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Colour/CuttingD", jsonData).Result;
                    break;
                case "Tailoring":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Colour/TailoringD", jsonData).Result;
                    break;
                case "OTK":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Colour/OTKD", jsonData).Result;
                    break;
                case "Packing":

                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    response = ApiRequest.sendPostJSON("api/Colour/PackingD", jsonData).Result;
                    break;
                default:
                    break;
            }
        }
    }
}
