using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSAclear
{
    public partial class ModExp : Form
    {
        public ModExp()
        {
            InitializeComponent();
        }

        private void btnExppppppp_Click(object sender, EventArgs e)
        {
            BigInteger number;
            BigInteger degree;
            BigInteger modul;
            BigInteger.TryParse(tbNumber.Text,out number);
            BigInteger.TryParse(tBDegree.Text, out degree);
            BigInteger.TryParse(tBModul.Text, out modul);
            tBResultModExp.Text = (Operations.modExp(number,degree,modul)).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           ModExp.ActiveForm.Close();
            ModExp.ActiveForm.Visible = false;
           Start dlg = new Start();
            dlg.ShowDialog();
        }
    }
}
