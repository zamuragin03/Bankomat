using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Card
    {
        public int RUB_Balance { get; set; }
        public int PIN { get; set; }
        public string CARDNUMBER { get; set; }

        public string firstName;
        public string secondName;
        public string CardHolder => firstName.ToUpper() + " " + secondName.ToUpper();

        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;
        public Card()
        {
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();
        }
        public void ChangeBalance(int amount)
        {
            RUB_Balance += amount;
            UpdateCardBalance();
        }

        void UpdateCardBalance()
        {
            command = new SQLiteCommand($"update Card set RUB_Balance={RUB_Balance} " +
                                        $"where CARDNUMBER='{CARDNUMBER}'", db);
            command.ExecuteNonQuery();
        }

        public override string ToString()
        {
            return CARDNUMBER + " " + PIN;
        }
    }
}
