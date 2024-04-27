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
    public partial class EquipmentControl : UserControl
    {
        public EquipmentControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {

            string response = ApiRequest.getJSON("/api/Equipment").Result;
            Equipment[] equipment = JsonConvert.DeserializeObject<Equipment[]>(response);
            dataGridView1.DataSource = equipment;
            dataGridView1.Columns[0].Visible = false;
        }

        public int GetDataGridViewColumnCount()
        {
            return dataGridView1.Columns.Count;
        }
        public void UpdateData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            getdata();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
