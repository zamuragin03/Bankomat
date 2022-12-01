
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.passbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Deposit_button);
            this.panel1.Controls.Add(this.Withdraw_button);
            this.panel1.Location = new System.Drawing.Point(203, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 412);
            this.panel1.TabIndex = 1;
            // 
            // Deposit_button
            // 
            this.Deposit_button.Location = new System.Drawing.Point(297, 35);
            this.Deposit_button.Name = "Deposit_button";
            this.Deposit_button.Size = new System.Drawing.Size(75, 23);
            this.Deposit_button.TabIndex = 1;
            this.Deposit_button.Text = "Внести";
            this.Deposit_button.UseVisualStyleBackColor = true;
            this.Deposit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Withdraw_button
            // 
            this.Withdraw_button.Location = new System.Drawing.Point(29, 35);
            this.Withdraw_button.Name = "Withdraw_button";
            this.Withdraw_button.Size = new System.Drawing.Size(75, 23);
            this.Withdraw_button.TabIndex = 0;
            this.Withdraw_button.Text = "Снять";
            this.Withdraw_button.UseVisualStyleBackColor = true;
            // 
            // insertcard
            // 
            this.insertcard.Location = new System.Drawing.Point(203, 454);
            this.insertcard.Name = "insertcard";
            this.insertcard.Size = new System.Drawing.Size(102, 27);
            this.insertcard.TabIndex = 2;
            this.insertcard.Text = "Вставить карту";
            this.insertcard.UseVisualStyleBackColor = true;
            this.insertcard.Click += new System.EventHandler(this.insertcard_Click);
            // 
            // cardBox
            // 
            this.cardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardBox.FormattingEnabled = true;
            this.cardBox.Location = new System.Drawing.Point(331, 459);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(263, 26);
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
            this.CardList.Location = new System.Drawing.Point(600, 36);
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
            this.BankomatView.Location = new System.Drawing.Point(600, 159);
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
            this.Infolabel.Location = new System.Drawing.Point(615, 248);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(438, 298);
            this.Infolabel.TabIndex = 6;
            this.Infolabel.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
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
            this.panel2.Location = new System.Drawing.Point(105, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 167);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(13, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(13, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(64, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 3;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(115, 8);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 6;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(166, 8);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "CLEAR";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(166, 59);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 45);
            this.button11.TabIndex = 10;
            this.button11.Text = "<—";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.digitbuttons);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(166, 110);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 45);
            this.button12.TabIndex = 11;
            this.button12.Text = "000";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.digitbuttons);
            // 
            // passbox
            // 
            this.passbox.AutoSize = true;
            this.passbox.BackColor = System.Drawing.Color.LightCyan;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbox.Location = new System.Drawing.Point(181, 35);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(0, 25);
            this.passbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 558);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.BankomatView);
            this.Controls.Add(this.CardList);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.insertcard);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.RichTextBox Infolabel;
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
    }
}

