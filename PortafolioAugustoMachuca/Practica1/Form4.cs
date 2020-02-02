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
            double totPago, imp;

            if (cboLibros.SelectedItem.Equals("El principito"))
            {
                txtSub.Text = (Convert.ToDouble("7.99") * Convert.ToInt32(txtCant.Text)).ToString("N2");
                imp = Convert.ToDouble(txtSub.Text)*0.13;
                txtImp.Text = imp.ToString("N2");
                totPago = Convert.ToDouble(txtSub.Text) + imp;
                txttotPago.Text = totPago.ToString("N2");
            }
            else if (cboLibros.SelectedItem.Equals("Cálculo Diferencial I"))
            {
                txtSub.Text = (Convert.ToDouble("35.00") * Convert.ToInt32(txtCant.Text)).ToString("N2");
                imp = Convert.ToDouble(txtSub.Text) * 0.13;
                txtImp.Text = imp.ToString("N2");
                totPago = Convert.ToDouble(txtSub.Text) + imp;
                txttotPago.Text = totPago.ToString("N2");
            }
            else if (cboLibros.SelectedItem.Equals("Física para Ingenieros"))
            {
                txtSub.Text = (Convert.ToDouble("24.50") * Convert.ToInt32(txtCant.Text)).ToString("N2");
                imp = Convert.ToDouble(txtSub.Text) * 0.13;
                txtImp.Text = imp.ToString("N2");
                totPago = Convert.ToDouble(txtSub.Text) + imp;
                txttotPago.Text = totPago.ToString("N2");
            }
            else if (cboLibros.SelectedItem.Equals("El Universo, un misterio sin resolver"))
            {
                txtSub.Text = (Convert.ToDouble("29.50") * Convert.ToInt32(txtCant.Text)).ToString("N2");
                imp = Convert.ToDouble(txtSub.Text) * 0.13;
                txtImp.Text = imp.ToString("N2");
                totPago = Convert.ToDouble(txtSub.Text) + imp;
                txttotPago.Text = totPago.ToString("N2");
            }
            else if (cboLibros.SelectedItem.Equals("Atrapados en el espacio"))
            {
                txtSub.Text = (Convert.ToDouble("5.99") * Convert.ToInt32(txtCant.Text)).ToString("N2");
                imp = Convert.ToDouble(txtSub.Text) * 0.13;
                txtImp.Text = imp.ToString("N2");
                totPago = Convert.ToDouble(txtSub.Text) + imp;
                txttotPago.Text = totPago.ToString("N2");
            }
            else
            {
                txtSub.Text = (Convert.ToDouble("52.99") * Convert.ToInt32(txtCant.Text)).ToString("N2");
                imp = Convert.ToDouble(txtSub.Text) * 0.13;
                txtImp.Text = imp.ToString("N2");
                totPago = Convert.ToDouble(txtSub.Text) + imp;
                txttotPago.Text = totPago.ToString("N2");
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
