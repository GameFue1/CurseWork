using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CurseWork.Classes
{
    public class Accessories
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double UnitsOfMeasurement { get; set; }
    }
}
