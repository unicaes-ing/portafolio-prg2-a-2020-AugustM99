using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, prom;
            c1 = Convert.ToDouble(txtC1.Text);
            c2 = Convert.ToDouble(txtC2.Text);
            c3 = Convert.ToDouble(txtC3.Text);
            prom = (c1 + c2 + c3) / 3.0;

            txtProm.Text = prom.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear();
            txtProm.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
