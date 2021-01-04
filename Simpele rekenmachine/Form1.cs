using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simpele_rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double getal1;
            if (double.TryParse(tbGetal1.Text, out getal1))
            {}
            else
            {
                MessageBox.Show("Getal 1: vul een cijfer in", "Foutmelding");
            }

            double getal2;
            if (double.TryParse(tbGetal2.Text, out getal2))
            {
                if (rbOptellen.Checked)
                {
                    double getalUitkomst = getal1 + getal2;
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = getal1.ToString() + " + " + getal2.ToString() + " = " + getalUitkomst.ToString();
                }
                if (rbAftrekken.Checked)
                {
                    double getalUitkomst = getal1 - getal2;
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = getal1.ToString() + " - " + getal2.ToString() + " = " + getalUitkomst.ToString();
                }
                if (rbVermenigvuldigen.Checked)
                {
                    double getalUitkomst = getal1 * getal2;
                    tbUitkomst.Text = getalUitkomst.ToString();
                    tbSom.Text = getal1.ToString() + " x " + getal2.ToString() + " = " + getalUitkomst.ToString();
                }
                if (rbDelen.Checked)
                {
                    
                }
                if (rbKwadraad.Checked)
                {

                }
                if (rbWortel.Checked)
                {

                }
            }
            else
            {
                MessageBox.Show("Getal 2: vul een cijfer in", "Foutmelding");
            }
            //if (rbOptellen.Checked)
            //{
            //    double getalUitkomst = getal1 + getal2;
            //    tbUitkomst.Text = getalUitkomst.ToString();
            //    tbSom.Text = getal1.ToString() + " + " + getal2.ToString() + " = " + getalUitkomst.ToString();
            //}
            //if (rbAftrekken.Checked)
            //{
            //    double getalUitkomst = getal1 - getal2;
            //    tbUitkomst.Text = getalUitkomst.ToString();
            //    tbSom.Text = getal1.ToString() + " - " + getal2.ToString() + " = " + getalUitkomst.ToString();
            //}
            //if (rbVermenigvuldigen.Checked)
            //{
            //    double getalUitkomst = getal1 * getal2;
            //    tbUitkomst.Text = getalUitkomst.ToString();
            //    tbSom.Text = getal1.ToString() + " x " + getal2.ToString() + " = " + getalUitkomst.ToString();
            //}
            //if (rbDelen.Checked)
            //{
            //    double getalUitkomst = getal1 / getal2;
            //    tbUitkomst.Text = getalUitkomst.ToString();
            //    tbSom.Text = getal1.ToString() + " / " + getal2.ToString() + " = " + getalUitkomst.ToString();
            //}
            //if (rbKwadraad.Checked)
            //{

            //}
            //if (rbWortel.Checked)
            //{

            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}