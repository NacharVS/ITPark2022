using System;

namespace Start2
{
    class Peasant : Unit
    {
        public Peasant(string name, int price, int health, int speed, int minDamage, int maxDamage) : base(name, price, health, speed, minDamage, maxDamage)
        {
        }

        public void Work()
        {
            Console.WriteLine($"{Name} принялся за работу");
        }
    }
}
