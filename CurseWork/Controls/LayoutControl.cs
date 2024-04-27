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
    public partial class LayoutControl : UserControl
    {
        public LayoutControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string response = ApiRequest.getJSON("api/Layout").Result;
            Layout[] layouts = JsonConvert.DeserializeObject<Layout[]>(response);
            dataGridView1.DataSource = layouts;
            dataGridView1.Columns[0].Visible = true;

        }
    }
}
