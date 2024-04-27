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
    public partial class AccessoriesControl : UserControl
    {
        public AccessoriesControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string response = ApiRequest.getJSON("api/Accessories").Result;
            Accessories[] employee = JsonConvert.DeserializeObject<Accessories[]>(response);
            dataGridView1.DataSource = employee;
            dataGridView1.Columns[0].Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
