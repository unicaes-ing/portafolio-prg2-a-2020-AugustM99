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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public struct DatosEmp
        {
            public string Nit;
            public string Nombre;
            public double sueldo;
        }

        Dictionary<string, DatosEmp> RegEmpDic = new Dictionary<string, DatosEmp>();
        string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
        double total = 0.0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txtSueldo.Text.Contains("."))
            {
                e.Handled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre que sea válido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mtxNit.TextLength<=0 || txtNombre.Text == "" || txtSueldo.Text == "")
            {
                mtxNit.Focus();
                MessageBox.Show("Todos los campos son obligatorios.");
            }
            else if (mtxNit.Text == "" || !mtxNit.MaskFull)
            {
                mtxNit.SelectAll();
                
                MessageBox.Show("El NIT es un campo obligatorio.\nIngrese un NIT válido");
            }
            else if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, patronNombre) || txtNombre.TextLength <= 0)
            {
                txtNombre.SelectAll();
                txtNombre.Focus();
                MessageBox.Show("El nombre es un campo obligatorio.\nIngrese un nombre válido");
                
            }
            else if (txtSueldo.Text == "")
            {
                txtSueldo.SelectAll();
                txtSueldo.Focus();
                MessageBox.Show("El sueldo es un campo obligatorio.\nIngrese el sueldo...");  
            }
            else if (RegEmpDic.ContainsKey(mtxNit.Text))
            {
                MessageBox.Show("Este número de NIT ya existe\nIngrese un numero de NIT diferente.");
            }
            else
            { 
                DatosEmp Datos = new DatosEmp();

                Datos.Nit = mtxNit.Text;
                Datos.Nombre = txtNombre.Text;
                Datos.sueldo = Convert.ToDouble(txtSueldo.Text);

                RegEmpDic.Add(Datos.Nit, Datos);

                dgvDatos.Rows.Add(Datos.Nit, Datos.Nombre, Datos.sueldo);

                total = total + Convert.ToDouble(Datos.sueldo);
                lblTot.Text = total.ToString();
                dgvDatos.ClearSelection();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtxNit2.Text == "" || !mtxNit2.MaskFull)
            {
                MessageBox.Show("Ingrese un codigo para buscar...");
                mtxNit2.Focus();
                mtxNit2.SelectAll();
            }
            else if (RegEmpDic.ContainsKey(mtxNit2.Text))
            {
                for (int ite = 0; ite < dgvDatos.Rows.Count; ite++)
                {
                    dgvDatos.Rows[ite].DefaultCellStyle.BackColor = Color.White;
                    if (dgvDatos.Rows[ite].Cells[0].Value.Equals(mtxNit2.Text))
                    {
                        dgvDatos.Rows[ite].DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }
            else
            {
                MessageBox.Show("El NIT que desea buscar no existe.");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (mtxNit2.Text == "" || !mtxNit2.MaskFull)
            {
                MessageBox.Show("Ingrese un NIT para eliminar.");
                mtxNit2.Focus();
            }
            else if (RegEmpDic.ContainsKey(mtxNit2.Text))
            {
                for (int ite = 0; ite < dgvDatos.Rows.Count; ite++)
                {
                    if (dgvDatos.Rows[ite].Cells[0].Value.Equals(mtxNit2.Text))
                    {
                        total = total - Convert.ToDouble(dgvDatos.Rows[ite].Cells[2].Value);
                        dgvDatos.Rows.RemoveAt(ite);
                        RegEmpDic.Remove(mtxNit2.Text);
                    }
                }
                lblTot.Text = total + "";
            }
            else
            {
                lblTot.Text = total + "";
                MessageBox.Show("El NIT del empleado que desea eliminar no existe...");
                mtxNit2.Focus();
                mtxNit2.SelectAll();
            }
        }
    }
}
