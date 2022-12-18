using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bankomat
    {
        private Card currentcard;
        private StateOfCash Cash;

        private int TotalBalance;

        private List<int> Stock;
        private List<int> ListToDelete;
        int[] FaceValues = { 5000, 2000, 1000, 500, 200, 100 };

        public delegate void AccountHandler(string message);
        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;
        public Bankomat()
        {
            
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();
            
            Stock = new List<int>();
            Cash = new();

            GetData();
        }

        public string[] GetBankomatInfo()
        {
            string[] tmp =
            {
                Cash.amount_of_5000.ToString(),
                Cash.amount_of_2000.ToString(),
                Cash.amount_of_1000.ToString(),
                Cash.amount_of_500.ToString(),
                Cash.amount_of_200.ToString(),
                Cash.amount_of_100.ToString(),
                TotalBalance.ToString()
            };
            return tmp;
        }

        AccountHandler handler;
        public void RegisterHandler(AccountHandler del)
        {
            handler += del;
        }
        public void UnregisterHandler(AccountHandler del)
        {
            handler -= del;
        }


        public void InsertCard(Card card)
        {
            if (currentcard is not null)
            {
                handler?.Invoke("Ошибка: Нельзя вставить больше 1 карты");
                return;
            }
            currentcard = card;
        }
        public void RemoveCard()
        {
            currentcard = null;
        }

        public void Withdraw(int amount)
        {

            StateOfCash tempCash = new();


            if (amount <= currentcard.RUB_Balance & CheckBanknotesAviability(amount))
            {
                foreach (int val in ListToDelete)
                {
                    switch (val)
                    {
                        case 5000:
                            tempCash.amount_of_5000++;
                            break;
                        case 2000:
                            tempCash.amount_of_2000++;
                            break;
                        case 1000:
                            tempCash.amount_of_1000++;
                            break;
                        case 500:
                            tempCash.amount_of_500++;
                            break;
                        case 200:
                            tempCash.amount_of_200++;
                            break;
                        case 100:
                            tempCash.amount_of_100++;
                            break;
                    }
                }

                this.Cash.amount_of_5000 -= tempCash.amount_of_5000;
                this.Cash.amount_of_2000 -= tempCash.amount_of_2000;
                this.Cash.amount_of_1000 -= tempCash.amount_of_1000;
                this.Cash.amount_of_500 -= tempCash.amount_of_500;
                this.Cash.amount_of_200 -= tempCash.amount_of_200;
                this.Cash.amount_of_100 -= tempCash.amount_of_100;
                currentcard.ChangeBalance(-amount);

                UpdateStock();
                handler?.Invoke($"Выдано {amount}");
                return;
            }

            if (!CheckBanknotesAviability(amount))
            {
                handler?.Invoke("В банкомате нет таких денег(");

            }
            else
            {
                handler?.Invoke("Недостаточно средств(");
            }
        }
        public bool CheckPIN(int PIN)
        {
            return currentcard.PIN.Equals(PIN);
        }

        private bool CheckBanknotesAviability(int amount)
        {
            ListToDelete = new List<int>();
            int temp = amount % 5000 % 2000 % 1000 % 500 % 200 % 100;
            List<int> requiredBanknotes = new List<int>();

            bool flag1 = temp < 100 & temp > 0;
            if (flag1)
                return false;


            int i = 0;
            while (amount >= 1)
            {
                int currValue = FaceValues[i];
                if (currValue <= amount)
                {
                    requiredBanknotes.Add(currValue);
                    amount -= currValue;
                }
                else i++;
            }
            List<int> tempStock = Stock;
            foreach (var note in requiredBanknotes)
            {
                if (tempStock.Contains(note))
                {
                    tempStock.Remove(note);
                    ListToDelete.Add(note);
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        void UpdateStock()
        {
            command = new SQLiteCommand($"update Bankomat set amount_of_5000={Cash.amount_of_5000}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Bankomat set amount_of_2000={Cash.amount_of_2000}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Bankomat set amount_of_1000={Cash.amount_of_1000}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Bankomat set amount_of_500={Cash.amount_of_500}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Bankomat set amount_of_200={Cash.amount_of_200}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Bankomat set amount_of_100={Cash.amount_of_100}", db);
            command.ExecuteNonQuery();

            command = new SQLiteCommand($"select TotalBalance from Bankomat", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                TotalBalance = int.Parse(el["TotalBalance"].ToString());
            }
        }

        public void DepositMoney(StateOfCash state)
        {
            Cash.amount_of_5000 += state.amount_of_5000;
            Cash.amount_of_2000 += state.amount_of_2000;
            Cash.amount_of_1000 += state.amount_of_1000;
            Cash.amount_of_500 += state.amount_of_500;
            Cash.amount_of_200 += state.amount_of_200;
            Cash.amount_of_100 += state.amount_of_100;
            UpdateStock();
        }

        void GetData()
        {
            command = new SQLiteCommand($"select * from Bankomat", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                Cash.amount_of_5000 = int.Parse(el["amount_of_5000"].ToString());
                Cash.amount_of_2000 = int.Parse(el["amount_of_2000"].ToString());
                Cash.amount_of_1000 = int.Parse(el["amount_of_1000"].ToString());
                Cash.amount_of_500 = int.Parse(el["amount_of_500"].ToString());
                Cash.amount_of_200 = int.Parse(el["amount_of_200"].ToString());
                Cash.amount_of_100 = int.Parse(el["amount_of_100"].ToString());
                TotalBalance = int.Parse(el["TotalBalance"].ToString());
            }
            var items1 = Enumerable.Repeat(5000, Cash.amount_of_5000);
            var items2 = Enumerable.Repeat(2000, Cash.amount_of_2000);
            var items3 = Enumerable.Repeat(1000, Cash.amount_of_1000);
            var items4 = Enumerable.Repeat(500, Cash.amount_of_500);
            var items5 = Enumerable.Repeat(200, Cash.amount_of_200);
            var items6 = Enumerable.Repeat(100, Cash.amount_of_100);

            Stock.AddRange(items1);
            Stock.AddRange(items2);
            Stock.AddRange(items3);
            Stock.AddRange(items4);
            Stock.AddRange(items5);
            Stock.AddRange(items6);

            reader.Dispose();
            command.Dispose();
        }
    }
}
