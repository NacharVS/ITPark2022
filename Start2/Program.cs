using Start2.BankAccount;
using Start2.Weapons;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            Peasant peasant = new Peasant("Ivan", 300, 30, 5, 1, 5);      
            Shaman shaman = new Shaman("Boromir", 900, 40, 7, 2, 8);
            Archer archer = new Archer("Legolas", 1200, 60, 12, 3, 9, 15);
            Warrior warrior = new Warrior("Boris", 600, 80, 8, 2, 9);
            peasant.ShowInfo();
            warrior.OneHit(shaman);
            warrior.OneHit(shaman);
            warrior.OneHit(shaman);
            warrior.OneHit(shaman); 
            warrior.OneHit(shaman); 
            warrior.OneHit(shaman);
            warrior.OneHit(shaman);
            warrior.OneHit(shaman);
            warrior.OneHit(shaman);





        }
    }

     


}

