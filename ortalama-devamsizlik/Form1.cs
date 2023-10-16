using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_devamsizlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float ortalama, devamsizlik;
            ortalama = Convert.ToSingle(txtOrtalama.Text);
            devamsizlik = Convert.ToSingle(txtDevamsizlik.Text);

            if (ortalama >= 50 && devamsizlik < 10)
            {
                lblSonuc.Text = "Durum : Geçti ";
            }
            else
            {
                lblSonuc.Text = "Durum : Kaldı";

            }

            
        }
    }
}
