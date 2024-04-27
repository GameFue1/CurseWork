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
    public partial class AccessoriesForModelControl : UserControl
    {
        public AccessoriesForModelControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string response = ApiRequest.getJSON("api/Accessories_For_Model").Result;
            Accessories_For_Model[] employee = JsonConvert.DeserializeObject<Accessories_For_Model[]>(response);
            dataGridView1.DataSource = employee;
            dataGridView1.Columns[0].Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
