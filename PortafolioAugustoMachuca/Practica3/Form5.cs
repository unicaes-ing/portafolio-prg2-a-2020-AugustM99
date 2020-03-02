using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
            if (!Regex.IsMatch(txtNombre.Text, nombre))
            {
                e.Cancel = true;
                txtNombre.SelectAll();
                errorProvider1.SetError(txtNombre, "El nombre ingresado no es valido. Debe iniciar con letra mayúscula...");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtHoras_Validating(object sender, CancelEventArgs e)
        {
            if (txtHoras.Text == "")
            {
                e.Cancel = true;
                txtHoras.Focus();
                errorProvider1.SetError(txtHoras, "La cantidad de horas es un campo obligatorio.");
            }
        }

        private void txtHoras_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtValorhora_Validating(object sender, CancelEventArgs e)
        {
            if (txtValorhora.Text == "")
            {
                e.Cancel = true;
                txtValorhora.Focus();
                errorProvider1.SetError(txtValorhora, "El precio por hora es un campo obligatorio.");
            }
        }

        private void txtValorhora_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int horas;
            double precio, subtotal, total = 0, impuesto;


            if (nombre != string.Empty && int.TryParse(txtHoras.Text, out horas) && double.TryParse(txtValorhora.Text, out precio))
            {
                subtotal = horas * precio;
                impuesto = (subtotal * 0.10);
                total = subtotal - impuesto;

                dataGridView1.Rows.Add(nombre, horas, precio, subtotal, impuesto, total);

            }
            double suma = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                suma = suma + Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }


            lblTotalplanilla.Text = suma.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtValorhora.Clear();
        }
    }
}
