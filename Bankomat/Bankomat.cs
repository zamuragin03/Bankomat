using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Account:User
    {
        public int account_id { get; set; }
        public int USD_Balance { get; set; }
        public int  RUB_Balance { get; set; }
        public int PIN { get; private set; }
        public int CARDNUMBER { get; set; }

    }

    class User
    {
        public int User_id { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }

    }

    class ATM
    {
        private int ATM_id;
        public int USD_Balance { get; }
        public int RUB_Balance { get; }

        public ATM(int usdBalance, int rubBalance)
        {

            USD_Balance = usdBalance;
            RUB_Balance = rubBalance;

        }

    }
}
