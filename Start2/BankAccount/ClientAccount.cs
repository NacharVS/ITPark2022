using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2.BankAccount
{    
    class ClientAccount
    {
        private string _name;

        public string AccStatus { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _balance;

        public ClientAccount(string name)
        {
            _name = name;
            _balance = 0;
        }

        public ClientAccount(string name, string accStatus) 
        {
            Name = name;
            AccStatus = accStatus;
        }

        public int Balance
        {
            get { return _balance; }
            set 
            { 
                if(AccStatus == "Standart")
                {
                    if(value > 100000)
                    {
                        Console.WriteLine("Для аккаунта Standart максимальная сумма 100000");
                    }
                        
                    else
                    {
                        if (value >= 0)
                        {
                            _balance = value;
                        }
                        else
                        {
                            Console.WriteLine("Не достаточно средств");
                        }
                    }
                }

               

            }
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine($"Accout name: {Name} Balance {Balance}");
        }
        public void Deposit(int summ)
        {
            if(summ < 0)
            {
                Console.WriteLine("Некоректное значение");
            }
            else
                Balance += summ; // Balance = Balance + summ;
        }

        public void Widtraw(int summ)
        {
            Balance -= summ;// Balance = Balance - summ;
        }
    }
}
