using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class Shaman : Unit
    {
        public Shaman(string name, int price, int health, int speed, int minDamage, int maxDamage) : base(name, price, health, speed, minDamage, maxDamage)
        {
        }

        public int Energy { get; set; }
        public void HealSomebody(Unit unit)
        {
            //if (Energy > 0)
            //{
            //    if(unit.Health != unit.MaxHealth)
            //    {
            //        while (Energy > 0 && unit.Health < unit.MaxHealth)
            //        {
            //            unit.Health += 5;
            //            Energy--; // Energy = Energy - 1;
            //        }
            //    }
            //    else
            //        Console.WriteLine($" {unit.name} Не нуждается в лечении");
            //}
            //else
            //    Console.WriteLine("Не хватает энергии");
           
        }
    }
}
