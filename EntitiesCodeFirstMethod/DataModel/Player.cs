using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCodeFirstMethod.DataModel
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? WeaponId { get; set; }
        public int? ArmorId { get; set; }
        public virtual ICollection<Armor> Armors { get; set; }
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
