
namespace Bankomat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.WhatToDoLabel = new System.Windows.Forms.Label();
            this.SBERLAbel = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Deposit_button = new System.Windows.Forms.Button();
            this.Withdraw_button = new System.Windows.Forms.Button();
            this.insertcard = new System.Windows.Forms.Button();
            this.cardBox = new System.Windows.Forms.ComboBox();
            this.CardList = new System.Windows.Forms.ListView();
            this.RUB_Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CARDNUMBER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BankomatView = new System.Windows.Forms.ListView();
            this.amount_of_5000 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_of_2000 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_of_1000 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_of_500 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_of_200 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_of_100 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Infolabel = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.depositedLabel = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.depositPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.BalanceLabel);
            this.panel1.Controls.Add(this.WhatToDoLabel);
            this.panel1.Controls.Add(this.SBERLAbel);
            this.panel1.Controls.Add(this.passbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Deposit_button);
            this.panel1.Controls.Add(this.Withdraw_button);
            this.panel1.Location = new System.Drawing.Point(204, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 412);
            this.panel1.TabIndex = 1;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(299, 176);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 49);
            this.button14.TabIndex = 7;
            this.button14.Text = "Завершить сеанс";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceLabel.Location = new System.Drawing.Point(88, 104);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(99, 20);
            this.BalanceLabel.TabIndex = 6;
            this.BalanceLabel.Text = "__________";
            // 
            // WhatToDoLabel
            // 
            this.WhatToDoLabel.AutoSize = true;
            this.WhatToDoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WhatToDoLabel.Font = new System.Drawing.Font("Adobe Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatToDoLabel.Location = new System.Drawing.Point(0, 26);
            this.WhatToDoLabel.Name = "WhatToDoLabel";
            this.WhatToDoLabel.Size = new System.Drawing.Size(0, 26);
            this.WhatToDoLabel.TabIndex = 5;
            this.WhatToDoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SBERLAbel
            // 
            this.SBERLAbel.AutoSize = true;
            this.SBERLAbel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SBERLAbel.Font = new System.Drawing.Font("Adobe Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBERLAbel.Location = new System.Drawing.Point(0, 0);
            this.SBERLAbel.Name = "SBERLAbel";
            this.SBERLAbel.Size = new System.Drawing.Size(114, 26);
            this.SBERLAbel.TabIndex = 4;
            this.SBERLAbel.Text = "СБЕРБАНК";
            this.SBERLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passbox
            // 
            this.passbox.AutoSize = true;
            this.passbox.BackColor = System.Drawing.Color.LightCyan;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbox.Location = new System.Drawing.Point(123, 211);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(0, 25);
            this.passbox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(47, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 167);
            this.panel2.TabIndex = 2;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(166, 110);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 45);
            this.button13.TabIndex = 12;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightGreen;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(225, 110);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 45);
            this.button12.TabIndex = 11;
            this.button12.Text = "ENTER";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Khaki;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(166, 59);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(141, 45);
            this.button11.TabIndex = 10;
            this.button11.Text = "<—";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(166, 8);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "CLEAR";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(115, 110);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(115, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(115, 8);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 6;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(64, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(64, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(64, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 3;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(13, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(13, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.digitbuttons);
            // 
            // Deposit_button
            // 
            this.Deposit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit_button.Location = new System.Drawing.Point(3, 59);
            this.Deposit_button.Name = "Deposit_button";
            this.Deposit_button.Size = new System.Drawing.Size(89, 39);
            this.Deposit_button.TabIndex = 1;
            this.Deposit_button.Text = "Внести";
            this.Deposit_button.UseVisualStyleBackColor = true;
            this.Deposit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Withdraw_button
            // 
            this.Withdraw_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Withdraw_button.Location = new System.Drawing.Point(299, 59);
            this.Withdraw_button.Name = "Withdraw_button";
            this.Withdraw_button.Size = new System.Drawing.Size(89, 40);
            this.Withdraw_button.TabIndex = 0;
            this.Withdraw_button.Text = "Снять";
            this.Withdraw_button.UseVisualStyleBackColor = true;
            this.Withdraw_button.Click += new System.EventHandler(this.Withdraw_button_Click);
            // 
            // insertcard
            // 
            this.insertcard.AutoSize = true;
            this.insertcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertcard.Location = new System.Drawing.Point(204, 433);
            this.insertcard.Name = "insertcard";
            this.insertcard.Size = new System.Drawing.Size(124, 28);
            this.insertcard.TabIndex = 2;
            this.insertcard.Text = "Вставить карту";
            this.insertcard.UseVisualStyleBackColor = true;
            this.insertcard.Click += new System.EventHandler(this.insertcard_Click);
            // 
            // cardBox
            // 
            this.cardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardBox.FormattingEnabled = true;
            this.cardBox.Location = new System.Drawing.Point(332, 435);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(260, 26);
            this.cardBox.TabIndex = 3;
            // 
            // CardList
            // 
            this.CardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RUB_Balance,
            this.PIN,
            this.CARDNUMBER,
            this.firstName,
            this.secondName});
            this.CardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardList.HideSelection = false;
            this.CardList.Location = new System.Drawing.Point(601, 12);
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(453, 117);
            this.CardList.TabIndex = 4;
            this.CardList.Tag = "";
            this.CardList.UseCompatibleStateImageBehavior = false;
            this.CardList.View = System.Windows.Forms.View.Details;
            // 
            // RUB_Balance
            // 
            this.RUB_Balance.Tag = "";
            this.RUB_Balance.Text = "Balance";
            this.RUB_Balance.Width = 100;
            // 
            // PIN
            // 
            this.PIN.Tag = "";
            this.PIN.Text = "PIN";
            // 
            // CARDNUMBER
            // 
            this.CARDNUMBER.Tag = "";
            this.CARDNUMBER.Text = "#";
            this.CARDNUMBER.Width = 120;
            // 
            // firstName
            // 
            this.firstName.Tag = "";
            this.firstName.Text = "FirstName";
            this.firstName.Width = 84;
            // 
            // secondName
            // 
            this.secondName.Tag = "";
            this.secondName.Text = "SecondName";
            this.secondName.Width = 105;
            // 
            // BankomatView
            // 
            this.BankomatView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.amount_of_5000,
            this.amount_of_2000,
            this.amount_of_1000,
            this.amount_of_500,
            this.amount_of_200,
            this.amount_of_100,
            this.TotalBalance});
            this.BankomatView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankomatView.HideSelection = false;
            this.BankomatView.Location = new System.Drawing.Point(603, 183);
            this.BankomatView.Name = "BankomatView";
            this.BankomatView.Size = new System.Drawing.Size(453, 55);
            this.BankomatView.TabIndex = 5;
            this.BankomatView.Tag = "";
            this.BankomatView.UseCompatibleStateImageBehavior = false;
            this.BankomatView.View = System.Windows.Forms.View.Details;
            // 
            // amount_of_5000
            // 
            this.amount_of_5000.Text = "5000";
            // 
            // amount_of_2000
            // 
            this.amount_of_2000.Text = "2000";
            // 
            // amount_of_1000
            // 
            this.amount_of_1000.Text = "1000";
            // 
            // amount_of_500
            // 
            this.amount_of_500.Text = "500";
            // 
            // amount_of_200
            // 
            this.amount_of_200.Text = "200";
            // 
            // amount_of_100
            // 
            this.amount_of_100.Text = "100";
            // 
            // TotalBalance
            // 
            this.TotalBalance.Text = "TB";
            // 
            // Infolabel
            // 
            this.Infolabel.Location = new System.Drawing.Point(13, 12);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(185, 545);
            this.Infolabel.TabIndex = 6;
            this.Infolabel.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(603, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Состояние банкомата";
            // 
            // depositPanel
            // 
            this.depositPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.depositPanel.Controls.Add(this.button21);
            this.depositPanel.Controls.Add(this.button18);
            this.depositPanel.Controls.Add(this.button19);
            this.depositPanel.Controls.Add(this.button20);
            this.depositPanel.Controls.Add(this.button17);
            this.depositPanel.Controls.Add(this.button16);
            this.depositPanel.Controls.Add(this.button15);
            this.depositPanel.Location = new System.Drawing.Point(604, 301);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(452, 126);
            this.depositPanel.TabIndex = 8;
            this.depositPanel.Visible = false;
            // 
            // button21
            // 
            this.button21.AutoSize = true;
            this.button21.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(134, 63);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(190, 38);
            this.button21.TabIndex = 6;
            this.button21.Text = "Внести сумму";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.AddSumm);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(399, 7);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 23);
            this.button18.TabIndex = 5;
            this.button18.Text = "100";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.AddSumm);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(327, 7);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 23);
            this.button19.TabIndex = 4;
            this.button19.Text = "200";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.AddSumm);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(246, 7);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 23);
            this.button20.TabIndex = 3;
            this.button20.Text = "500";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.AddSumm);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(165, 7);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 23);
            this.button17.TabIndex = 2;
            this.button17.Text = "1000";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.AddSumm);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(84, 7);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "2000";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.AddSumm);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(3, 7);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 23);
            this.button15.TabIndex = 0;
            this.button15.Text = "5000";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.AddSumm);
            // 
            // depositedLabel
            // 
            this.depositedLabel.AutoSize = true;
            this.depositedLabel.Location = new System.Drawing.Point(702, 273);
            this.depositedLabel.Name = "depositedLabel";
            this.depositedLabel.Size = new System.Drawing.Size(56, 13);
            this.depositedLabel.TabIndex = 9;
            this.depositedLabel.Text = "Внесено: ";
            // 
            // button22
            // 
            this.button22.AutoSize = true;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(797, 143);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(131, 34);
            this.button22.TabIndex = 10;
            this.button22.Text = "Посмотреть";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 569);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.depositedLabel);
            this.Controls.Add(this.depositPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.BankomatView);
            this.Controls.Add(this.CardList);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.insertcard);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button insertcard;
        private System.Windows.Forms.ComboBox cardBox;
        private System.Windows.Forms.ListView CardList;
        private System.Windows.Forms.ColumnHeader RUB_Balance;
        private System.Windows.Forms.ColumnHeader PIN;
        private System.Windows.Forms.ColumnHeader CARDNUMBER;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader secondName;
        private System.Windows.Forms.ListView BankomatView;
        private System.Windows.Forms.ColumnHeader amount_of_5000;
        private System.Windows.Forms.ColumnHeader amount_of_2000;
        private System.Windows.Forms.ColumnHeader amount_of_1000;
        private System.Windows.Forms.ColumnHeader amount_of_500;
        private System.Windows.Forms.ColumnHeader amount_of_200;
        private System.Windows.Forms.ColumnHeader amount_of_100;
        private System.Windows.Forms.ColumnHeader TotalBalance;
        private System.Windows.Forms.Button Deposit_button;
        private System.Windows.Forms.Button Withdraw_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label passbox;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label SBERLAbel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WhatToDoLabel;
        private System.Windows.Forms.Label BalanceLabel;
        public System.Windows.Forms.RichTextBox Infolabel;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label depositedLabel;
        private System.Windows.Forms.Button button22;
    }
}

