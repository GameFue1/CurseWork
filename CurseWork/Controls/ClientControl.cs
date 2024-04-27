using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;
using System.Data;
using CurseWork.Classes;

namespace CurseWork
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
            getdata();
            //dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.DefaultCellStyle.BackColor = Color.Transparent;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Transparent;
            //dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Transparent;
            //tableLayoutPanel1.BackColor = Color.Transparent;

            //tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            // DataGridViewHeaderCell.Style.BackColor = System.Drawing.Color.Transparent;
        }
        public void getdata()
        {

            string response = ApiRequest.getJSON("/api/Client").Result;
            client[] clients = JsonConvert.DeserializeObject<client[]>(response);
            dataGridView1.DataSource = clients;
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
