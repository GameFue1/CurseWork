﻿using CurseWork.Classes;
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
    public partial class PostControl : UserControl
    {
        public PostControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string response = ApiRequest.getJSON("api/post").Result;
            post[] posts = JsonConvert.DeserializeObject<post[]>(response);
            dataGridView1.DataSource = posts;
            dataGridView1.Columns[0].Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
