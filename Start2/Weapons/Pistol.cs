using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2.Weapons
{
    internal class Pistol
    {

        public int damage;
        public int rateOfFire;
        public string color;
        public double weight;
        public int clip;
        public bool canBurstShooting;

        public Pistol(int damage, int rateOfFire, string color, double weight, bool canBurstShooting)
        {
            this.damage = damage;
            this.rateOfFire = rateOfFire;
            this.color = color;
            this.weight = weight;
            clip = 20;
            this.canBurstShooting = canBurstShooting;
        }

        public void Info()
        {
            Console.WriteLine($"Weapon - Pistol. Damage {damage} Clip: {clip}");
        }
        public void Shoot()
        {
            Console.WriteLine($"Piu! Damage {damage}");
            clip--;
        }

        public void BurstShoot()
        {
            if (canBurstShooting)
            {
                Shoot();
                Shoot();
                Shoot();
            }
            else
                Shoot();
        }
    }
}
