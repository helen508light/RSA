namespace RSAclear
{
    partial class ModExp
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tBDegree = new System.Windows.Forms.TextBox();
            this.tBResultModExp = new System.Windows.Forms.TextBox();
            this.btnExppppppp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBModul = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Степень";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(176, 57);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(195, 20);
            this.tbNumber.TabIndex = 2;
            // 
            // tBDegree
            // 
            this.tBDegree.Location = new System.Drawing.Point(176, 93);
            this.tBDegree.Name = "tBDegree";
            this.tBDegree.Size = new System.Drawing.Size(195, 20);
            this.tBDegree.TabIndex = 3;
            // 
            // tBResultModExp
            // 
            this.tBResultModExp.Location = new System.Drawing.Point(12, 185);
            this.tBResultModExp.Name = "tBResultModExp";
            this.tBResultModExp.Size = new System.Drawing.Size(426, 20);
            this.tBResultModExp.TabIndex = 4;
            // 
            // btnExppppppp
            // 
            this.btnExppppppp.Location = new System.Drawing.Point(186, 156);
            this.btnExppppppp.Name = "btnExppppppp";
            this.btnExppppppp.Size = new System.Drawing.Size(75, 23);
            this.btnExppppppp.TabIndex = 5;
            this.btnExppppppp.Text = "Возвести!";
            this.btnExppppppp.UseVisualStyleBackColor = true;
            this.btnExppppppp.Click += new System.EventHandler(this.btnExppppppp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Модуль";
            // 
            // tBModul
            // 
            this.tBModul.Location = new System.Drawing.Point(176, 123);
            this.tBModul.Name = "tBModul";
            this.tBModul.Size = new System.Drawing.Size(195, 20);
            this.tBModul.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBModul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExppppppp);
            this.Controls.Add(this.tBResultModExp);
            this.Controls.Add(this.tBDegree);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModExp";
            this.Text = "ModExp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tBDegree;
        private System.Windows.Forms.TextBox tBResultModExp;
        private System.Windows.Forms.Button btnExppppppp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBModul;
        private System.Windows.Forms.Button button1;
    }
}