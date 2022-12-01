using Start2.Weapons;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            Pistol pistol = new Pistol(20, 5, "BlackMetal", 0.7, false);
            pistol.Info();
            pistol.BurstShoot();
            pistol.Info();

        }
    }


}

