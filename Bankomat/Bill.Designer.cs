
namespace Bankomat
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AmountLAbel = new System.Windows.Forms.Label();
            this.CardHolderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПАО СБЕРБАНК";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать!";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(12, 227);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(126, 25);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Дата: date";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLabel.Location = new System.Drawing.Point(12, 286);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(155, 25);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "Номер карты";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(125, 142);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(209, 33);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "тип операции";
            // 
            // AmountLAbel
            // 
            this.AmountLAbel.AutoSize = true;
            this.AmountLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLAbel.Location = new System.Drawing.Point(12, 330);
            this.AmountLAbel.Name = "AmountLAbel";
            this.AmountLAbel.Size = new System.Drawing.Size(99, 25);
            this.AmountLAbel.TabIndex = 5;
            this.AmountLAbel.Text = "Сумма: ";
            // 
            // CardHolderLabel
            // 
            this.CardHolderLabel.AutoSize = true;
            this.CardHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardHolderLabel.Location = new System.Drawing.Point(178, 196);
            this.CardHolderLabel.Name = "CardHolderLabel";
            this.CardHolderLabel.Size = new System.Drawing.Size(78, 25);
            this.CardHolderLabel.TabIndex = 6;
            this.CardHolderLabel.Text = "holder";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 364);
            this.Controls.Add(this.CardHolderLabel);
            this.Controls.Add(this.AmountLAbel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label AmountLAbel;
        private System.Windows.Forms.Label CardHolderLabel;
    }
}