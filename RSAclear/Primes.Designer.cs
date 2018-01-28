namespace RSAclear
{
    partial class Primes
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
            this.button1 = new System.Windows.Forms.Button();
            this.tBp = new System.Windows.Forms.TextBox();
            this.tBq = new System.Windows.Forms.TextBox();
            this.tBd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBe = new System.Windows.Forms.TextBox();
            this.tBkey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBmessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBchipher = new System.Windows.Forms.TextBox();
            this.btnEncrept = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tBdecrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Получить простые числа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBp
            // 
            this.tBp.Location = new System.Drawing.Point(289, 12);
            this.tBp.Name = "tBp";
            this.tBp.Size = new System.Drawing.Size(261, 20);
            this.tBp.TabIndex = 1;
            // 
            // tBq
            // 
            this.tBq.Location = new System.Drawing.Point(289, 38);
            this.tBq.Name = "tBq";
            this.tBq.Size = new System.Drawing.Size(261, 20);
            this.tBq.TabIndex = 2;
            // 
            // tBd
            // 
            this.tBd.Location = new System.Drawing.Point(289, 65);
            this.tBd.Name = "tBd";
            this.tBd.Size = new System.Drawing.Size(261, 20);
            this.tBd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "e";
            // 
            // tBe
            // 
            this.tBe.Location = new System.Drawing.Point(289, 96);
            this.tBe.Name = "tBe";
            this.tBe.Size = new System.Drawing.Size(261, 20);
            this.tBe.TabIndex = 8;
            // 
            // tBkey
            // 
            this.tBkey.Location = new System.Drawing.Point(124, 65);
            this.tBkey.Name = "tBkey";
            this.tBkey.Size = new System.Drawing.Size(100, 20);
            this.tBkey.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "длина ключа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Исходное сообщение";
            // 
            // tBmessage
            // 
            this.tBmessage.Location = new System.Drawing.Point(41, 144);
            this.tBmessage.Multiline = true;
            this.tBmessage.Name = "tBmessage";
            this.tBmessage.Size = new System.Drawing.Size(497, 74);
            this.tBmessage.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Зашифрованное";
            // 
            // tBchipher
            // 
            this.tBchipher.Location = new System.Drawing.Point(41, 259);
            this.tBchipher.Multiline = true;
            this.tBchipher.Name = "tBchipher";
            this.tBchipher.Size = new System.Drawing.Size(497, 93);
            this.tBchipher.TabIndex = 14;
            // 
            // btnEncrept
            // 
            this.btnEncrept.Location = new System.Drawing.Point(611, 173);
            this.btnEncrept.Name = "btnEncrept";
            this.btnEncrept.Size = new System.Drawing.Size(106, 23);
            this.btnEncrept.TabIndex = 15;
            this.btnEncrept.Text = "Шифровать";
            this.btnEncrept.UseVisualStyleBackColor = true;
            this.btnEncrept.Click += new System.EventHandler(this.btnEncrept_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(611, 312);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(106, 23);
            this.btnDecrypt.TabIndex = 16;
            this.btnDecrypt.Text = "Дешифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Расшифрованное";
            // 
            // tBdecrypt
            // 
            this.tBdecrypt.Location = new System.Drawing.Point(41, 393);
            this.tBdecrypt.Multiline = true;
            this.tBdecrypt.Name = "tBdecrypt";
            this.tBdecrypt.Size = new System.Drawing.Size(497, 81);
            this.tBdecrypt.TabIndex = 18;
            // 
            // Primes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 537);
            this.Controls.Add(this.tBdecrypt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrept);
            this.Controls.Add(this.tBchipher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBmessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBkey);
            this.Controls.Add(this.tBe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBd);
            this.Controls.Add(this.tBq);
            this.Controls.Add(this.tBp);
            this.Controls.Add(this.button1);
            this.Name = "Primes";
            this.Text = "Primes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBp;
        private System.Windows.Forms.TextBox tBq;
        private System.Windows.Forms.TextBox tBd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBe;
        private System.Windows.Forms.TextBox tBkey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBmessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBchipher;
        private System.Windows.Forms.Button btnEncrept;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBdecrypt;
    }
}