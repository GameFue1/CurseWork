using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork.Classes
{
    public class client
    {
        
        public int Id { get; set; }
        public string FIO { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
      
    }
   
}
