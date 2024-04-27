using CurseWork.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork.Controls
{
    public partial class Client_Order : UserControl
    {
        public Client_Order()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string responseOrder = ApiRequest.getJSON("api/ClientOrder").Result;
            Classes.Client_Order[] clientOrders = JsonConvert.DeserializeObject<Classes.Client_Order[]>(responseOrder);
            //  dataGridView.DataSource = clientOrders;
            string responseClient = ApiRequest.getJSON("api/Client").Result;
            client[] Clients = JsonConvert.DeserializeObject<client[]>(responseClient);
            string responseBrigade = ApiRequest.getJSON("api/brigade").Result;
            brigade[] Brigades = JsonConvert.DeserializeObject<brigade[]>(responseBrigade);

            var joinedData = from clientOrder in clientOrders
                             join Client in Clients on clientOrder.id_client equals Client.Id
                             join Brigade in Brigades on clientOrder.id_brigade equals Brigade.id
                             select new
                             {
                                 clientOrder.model,
                                 clientOrder.quantity,
                                 clientOrder.date_order,
                                 Client.FIO,
                                 Brigade.Name
                             };
            dataGridView.DataSource = joinedData.ToList();
            dataGridView.Columns[0].HeaderText = "Название модели";
            dataGridView.Columns[1].HeaderText = "Количество";
            dataGridView.Columns[2].HeaderText = "Дата заказа";
            dataGridView.Columns[3].HeaderText = "ФИО";
            dataGridView.Columns[4].HeaderText = "Бригада выполняющая заказ";
        }
        public int GetDataGridViewColumnCount()
        {
            return dataGridView.Columns.Count;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
