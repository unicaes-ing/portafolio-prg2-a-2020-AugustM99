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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double totInv;

            totInv = Convert.ToDouble(txtInv1.Text) + Convert.ToDouble(txtInv2.Text) + Convert.ToDouble(txtInv3.Text);

            txtPorcen1.Text = Convert.ToString(((Convert.ToDouble(txtInv1.Text) / totInv) * 100).ToString("N2"));
            txtPorcen2.Text = Convert.ToString(((Convert.ToDouble(txtInv2.Text) / totInv) * 100).ToString("N2"));
            txtPorcen3.Text = Convert.ToString(((Convert.ToDouble(txtInv3.Text) / totInv) * 100).ToString("N2"));
            txtTotInv.Text = totInv.ToString("N2");
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInv1.Clear();
            txtInv2.Clear();
            txtInv3.Clear();
            txtPorcen1.Clear();
            txtPorcen2.Clear();
            txtPorcen3.Clear();
            txtTotInv.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
