using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2
{
    internal class Unit
    {
        public string Name { get; set; }
        public int Price { get; set; }

        private int _health;
        private int _maxHealth;

        private bool _isDead = false;

        public Unit(string name, int price, int health, int speed, int minDamage, int maxDamage)
        {
            Name = name;
            Price = price;
            _health = health;
            Speed = speed;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            _maxHealth = health;
        }

        public int Speed { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int Health
        {
            get => _health;
            set
            {
                if (value > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                {
                    if (value <= 0)
                    {
                        _health = 0;
                        Console.WriteLine($"{Name} уничтожен");
                        _isDead = true;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Health - {_health} Speed - {Speed} Price - {Price}");
        }
    }
}
