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
    public partial class MillerRabin : Form
    {
        public MillerRabin()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MillerRabin.ActiveForm.Close();
           MillerRabin.ActiveForm.Visible = false;
            Start dlg = new Start();
            dlg.ShowDialog();
        }

        private void btnMiller_Click(object sender, EventArgs e)
        {
            BigInteger number;
            BigInteger.TryParse(tBNumber.Text, out number);
            int a = (int)BigInteger.Log(number,2);
            if (Operations.MillerRabinTest(number,a))
            {
                tBResult.Text = "Число простое";
            }
            else {
                tBResult.Text = "Число непростое";
            }
        }
    }
}
