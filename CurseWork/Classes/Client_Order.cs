using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork.Classes
{
    internal class Client_Order
    {
        public int id { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public DateTime date_order { get; set; }
        public int id_client { get; set; }
       // private client clients { get; set; }
        public int id_brigade { get; set; }
       // private brigade brigades { get; set; }
    }
}
