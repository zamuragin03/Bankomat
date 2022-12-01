using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {

            void getinfo(string message) => Console.WriteLine(message);
            List<Card> accounts = new List<Card>();

            Card masterCard = new()
            {
                RUB_Balance = 125005,
                PIN = 2142,
                CARDNUMBER = "2146060031890976",
                firstName = "Igor",
                secondName = "Zamuragin"
            };

            Console.WriteLine(masterCard.CardHolder);

            Bankomat bankomat = new Bankomat();
            bankomat.RegisterHandler(getinfo);
            bankomat.InsertCard(masterCard);

            Console.WriteLine(bankomat.TotalBalance);
            Console.WriteLine(masterCard.RUB_Balance);

            int x = bankomat.Withdraw(500);
            Console.WriteLine(bankomat.TotalBalance +"Баланс банкомата");

            Console.WriteLine();

        }
    }


   

    
}
