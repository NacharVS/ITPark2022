﻿using Start2.BankAccount;
using Start2.Weapons;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            ClientAccount acc1 = new ClientAccount("Vadim", "Standart");
            ClientAccount acc2 = new ClientAccount("Andrey", "Gold");
            acc1.ShowAccountInfo();
            acc1.Deposit(90000);
            acc1.Widtraw(10000);
            acc1.ShowAccountInfo();
            acc1.Widtraw(100000);
            acc1.ShowAccountInfo();





            // Создать список, каждый элемент которого представляет из себя класс User c Именем, фамилией и телефоном.
            // Реализовать добавление нового юзера в список
            // Реализовать проверку на то, что такой юзер есть в списке***
        }
    }

     


}

