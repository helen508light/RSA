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
    public partial class Primes : Form
    {
        RSA rsa;
        BigInteger[] chipher;
        public Primes()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            int key = Convert.ToInt32(tBkey.Text);
            rsa = new RSA(key);
            tBp.Text=(rsa.p).ToString();
            tBq.Text=(rsa.q).ToString();
            tBe.Text=(rsa.e).ToString();
            tBd.Text=(rsa.d).ToString();
        }

        private void btnEncrept_Click(object sender, EventArgs e)
        {
             chipher = rsa.Encrypt(tBmessage.Text);
            for (int i = 0; i < chipher.Length; i++)
            {
                tBchipher.Text = tBchipher.Text + chipher[i].ToString();
                    }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string t = rsa.Decrypt(chipher);
            tBdecrypt.Text = t;
        }
    }
}
