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

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
        string patronCorreo = @"^\S[_a-zA-Z0-9-]+(.[_a-zA-Z0-9-]+)@\S[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{1,4})\S$";
        string patronTel = @"^([2|6|7][0-9]{3})-([0-9]{4})$";

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre válido.\nDebe iniciar con mayúscula.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo válido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void mtxTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!Regex.IsMatch(mtxTel.Text, patronTel))
            {
                errorProvider1.SetError(mtxTel, "Ingrese un teléfono válido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            FileStream fs = null;
            BinaryWriter bw = null;
            errorProvider1.Clear();

            if (txtNombre.Text.Equals("") && txtCorreo.Text.Equals("") && !mtxTel.MaskFull)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                txtNombre.Focus();
            }
            else if (txtNombre.Text.Equals("") || !Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                MessageBox.Show("Falta ingresar un nombre.");
            }
            else if (txtCorreo.Text.Equals("") || !Regex.IsMatch(txtCorreo.Text, patronCorreo) || txtCorreo.Text.Contains(";") || txtCorreo.Text.Contains(":"))
            {
                MessageBox.Show("Falta ingresar un correo válido.");
            }
            else if (mtxTel.Text.Equals("") || !mtxTel.MaskFull || !Regex.IsMatch(mtxTel.Text, patronTel))
            {
                MessageBox.Show("Ingrese un teléfono válido.");
            }
            else
            {
                
                dataGridView1.Rows.Add(txtNombre.Text, txtCorreo.Text, mtxTel.Text);
                dataGridView1.ClearSelection();
                try
                {
                    fs = new FileStream("propietarios.dat", FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    bw.Write(txtNombre.Text);
                    bw.Write(txtCorreo.Text);
                    bw.Write(mtxTel.Text);
                    MessageBox.Show("Todos los datos se guardaron correctamente.");
                    txtNombre.Clear();
                    txtCorreo.Clear();
                    mtxTel.Clear();
                    txtNombre.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al guardar los datos.");
                }
                finally
                {
                    if (bw!=null)
                    {
                        bw.Close();
                    }
                }   
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name, mail, tel;
            FileStream fs = null;
            BinaryReader bw = null;

            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                bw = new BinaryReader(fs);
                dataGridView1.Rows.Clear();
                while (true)
                {
                    name = bw.ReadString();
                    mail = bw.ReadString();
                    tel = bw.ReadString();
                    dataGridView1.Rows.Add(name, mail, tel);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (bw!= null)
                {
                    bw.Close();
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {           
            if (dataGridView1.Rows.Count>0)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe agregar por lo menos un propietario.");
                txtNombre.Focus();
            }
            
        }
    }
}
