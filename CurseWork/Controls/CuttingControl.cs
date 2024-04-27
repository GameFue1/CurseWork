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
    public partial class CuttingControl : UserControl
    {
        public CuttingControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string response = ApiRequest.getJSON("api/Cutting").Result;
            Cutting[] cuttings = JsonConvert.DeserializeObject<Cutting[]>(response);
            dataGridView1.DataSource = cuttings;
            dataGridView1.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
