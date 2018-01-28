namespace RSAclear
{
    partial class Start
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
            this.btnRsa = new System.Windows.Forms.Button();
            this.btnEvkl = new System.Windows.Forms.Button();
            this.btnModExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMiller
            // 
            this.btnMiller.Location = new System.Drawing.Point(56, 83);
            this.btnMiller.Name = "btnMiller";
            this.btnMiller.Size = new System.Drawing.Size(184, 23);
            this.btnMiller.TabIndex = 0;
            this.btnMiller.Text = "Проверка простоты";
            this.btnMiller.UseVisualStyleBackColor = true;
            this.btnMiller.Click += new System.EventHandler(this.btnMiller_Click);
            // 
            // btnRsa
            // 
            this.btnRsa.Location = new System.Drawing.Point(273, 83);
            this.btnRsa.Name = "btnRsa";
            this.btnRsa.Size = new System.Drawing.Size(204, 23);
            this.btnRsa.TabIndex = 1;
            this.btnRsa.Text = "RSA";
            this.btnRsa.UseVisualStyleBackColor = true;
            this.btnRsa.Click += new System.EventHandler(this.btnRsa_Click);
            // 
            // btnEvkl
            // 
            this.btnEvkl.Location = new System.Drawing.Point(56, 143);
            this.btnEvkl.Name = "btnEvkl";
            this.btnEvkl.Size = new System.Drawing.Size(184, 23);
            this.btnEvkl.TabIndex = 2;
            this.btnEvkl.Text = "Расширенный евклид";
            this.btnEvkl.UseVisualStyleBackColor = true;
            this.btnEvkl.Click += new System.EventHandler(this.btnEvkl_Click);
            // 
            // btnModExp
            // 
            this.btnModExp.Location = new System.Drawing.Point(273, 143);
            this.btnModExp.Name = "btnModExp";
            this.btnModExp.Size = new System.Drawing.Size(204, 23);
            this.btnModExp.TabIndex = 3;
            this.btnModExp.Text = "Возведение в степень";
            this.btnModExp.UseVisualStyleBackColor = true;
            this.btnModExp.Click += new System.EventHandler(this.btnModExp_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 262);
            this.Controls.Add(this.btnModExp);
            this.Controls.Add(this.btnEvkl);
            this.Controls.Add(this.btnRsa);
            this.Controls.Add(this.btnMiller);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMiller;
        private System.Windows.Forms.Button btnRsa;
        private System.Windows.Forms.Button btnEvkl;
        private System.Windows.Forms.Button btnModExp;
    }
}