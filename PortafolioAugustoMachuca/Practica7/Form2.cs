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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        [Serializable]
        public struct Mascotas
        {
           public string codigo;
           public string nombre;
           public string propietario;
           public string especie;
           public string Fecha;
           public double peso;
           public string sexo;
        }

        Mascotas mascota = new Mascotas();
        Dictionary<string, Mascotas> DicMasc = new Dictionary<string, Mascotas>();
        BinaryFormatter formatter = new BinaryFormatter();
        const string NOMBRE_ARCHIVO = "mascotas.dat";
        string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
       
        private void Form2_Load(object sender, EventArgs e)
        {
            rdoMacho.Checked= true;

            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("Propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                cboProp.Items.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    cboProp.Items.Add(Nombre);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }

            if (File.Exists(NOMBRE_ARCHIVO))
            {
                try
                {
                    FileStream ReaderFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Open, FileAccess.Read);
                    DicMasc = (Dictionary<string, Mascotas>)formatter.Deserialize(ReaderFS);
                    ReaderFS.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible leer el archivo...");
                }
                if (DicMasc.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (Mascotas mascota in DicMasc.Values)
                    {
                        dataGridView1.Rows.Add(mascota.codigo, mascota.nombre, mascota.propietario, mascota.especie, mascota.Fecha, mascota.peso, mascota.sexo);
                    }
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Existen datos almacenados en el archivo...");
                }
            }
        }

        private void btnGuardarMas_Click(object sender, EventArgs e)
        {
            if (mtxCod.Text.Equals("") || !mtxCod.MaskFull)
            {
                MessageBox.Show("Debe ingresar un código válido. Formato: AB1234");
            }
            else if (txtNombreMas.Text.Equals("") || !Regex.IsMatch(txtNombreMas.Text, patronNombre))
            {
                MessageBox.Show("Debe ingresar un nombre válido.");
            }
            else if (cboProp.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un propietario.");
            }
            else if (cboEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una especie.");
            }
            else if (txtPeso.Text.Equals("") || txtPeso.Text.StartsWith("."))
            {
                MessageBox.Show("Falta ingresar el peso.");
            }
            else
            {
                mascota.codigo = mtxCod.Text;
                mascota.nombre = txtNombreMas.Text;
                mascota.propietario = cboProp.SelectedItem + "";
                mascota.especie = cboEspecie.SelectedItem + "";
                mascota.Fecha = dtpFechaNac.Text;
                mascota.peso = Convert.ToDouble(txtPeso.Text);
                mtxCod.Clear();
                txtNombreMas.Clear();
                cboProp.SelectedIndex = -1;
                cboEspecie.SelectedIndex = -1;
                txtPeso.Clear();
                rdoMacho.Checked = true;
                errorProvider1.Clear();
                mtxCod.Focus();
                if (rdoMacho.Checked)
                {
                    mascota.sexo = rdoMacho.Text;  
                }
                else
                {
                    mascota.sexo = rdoHembra.Text;
                }

                if (DicMasc.ContainsKey(mascota.codigo))
                {
                    MessageBox.Show("Esta clave ya existe.");
                }
                else
                {
                    DicMasc.Add(mascota.codigo, mascota);
                    dataGridView1.Rows.Add(mascota.codigo, mascota.nombre, mascota.propietario, mascota.especie, mascota.Fecha, mascota.peso, mascota.sexo);
                    try
                    {
                        FileStream writerFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(writerFS, DicMasc);
                        writerFS.Close();
                        MessageBox.Show("Los datos fueron almacenados correctamente.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error al guardar los datos.");
                    }
                }
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txtPeso.Text.Contains("."))
            {
                e.Handled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombreMas_TextChanged(object sender, EventArgs e)
        {   
            if (!Regex.IsMatch(txtNombreMas.Text, patronNombre))
            {
                errorProvider1.SetError(txtNombreMas, "Debe iniciar con mayúscula.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

    }
}
