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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double subTot,totPago, imp;

            if (cboLibros.SelectedItem.Equals("El principito"))
            {
                subTot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCant.Text);
                imp = subTot * 0.13;
                totPago = subTot + imp;

                txtSub.Text = subTot.ToString("C2");                
                txtImp.Text = imp.ToString("C2");
                txttotPago.Text = totPago.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("Cálculo Diferencial I"))
            {
                subTot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCant.Text);
                imp = subTot * 0.13;
                totPago = subTot + imp;

                txtSub.Text = subTot.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txttotPago.Text = totPago.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("Física para Ingenieros"))
            {
                subTot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCant.Text);
                imp = subTot * 0.13;
                totPago = subTot + imp;

                txtSub.Text = subTot.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txttotPago.Text = totPago.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("El Universo, un misterio sin resolver"))
            {
                subTot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCant.Text);
                imp = subTot * 0.13;
                totPago = subTot + imp;

                txtSub.Text = subTot.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txttotPago.Text = totPago.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("Atrapados en el espacio"))
            {
                subTot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCant.Text);
                imp = subTot * 0.13;
                totPago = subTot + imp;

                txtSub.Text = subTot.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txttotPago.Text = totPago.ToString("C2");
            }
            else
            {
                subTot = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCant.Text);
                imp = subTot * 0.13;
                totPago = subTot + imp;

                txtSub.Text = subTot.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txttotPago.Text = totPago.ToString("C2");
            }

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (cboLibros.SelectedItem.Equals("El principito"))
            {
                txtPrecio.Text = "7.99";
            }
            else if (cboLibros.SelectedItem.Equals("Cálculo Diferencial I"))
            {
                txtPrecio.Text = "35.00";
            }
            else if (cboLibros.SelectedItem.Equals("Física para Ingenieros"))
            {
                txtPrecio.Text = "24.50";
            }
            else if (cboLibros.SelectedItem.Equals("El Universo, un misterio sin resolver"))
            {
                txtPrecio.Text = "29.50";
            }
            else if (cboLibros.SelectedItem.Equals("Atrapados en el espacio"))
            {
                txtPrecio.Text = "5.99";
            }
            else 
            {
                txtPrecio.Text = "52.99";
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtCant.Clear();
            txtSub.Clear();
            txtImp.Clear();
            txttotPago.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
