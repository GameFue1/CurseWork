using System.ComponentModel.DataAnnotations;

namespace CurseWork.Classes
{
    public class Accessories_For_Model
    {
        [Key]
        public int id_Tailoring { get; set; }
       // public Tailoring Tailoring { get; set; }
        public int id_Accessories { get; set; }
      //  public Accessories Accessories { get; set; }
        public int quantity { get; set; }
    }
}
