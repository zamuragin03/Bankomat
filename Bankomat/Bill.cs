using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Bill : Form
    {
        public Bill(OperationType type,int amount,string CardNumber, string CaldHolder)
        {
            InitializeComponent();

            TypeLabel.Text = type.ToString();
            AmountLAbel.Text = "Сумма: " + amount;
            CardHolderLabel.Text = CaldHolder;
            NumberLabel.Text = "Номер карты: " + CardNumber;
            DateLabel.Text ="Дата"+  DateTime.Now.ToShortDateString();
        }
    }
}
