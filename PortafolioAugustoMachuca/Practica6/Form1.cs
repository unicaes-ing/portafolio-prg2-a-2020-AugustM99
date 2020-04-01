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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListEmpleados = new List<string>();
        string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
        private void Form1_Load(object sender, EventArgs e)
        {
            rdoAgregar.Checked = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            lstNombres.DataSource = null;
            if (rdoAgregar.Checked)
            {              
                lstNombres.Items.Clear();
                txtNombre.SelectAll();
                txtNombre.Focus();
                if (txtNombre.Text != "" && Regex.IsMatch(txtNombre.Text, patronNombre))
                {
                    ListEmpleados.Add(txtNombre.Text);

                    foreach (string empleado in ListEmpleados)
                    {
                        lstNombres.Items.Add(empleado);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre.");
                }
                
            }
            else if (rdoBuscar.Checked)
            {
                if (txtNombre.Text != "" && Regex.IsMatch(txtNombre.Text, patronNombre) && !lstNombres.Items.Count.Equals(""))
                {
                    foreach (string empleado in ListEmpleados)
                    {
                        if (txtNombre.Text == empleado)
                        {
                            lstNombres.SelectedItem = empleado;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El nombre ingresado no existe.");
                }
            }
            else if (rdoInsertar.Checked)
            {              
                if (txtNombre.Text != "" && Regex.IsMatch(txtNombre.Text, patronNombre) && lstNombres.Items.Count > 0)
                {
                    lstNombres.Items.Insert(lstNombres.SelectedIndex, txtNombre.Text); ;

                    ListEmpleados.Insert(lstNombres.SelectedIndex, txtNombre.Text);
                }
                else
                {
                    MessageBox.Show("No se puede insertar el nombre.");
                }
            }
            else if (rdoQuitar.Checked)
            {
                

                if (lstNombres.Items.Count > 0 && lstNombres.SelectedIndex != -1)
                {
                    ListEmpleados.RemoveAt(lstNombres.SelectedIndex);

                    lstNombres.Items.RemoveAt(lstNombres.SelectedIndex);

                }
                else
                {
                    MessageBox.Show("No se puede quitar el nombre. Debe seleccionar para eliminar.");
                }
            }
            else if (rdoOrdenar.Checked)
            {
                ListEmpleados.Sort();
                if (lstNombres.Items.Count>1 && lstNombres.Items.Count==0)
                {
                    lstNombres.DataSource = ListEmpleados;                  
                }
                else
                {
                    MessageBox.Show("No se puede ordenar la lista.");
                }
            }
            else
            {
                if (lstNombres.Items.Count>=1)
                {
                    lstNombres.Items.Clear();
                    ListEmpleados.Clear();
                    
                }
                else
                {
                    MessageBox.Show("No hay elementos para borrar.");
                }   
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre con inicial mayúscula.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
