using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCodeFirstMethod.DataModel
{
    public class Armor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Player Player { get; set; }
        public virtual ArmorType ArmorType { get; set; }
    }
}
