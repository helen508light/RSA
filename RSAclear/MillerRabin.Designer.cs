namespace RSAclear
{
    partial class MillerRabin
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
            this.btnMiller = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNumber = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.tBResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMiller
            // 
            this.btnMiller.Location = new System.Drawing.Point(180, 86);
            this.btnMiller.Name = "btnMiller";
            this.btnMiller.Size = new System.Drawing.Size(75, 23);
            this.btnMiller.TabIndex = 0;
            this.btnMiller.Text = "Проверить!";
            this.btnMiller.UseVisualStyleBackColor = true;
            this.btnMiller.Click += new System.EventHandler(this.btnMiller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число, которое надо проверить";
            // 
            // tBNumber
            // 
            this.tBNumber.Location = new System.Drawing.Point(294, 89);
            this.tBNumber.Name = "tBNumber";
            this.tBNumber.Size = new System.Drawing.Size(166, 20);
            this.tBNumber.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(455, 216);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Назад";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tBResult
            // 
            this.tBResult.Location = new System.Drawing.Point(294, 149);
            this.tBResult.Name = "tBResult";
            this.tBResult.Size = new System.Drawing.Size(166, 20);
            this.tBResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результат";
            // 
            // MillerRabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBResult);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.tBNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMiller);
            this.Name = "MillerRabin";
            this.Text = "MillerRabin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMiller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNumber;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox tBResult;
        private System.Windows.Forms.Label label2;
    }
}