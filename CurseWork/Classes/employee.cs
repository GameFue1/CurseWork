
using CurseWork.Classes;
using System.ComponentModel.DataAnnotations;

namespace CurseWork.Models
{
    public class employee
    {
        
        public int Id { get; set; }
        public string FIO { get; set; }
        public int id_brigade{ get; set; }
      //  public brigade Brigade { get; set; }
        public int id_Post { get; set; }
     //   public post Post { get; set; }
        public string Phone { get; set; }
    }
}
