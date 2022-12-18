using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class StatForm : Form
    {
        private Bankomat DB;
        public StatForm(Bankomat DB)
        {
            InitializeComponent();
            this.DB = DB;

            var info = DB.GetBankomatInfo();
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("5000", int.Parse(info[0]));
            chart1.Series["s1"].Points.AddXY("2000", int.Parse(info[1]));
            chart1.Series["s1"].Points.AddXY("1000", int.Parse(info[2]));
            chart1.Series["s1"].Points.AddXY("500", int.Parse(info[3]));
            chart1.Series["s1"].Points.AddXY("200", int.Parse(info[4]));
            chart1.Series["s1"].Points.AddXY("100", int.Parse(info[5]));
            chart1.Titles.Add("Balance:"+  info[6]+ "RUB");



        }
    }
}
