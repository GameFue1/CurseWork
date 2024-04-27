using System.ComponentModel.DataAnnotations;

namespace CurseWork.Classes
{
    public class OTK
    {
        [Key]
       
            public int Id { get; set; }
            public int id_Tailoring { get; set; }
           // public Tailoring Tailoring { get; set; }
            public string Quality { get; set; }
        
    }
}
