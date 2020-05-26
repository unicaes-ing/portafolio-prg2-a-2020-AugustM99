using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoCarro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCarro.Checked)
            {
                txtPuertas.Visible = true;
                lblPuertas.Visible = true;
            }
            else
            {
                txtPuertas.Visible = false;
                lblPuertas.Visible = false;
            }
        }

        private void rdoCamion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCamion.Checked)
            {
                txtCapacidad.Visible = true;
                lblCapacidad.Visible = true;
                txtTanque.Visible = true;
                lblTanque.Visible = true;
            }
            else
            {
                txtCapacidad.Visible = false;
                lblCapacidad.Visible = false;
                txtTanque.Visible = false;
                lblTanque.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPuertas.Visible = false;
            txtPuertas.Visible = false;
            lblCapacidad.Visible = false;
            txtCapacidad.Visible = false;
            lblTanque.Visible = false;
            txtTanque.Visible = false;
            lblPasajeros.Visible = false;
            txtPasajeros.Visible = false;
        }

        private void rdoMicrobus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMicrobus.Checked)
            {
                txtPasajeros.Visible = true;
                lblPasajeros.Visible = true;
            }
            else
            {
                txtPasajeros.Visible = false;
                lblPasajeros.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == string.Empty && txtModel.Text == string.Empty && nudPrecio.Value == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                txtMarca.Focus();
            }
            else if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("La marca es un campo obligatorio.");
                txtMarca.Focus();
            }
            else if (txtModel.Text == string.Empty)
            {
                MessageBox.Show("El modelo es un campo obligatorio.");
                txtModel.Focus();
            }
            else if (nudPrecio.Value == 0)
            {
                MessageBox.Show("El precio es un campo obligatorio");
                nudPrecio.Focus();
            }
            else if (!rdoCarro.Checked && !rdoCamion.Checked && !rdoMicrobus.Checked )
            {
                MessageBox.Show("Elija el tipo de vehiculo.");
            }
            else if (rdoCarro.Checked)
            {
                if (txtPuertas.Text == string.Empty)
                {
                    MessageBox.Show("La cantidad de puertas es un campo obligatorio");
                    txtPuertas.Focus();
                }
                else
                {
                    Carro carro = new Carro(txtMarca.Text, Convert.ToInt32(nudMillas.Value), txtModel.Text, Convert.ToDouble(nudPrecio.Value), Convert.ToInt32(txtPuertas.Text));
                    dataGridView1.Rows.Add(carro.Marca, carro.Modelo, carro.Millaje, carro.Precio.ToString("C2"), rdoCarro.Text, carro.Puertas);
                    txtMarca.Clear();
                    txtModel.Clear();
                    nudMillas.Value = 0;
                    txtModel.Clear();
                    nudPrecio.Value = 0;
                    rdoCarro.Checked = false;
                    txtPuertas.Clear();
                    txtMarca.Focus();
                }
            }
            else if (rdoCamion.Checked)
            {
                if (txtCapacidad.Text == string.Empty)
                {
                    MessageBox.Show("La capacidad de carga es un campo obligatorio");
                    txtCapacidad.Focus();
                }
                else if (txtTanque.Text == string.Empty)
                {
                    MessageBox.Show("La capacidad del tanque de combustible es un campo obligatorio");
                }
                else
                {
                    Camion camion = new Camion(txtMarca.Text, Convert.ToInt32(nudMillas.Value), txtModel.Text, Convert.ToDouble(nudPrecio.Value), Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(txtTanque.Text));
                    dataGridView1.Rows.Add(camion.Marca, camion.Modelo, camion.Millaje, camion.Precio.ToString("C2"), rdoCamion.Text, "" , camion.CapacidadCarga, camion.TanqueCombustible);
                    txtMarca.Clear();
                    txtModel.Clear();
                    nudMillas.Value = 0;
                    txtModel.Clear();
                    nudPrecio.Value = 0;
                    rdoCamion.Checked = false;
                    txtCapacidad.Clear();
                    txtTanque.Clear();
                    txtMarca.Focus();
                }
            }
            else if (rdoMicrobus.Checked)
            {
                if (txtPasajeros.Text == string.Empty)
                {
                    MessageBox.Show("El número de pasajeros es un campo obligatorio.");
                    txtPasajeros.Focus();
                }
                else
                {
                    Microbus microbus = new Microbus(txtMarca.Text, Convert.ToInt32(nudMillas.Value), txtModel.Text, Convert.ToDouble(nudPrecio.Value), Convert.ToInt32(txtPasajeros.Text));
                    dataGridView1.Rows.Add(microbus.Marca, microbus.Modelo, microbus.Millaje, microbus.Precio.ToString("C2"), rdoMicrobus.Text, "", "", "", microbus.Pasajeros);
                    txtMarca.Clear();
                    txtModel.Clear();
                    nudMillas.Value = 0;
                    txtModel.Clear();
                    nudPrecio.Value = 0;
                    rdoMicrobus.Checked = false;
                    txtPasajeros.Clear();
                    txtMarca.Focus();
                }
            }
        }
    }
}
