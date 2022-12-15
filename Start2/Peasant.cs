﻿using System;

namespace Start2
{
    class Peasant
    {

        //сделать свойствао для Health так, чтобы при нанесении урона превышающего остаток здооровья, здоровье было всегда 0
        public string name;
        public int price;
        private int _health;
        private bool _isDead = false;
        public int speed;
        public int minDamage;
        public int maxDamage;
        public int maXWeight;

        public int Health 
        { 
            get => _health;
            set
            {
                if(value <= 0)
                {
                    _health = 0;
                    Console.WriteLine($"{name} уничтожен");
                    _isDead = true;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public Peasant()
        {
        }

        public Peasant(string name, int price, int health, int speed, int minDamage, int maxDamage, int maXWeight)
        {
            this.name = name;
            this.price = price;
            this._health = health;
            this.speed = speed;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.maXWeight = maXWeight;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit - Peasant. Name - {name} Health - {_health} Speed - {speed}");
        }

        public void Onehit(Peasant unit)
        {
            Random random = new Random();
            unit.Health = unit.Health - random.Next(minDamage, maxDamage);
        }

        public void InflictDamageUntilDeathDemo(Peasant peasant)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                if(peasant.Health <= 0)
                {
                    Console.WriteLine("Противник убит");
                    break;

                }
                else
                {               
                    peasant.Health = peasant.Health - random.Next(minDamage, maxDamage);
                    Console.WriteLine($"Здоровье противника:{peasant.Health}");
                }
            }
        }

        public void InflictDamageUntilDeath(Peasant peasant)
        {
            Random random = new Random();

            while (!peasant._isDead)
            {
                peasant.Health = peasant.Health - random.Next(minDamage, maxDamage);
                Console.WriteLine($"Здоровье противника:{peasant.Health}");
            }
        }




    }
}
