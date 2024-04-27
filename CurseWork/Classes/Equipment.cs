using System.ComponentModel.DataAnnotations;

namespace CurseWork.Classes
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string model { get;set; }
        public string type_equip { get; set; }
        public int quantity { get; set; }
    }
}
