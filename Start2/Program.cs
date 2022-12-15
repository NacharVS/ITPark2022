using Start2.BankAccount;
using Start2.Weapons;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            Peasant peasant = new Peasant("Ivan");
            Peasant peasant2 = new Peasant("Andriyan");
            Shaman shaman = new Shaman();
            peasant2.ShowInfo();
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant2.ShowInfo();
            shaman.HealSomebody(peasant2);
            shaman.HealSomebody(peasant2);
            shaman.HealSomebody(peasant2);
            shaman.HealSomebody(peasant2);
            shaman.HealSomebody(peasant2);

            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            peasant.Onehit(peasant2);
            shaman.HealSomebody(peasant2);
            shaman.HealSomebody(peasant2);
            shaman.HealSomebody(peasant2);
            peasant2.ShowInfo();


        }
    }

     


}

