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

namespace Practica6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Dictionary<string, string> Clientes = new Dictionary<string, string>();

        string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
        string patronTel = @"^([2|6|7][0-9]{3})-([0-9]{4})$";

        ListViewItem ListClient = new ListViewItem();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTel.Text, patronTel))
            {
                errorProvider1.SetError(txtTel, "Ingrese un número de teléfono válido.");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre válido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTel.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                txtTel.Focus();
            }
            else if (!Regex.IsMatch(txtTel.Text, patronTel) || !Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                MessageBox.Show("El nombre y el teléfono deben cumplir con el formato requerido.");

            }
            else if (Clientes.ContainsKey(txtTel.Text))
            {
                MessageBox.Show("Este teléfono ya existe. Debe ingresar uno diferente.");
            }
            else
            {
                ListViewItem ListClient = new ListViewItem(txtTel.Text);
                Clientes.Add(txtTel.Text, txtNombre.Text);

                ListClient.SubItems.Add(txtNombre.Text);
                lvwClientes.Items.Add(ListClient);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                MessageBox.Show("Debe ingresar un telefono.");
            }
            else if (!Clientes.ContainsKey(txtTel.Text))
            {
                MessageBox.Show("El teléfono ingresado no existe.");
                txtTel.Select();
                txtTel.Focus();
            }
            else 
            {
                foreach(ListViewItem lista in lvwClientes.Items)
                {
                    if (lista.Text == txtTel.Text)
                    {
                        MessageBox.Show("Número perteneciente al contacto: " + Clientes[txtTel.Text].ToString());
                    }
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (Clientes.Count == 0)
            {
                MessageBox.Show("No hay datos para eliminar.");
            }
            else if (lvwClientes.SelectedItems.Count==0)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminarlo.");
            }
            else
            {
                Clientes.Remove(txtTel.Text);
                foreach (ListViewItem lista in lvwClientes.SelectedItems)
                {
                    lista.Remove();
                }
            }
            
        }
    }
}
