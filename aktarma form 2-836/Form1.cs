using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aktarma_form_2_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            double sonuc = 0;


            if (rb1.Checked)
            {
                sonuc = 200 - 15;
            }
            else if (rb2.Checked)
            {
                sonuc = 185 - 12.20;
            }
            else if (rb3.Checked)
            {
                sonuc = 178.8 - 8;
            }

            else if (rb4.Checked)
            {
                sonuc = 170.8 - 9.60;
            }


            lblMiktar.Text = sonuc.ToString();
        }
    }
}
