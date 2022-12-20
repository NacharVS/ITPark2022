using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class Archer : RangeUnit
    {
        public Archer(string name, int price, int health, int speed, int minDamage, int maxDamage, int range) : base(name, price, health, speed, minDamage, maxDamage, range)
        {
        }
    }
}
