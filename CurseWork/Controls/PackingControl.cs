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
    public partial class PackingControl : UserControl
    {
        public PackingControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string response = ApiRequest.getJSON("api/Packing").Result;
            Packing[] packings = JsonConvert.DeserializeObject<Packing[]>(response);
            dataGridView1.DataSource = packings;
            dataGridView1.Columns[0].Visible = true;

        }
    }
}
