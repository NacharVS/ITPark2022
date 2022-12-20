using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class RangeUnit : Unit
    {
        public RangeUnit(string name, int price, int health, int speed, int minDamage, int maxDamage, int range) : base(name, price, health, speed, minDamage, maxDamage)
        {
            Range = range;
        }

        public int Range { get; set; }

        public void Shoot()
        {
            Console.WriteLine($"{Name} выстрелил! Дфльность {Range}");
        }
    }
}
