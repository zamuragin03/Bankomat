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

namespace Bankomat
{
    public partial class Form1 : Form
    {
        private List<Card> users;
        private Card card;


        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;
        private Bankomat bankomat;


        public Form1()
        {
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();

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

            if (card is not null)
            {
                getinfo($"Карта уже вставлена");
                return;
            }

            card = (Card) cardBox.SelectedItem;
            bankomat.InsertCard(card);
            getinfo($"Карта {card} вставлена");


        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                default:
                    passbox.Text += btn.Text;
                    break;
            }
        }
    }
}
