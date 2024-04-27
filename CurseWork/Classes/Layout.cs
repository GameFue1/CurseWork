using System.ComponentModel.DataAnnotations;
using CurseWork.Classes;
namespace CurseWork.Classes
{
    public class Layout
    {
        
    public int id { get; set; }
    public int id_order { get; set; }
   // public Client_Order Client_Order { get; set; }
 public int quantity { get; set; }
public int id_main_colour { get; set; }
        
public int id_additional_colour { get; set; }
       // public Colour? Colour { get; set; }
       public int id_Equipment { get; set; }
      //  public Equipment? Equipment { get; set; }
    }
}
