using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCodeFirstMethod.DataModel
{
    public class WeaponType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
