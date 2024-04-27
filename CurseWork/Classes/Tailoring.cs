using System.ComponentModel.DataAnnotations;

namespace CurseWork.Classes
{
    public class Tailoring
    {
        [Key]
       
            public int Id { get; set; }
            public int Quantity { get; set; }
            public int id_Cutting { get; set; }
           // public Cutting Cutting { get; set; }
            public int id_Equipment { get; set; }
           // public Equipment Equipment { get; set; }
        
    }
}
