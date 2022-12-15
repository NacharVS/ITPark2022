using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class Shaman 
    {
        public void HealSomebody(Peasant peasant)
        {
            
            peasant.Health += 5;
            Console.WriteLine($"Healed {peasant.name} current health {peasant.Health}");
        }
    }
}
