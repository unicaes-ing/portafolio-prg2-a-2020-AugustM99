using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double total, desc;
            if (rdoUno.Checked)
            {
                desc = (Convert.ToInt32(txtCant.Text) * Convert.ToDouble(txtPrice.Text)) * 0;
                total = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtCant.Text)) - desc;

                txtDesc.Text = desc.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (rdoDos.Checked)
            {
                desc = (Convert.ToInt32(txtCant.Text) * Convert.ToDouble(txtPrice.Text)) * 0.05;
                total = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtCant.Text)) - desc;

                txtDesc.Text = desc.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (rdoTres.Checked)
            {
                desc = (Convert.ToInt32(txtCant.Text) * Convert.ToDouble(txtPrice.Text)) * 0.10;
                total = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtCant.Text)) - desc;

                txtDesc.Text = desc.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (rdoCuatro.Checked)
            {
                desc = (Convert.ToInt32(txtCant.Text) * Convert.ToDouble(txtPrice.Text)) * 0.15;
                total = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtCant.Text)) - desc;

                txtDesc.Text = desc.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else
            {
                desc = (Convert.ToInt32(txtCant.Text) * Convert.ToDouble(txtPrice.Text)) * 0.20;
                total = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtCant.Text)) - desc;

                txtDesc.Text = desc.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            txtCant.Focus();
            rdoUno.Focus();
        }
    }
}
