using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    class Warrior : Unit
    {
        public Warrior(string name, int price, int health, int speed, int minDamage, int maxDamage) : base(name, price, health, speed, minDamage, maxDamage)
        {
        }
    }
}
