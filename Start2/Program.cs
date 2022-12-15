using Start2.BankAccount;
using Start2.Weapons;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            Peasant peasant = new Peasant("Ivan", 200, 30, 5, 1, 5, 500);
            Peasant peasant2 = new Peasant("Andriyan", 200, 30, 5, 1, 5, 500);
            peasant2.ShowInfo();
            peasant.InflictDamageUntilDeath(peasant2);



        }
    }

     


}

