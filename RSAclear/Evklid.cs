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
    public partial class Evklid : Form
    {
        public Evklid()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            BigInteger a;
            BigInteger b;
            BigInteger azaza ;
            BigInteger v = 1;
            BigInteger u = 1;
           
            BigInteger.TryParse(tbA.Text, out a);
            BigInteger.TryParse(tbB.Text, out b);
            Operations.EGCD(a,b,ref u,ref v);      
            if (a > b)
            {
                Operations.Print1(a,b,v,u);
            }
            else
            {
                Operations.Print2(a,b,v,u);
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           Evklid.ActiveForm.Close();
            Evklid.ActiveForm.Visible = false;
            Start dlg = new Start();
            dlg.ShowDialog();
        }
    }
}
