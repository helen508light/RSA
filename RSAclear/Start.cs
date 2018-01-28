using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAclear
{
    public partial class Start : Form
    {
        public static Evklid evkl;
        public Start()
        {
            InitializeComponent();
        }

        private void btnRsa_Click(object sender, EventArgs e)
        {
            Start.ActiveForm.Visible = false;
            Primes dlg = new Primes();
            dlg.ShowDialog();
        }

        private void btnModExp_Click(object sender, EventArgs e)
        {
            Start.ActiveForm.Visible = false;
          ModExp   dlg = new ModExp();
            dlg.ShowDialog();
        
        }

        private void btnEvkl_Click(object sender, EventArgs e)
        {
            Start.ActiveForm.Visible = false;
          evkl = new Evklid();
            evkl.ShowDialog();
        }

        private void btnMiller_Click(object sender, EventArgs e)
        {
            Start.ActiveForm.Visible = false;
            MillerRabin dlg = new MillerRabin();
            dlg.ShowDialog();
        }
    }
}
