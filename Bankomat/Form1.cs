using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bankomat
{
    enum State
    {
        LoginSucces,
        TypingSum,
        Unstated,
    }
    public partial class Form1 : Form
    {
        private List<Card> users;
        private Card card;

        private State state;
        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;
        private Bankomat bankomat;


        private int depositedSum;
        private StateOfCash c1;

        public Form1()
        {
      
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();
            state = State.Unstated;
            InitializeComponent();

            users = new List<Card>();
            bankomat = new Bankomat();
            bankomat.RegisterHandler(getinfo);


            FillCardBox();
            FillCardList();
            FillBankomatView();

        }

        void getinfo(string message)
        {
            Infolabel.Text += message + "\n";
        }


        void FillCardList()
        {
            CardList.Items.Clear();
            command = new SQLiteCommand($"select * from Card", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                var temp = new Card()
                {
                    RUB_Balance = int.Parse(el["RUB_Balance"].ToString()),
                    PIN = int.Parse(el["PIN"].ToString()),
                    CARDNUMBER = el["CARDNUMBER"].ToString(),
                    firstName = el["firstName"].ToString(),
                    secondName = el["secondName"].ToString()
                };
                string[] row =
                {
                    temp.RUB_Balance.ToString(), temp.PIN.ToString(), temp.CARDNUMBER, temp.firstName, temp.secondName
                };

                var item = new ListViewItem(row);
                CardList.Items.Add(item);

            }
        }

        void FillCardBox()
        {
            cardBox.Items.Clear();
            command = new SQLiteCommand($"select * from Card", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                cardBox.Items.Add(new Card()
                {
                    RUB_Balance = int.Parse(el["RUB_Balance"].ToString()),
                    PIN = int.Parse(el["PIN"].ToString()),
                    CARDNUMBER = el["CARDNUMBER"].ToString(),
                    firstName = el["firstName"].ToString(),
                    secondName = el["secondName"].ToString()
                });

            }
        }

        void FillBankomatView()
        {
            BankomatView.Items.Clear();
            var item = new ListViewItem(bankomat.GetBankomatInfo());
            BankomatView.Items.Add(item);
        }

        private void insertcard_Click(object sender, EventArgs e)
        {
            if (cardBox.SelectedItem is null)
            {
                getinfo($"Карта не выбрана");
                return;
            }

            if (card is null)
            {
                card = (Card)cardBox.SelectedItem;
                bankomat.InsertCard(card);
                getinfo($"Карта {card} вставлена");
                WhatToDoLabel.Text = "Введите пароль";
                return;
            }
            getinfo($"Карта уже вставлена");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == State.LoginSucces)
            {
                c1 = new();
                depositPanel.Visible = true;
                WhatToDoLabel.Text = "Внесите деньги";
                state = State.TypingSum;
            }
        }

        private void digitbuttons(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "CLEAR":
                    passbox.Text = "";
                    break;
                case "<—":
                    try
                    {
                        passbox.Text = passbox.Text.Remove(passbox.Text.Length - 1);
                    }
                    catch (Exception exception)
                    {
                        getinfo("Нечего удалять");
                    }
                    break;
                case "ENTER":
                    if (passbox.Text == "")
                    {
                        getinfo("Ничего не введено");
                        break;
                    }
                    if (state==State.TypingSum)
                    {
                        
                        WithDrawAction(int.Parse(passbox.Text));
                        break;
                    }

                    if (card is null)
                    {
                        getinfo("Вставьте карту");
                        break;
                    }
                    
                    if (bankomat.CheckPIN(int.Parse(passbox.Text) ))
                    {
                        AccessAllow();
                        break;
                    }
                    getinfo("PIN-код Неверный");
                    break;
                default:
                    passbox.Text += btn.Text;
                    break;
            }
        }

        private void AccessAllow()
        {
            state = State.LoginSucces;
            getinfo("Успешный вход");
            passbox.Text = "";
            WhatToDoLabel.Text = "Выберите действие:";
            SBERLAbel.Text = "Здравствуйте, " + card.CardHolder;
            BalanceLabel.Text = card.RUB_Balance+"RUB";
        }

        private void Withdraw_button_Click(object sender, EventArgs e)
        {
            if (state==State.LoginSucces)
            {
                WhatToDoLabel.Text = "Введите сумму для снятия";
                state = State.TypingSum;
            }
        }

        void WithDrawAction(int amount)
        {
            bankomat.Withdraw(amount);
            FillBankomatView();
            FillCardList();
            passbox.Text = "";
            BalanceLabel.Text = card.RUB_Balance + "RUB";
            WhatToDoLabel.Text = "Выберите действие:";
            SBERLAbel.Text = "Здравствуйте, " + card.CardHolder;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (card is not null)
            {
                bankomat.RemoveCard();
                getinfo("Спасибо за визит");
                state = State.Unstated;
                passbox.Text = "";
                WhatToDoLabel.Text = "Выберите действие:";
                SBERLAbel.Text = "Здравствуйте! ";
                BalanceLabel.Text = "";
                card = null;
            }
            
        }
        

        private void AddSumm(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            string temp = btn.Text;
            switch (temp)
            {
                case "5000":
                    depositedSum += 5000;
                    c1.amount_of_5000++;
                    break;
                case "2000":
                    depositedSum += 2000;
                    c1.amount_of_2000++;
                    break;
                case "1000":
                    depositedSum += 1000;
                    c1.amount_of_1000++;
                    break;
                case "500":
                    depositedSum += 500;
                    c1.amount_of_500++;
                    break;
                case "200":
                    depositedSum += 200;
                    c1.amount_of_200++;
                    break;
                case "100":
                    depositedSum += 100;
                    c1.amount_of_100++;
                    break;
                default:
                    card.ChangeBalance(depositedSum);
                    bankomat.DepositMoney(c1);
                    FillBankomatView();
                    FillCardList();
                    BalanceLabel.Text = card.RUB_Balance + "RUB";
                    state = State.LoginSucces;
                    depositPanel.Visible = false;
                    WhatToDoLabel.Text = "Выберите действие:";
                    SBERLAbel.Text = "Здравствуйте! ";
                    depositedLabel.Text = "";

                    break;

            }

            depositedLabel.Text = "Внесено: " + depositedSum;
            getinfo("Добавлено "+btn.Text);
        }
    }
}
