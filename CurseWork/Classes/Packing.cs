using System.ComponentModel.DataAnnotations;

namespace CurseWork.Classes
{
    public class Packing
    {
        [Key]
        public int Id { get; set; }
        public int id_OTK { get; set; }
      //  public OTK OTK { get; set; }
        public string Mark { get; set; }
    }
}
