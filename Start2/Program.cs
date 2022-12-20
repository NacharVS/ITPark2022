using Start2.BankAccount;
using Start2.Weapons;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            Peasant peasant = new Peasant("Ivan", 300, 9, 5, 1, 5, 500, 30);
            Peasant peasant2 = new Peasant("Panteleymon", 300, 12, 5, 1, 5, 500, 30);
            Peasant peasant3 = new Peasant("Varfolomey", 300, 19, 5, 1, 5, 500, 30);
            peasant.ShowInfo();
            Shaman shaman = new Shaman(50);
            shaman.HealSomebody(peasant3);
            peasant3.ShowInfo();
            shaman.HealSomebody(peasant);
            peasant.ShowInfo();
            shaman.ShowInfo();
            shaman.HealSomebody(peasant2);
            peasant2.ShowInfo();

        }
    }

     


}

