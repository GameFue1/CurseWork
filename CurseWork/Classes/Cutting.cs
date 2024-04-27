using System.ComponentModel.DataAnnotations;

namespace CurseWork.Classes
{
    public class Cutting
    {
        [Key]
        public int id { get; set; }
        public int quantity { get; set; }
        public int id_Layout { get; set; }
        public Layout Layout { get; set; }
        public int id_Equipment { get; set; }
        public Equipment Equipment { get; set; }
    }
}
