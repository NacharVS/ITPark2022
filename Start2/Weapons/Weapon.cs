using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2.Weapons
{
    internal class Weapon
    {
        private int _minDamage;
        public int maxDamage;
        public int rateOfFire;
        public string color;
        public double weight;
        public int clip;
        public bool canBurstShooting;

        public int MinDamage 
        { 
            get
            {

                return _minDamage;
            }
            set
            {
                
                if(value > maxDamage)
                    _minDamage = maxDamage;
                else
                    _minDamage = value;
            }
        }

        public Weapon(int minDamage, int maxDamage, int rateOfFire, string color, double weight, bool canBurstShooting)
        {
            this._minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.rateOfFire = rateOfFire;
            this.color = color;
            this.weight = weight;
            clip = 20;
            this.canBurstShooting = canBurstShooting;
        }

        public Weapon()
        {
        }

        public void Info()
        {
            Console.WriteLine($"Weapon - Pistol. minDamage {MinDamage} maxDamage {maxDamage} Clip: {clip}");
        }
        public void Shoot()
        {
            if (clip > 0)
            {
                Random random = new Random();
                Console.WriteLine($"Piu! Inflicted Damage {random.Next(MinDamage, maxDamage)}");
                clip = clip - 1;
            }
            else
            {
                ClipIsEmpty();
            }
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

        private void ClipIsEmpty()
        {
            Console.WriteLine("Clip is empty");
        }

       
    }
}
