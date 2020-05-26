using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Visible = false;
            lbl1.Visible = false;
            txt2.Visible = false;
            lbl2.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!rdoCir.Checked && !rdoCua.Checked && !rdoTrian.Checked)
            {
                MessageBox.Show("Debe seleccionar una opción.");
            }
            else if (rdoCir.Checked)
            {
                if (txt1.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el valor 1.");
                }
                else
                {
                    Circulo circulo = new Circulo();
                    circulo.Valor1 = Convert.ToDouble(txt1.Text);
                    txtResp.Text = circulo.Area().ToString("N2");
                    txt1.Clear();
                }
            }
            else if (rdoCua.Checked)
            {
                if (txt1.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el valor 1.");
                }
                else
                {
                    Cuadrado cuadrado = new Cuadrado();
                    cuadrado.Valor1 = Convert.ToDouble(txt1.Text);
                    txtResp.Text = cuadrado.Area().ToString("N2");
                    txt2.Clear();
                    
                }
            }
            else
            {
                if (txt1.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el valor 1.");
                }
                else if (txt2.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el valor 2.");
                }
                else
                {
                    Triangulo triangulo = new Triangulo();
                    triangulo.Valor1 = Convert.ToDouble(txt1.Text);
                    triangulo.Valor2 = Convert.ToDouble(txt2.Text);
                    txtResp.Text = triangulo.Area().ToString("N2");
                    txt1.Clear();
                    txt2.Clear();
                }
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void rdoCir_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Focus();
            txt1.Visible = true;
            lbl1.Visible = true;
            txt2.Visible = false;
            lbl2.Visible = false;
            txt1.Clear();
            txtResp.Clear();
        }

        private void rdoCua_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Focus();
            txt1.Visible = true;
            lbl1.Visible = true;
            txt2.Visible = false;
            lbl2.Visible = false;
            txt1.Clear();
            txtResp.Clear();
        }

        private void rdoTrian_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Focus();
            txt1.Visible = true;
            lbl1.Visible = true;
            txt2.Visible = true;
            lbl2.Visible = true;
            txt1.Clear();
            txt2.Clear();
            txtResp.Clear();
        }
    }
}
