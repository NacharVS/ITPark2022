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

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


    }
}
