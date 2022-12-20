using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class Shaman 
    {
        public Shaman()
        {
            Energy = 60;
        }

        public Shaman(int energy)
        {
            Energy = energy;
        }

        public int Energy { get; set; }
        public void HealSomebody(Peasant unit)
        {
            if (Energy > 0)
            {
                if(unit.Health != unit.MaxHealth)
                {
                    while (Energy > 0 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 5;
                        Energy--; // Energy = Energy - 1;
                    }
                }
                else
                    Console.WriteLine($" {unit.name} Не нуждается в лечении");
            }
            else
                Console.WriteLine("Не хватает энергии");
           
        }

        public void ShowInfo()
        {
            Console.WriteLine($"energy {Energy}");
        }
    }
}
