using Start2.Weapons;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            Weapon weapon = new Weapon(20, 50, 4, "red", 0.6, false);
            Console.WriteLine(weapon.MinDamage);          
            weapon.MinDamage = 30;
            weapon.Info();
            weapon.MinDamage = 10000;
            weapon.Info();








            // Создать список, каждый элемент которого представляет из себя класс User c Именем, фамилией и телефоном.
            // Реализовать добавление нового юзера в список
            // Реализовать проверку на то, что такой юзер есть в списке***
        }
    }

     


}

