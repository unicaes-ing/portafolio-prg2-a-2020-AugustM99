using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string patron = @"^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})\S$";

            if (!Regex.IsMatch(txtCorreo.Text, patron))
            {
                e.Cancel = true;
                txtCorreo.SelectAll();
                errorPro.SetError(txtCorreo, "Ingrese un correo válido");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            string patron2 = @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";

            if (txtContra.TextLength<8)
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorPro.SetError(txtContra, "La contraseña debe tener al menos 8 caracteres.");
            }else if (!Regex.IsMatch(txtContra.Text, patron2))
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorPro.SetError(txtContra, "La contraseña debe contener al menos un número, un carácter especial, una letra mayúscula y una minúscula.");
            }           
        }

        private void txtContra_Validated(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void txtConfir_Validating(object sender, CancelEventArgs e)
        {
            string patron3 = @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";

            if (txtContra.TextLength < 8)
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorPro.SetError(txtContra, "La contraseña debe tener al menos 8 caracteres.");
            }
            else if (!Regex.IsMatch(txtContra.Text, patron3))
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorPro.SetError(txtContra, "La contraseña debe contener al menos un número, un carácter especial, una letra mayúscula y una minúscula.");
            }
        }

        private void txtConfir_Validated(object sender, EventArgs e)
        {
            errorPro.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text=="")
            {
                txtCorreo.Focus();
                MessageBox.Show("El correo electronico es un campo obligatorio", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtContra.Text=="")
            {
                txtContra.Focus();
                MessageBox.Show("La contraseña es un campo obligatorio", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtConfir.Text=="")
            {
                txtConfir.Focus();
                MessageBox.Show("La contraseña de confirmación es un campo obligatorio.", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtContra.Text != txtConfir.Text)
            {
                txtConfir.Focus();
                txtConfir.SelectAll();
                MessageBox.Show("Las contraseñas ingresadas son distintas.", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Los datos han sido almacenados con éxito.", "Mensaje", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
