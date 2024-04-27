using CurseWork.Classes;
using CurseWork.Models;
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
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
            getdata();
        }
        public void getdata()
        {
            string responseEmployee = ApiRequest.getJSON("api/employee").Result;
            employee[] Employees = JsonConvert.DeserializeObject<employee[]>(responseEmployee);

            string responseBrigade = ApiRequest.getJSON("api/brigade").Result;
            brigade[] Brigades = JsonConvert.DeserializeObject<brigade[]>(responseBrigade);
            string responsePosts = ApiRequest.getJSON("api/post").Result;
            post[] Posts = JsonConvert.DeserializeObject<post[]>(responsePosts);
            var joinedData = from Employee in Employees
                             join Brigade in Brigades on Employee.id_brigade equals Brigade.id
                             join Post in Posts on Employee.id_Post equals Post.id
                             select new
                             {
                                 Employee.FIO,
                                 Employee.Phone,
                                 Post.name,
                                 Brigade.Name
                             };
            dataGridView1.DataSource = joinedData.ToList();
            dataGridView1.Columns[0].HeaderText = "Фамилия Имя Отчество работника";
            dataGridView1.Columns[1].HeaderText = "Номер телефона";
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[3].HeaderText = "Бригада";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

        }

        private void EmployeeControl_Resize(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }
    }
}