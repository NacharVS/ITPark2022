using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class Shaman 
    {
        public void HealSomebody(Peasant ascascs)
        {
            if (ascascs.isDead)
            {
                Console.WriteLine("Пока не могу воскрешать мертвых");
            }
            else
            {
                ascascs.Health += 5;
                Console.WriteLine($"Healed {ascascs.name} current health {ascascs.Health}");
            }
           
        }
    }
}
