using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork.Classes
{
    public class Users
    {
       
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
