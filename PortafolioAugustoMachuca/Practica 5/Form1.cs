using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] vendedores = {"Juan", "Pedro", "Daniel", "Julio", "Maria", "Lucía", "Sofía", "Susana", "Damaris", "Diego"};

        private void Form1_Load(object sender, EventArgs e)
        {           
            
            lstVendedor.DataSource = vendedores;
        }

        private void btnOrdAsc_Click(object sender, EventArgs e)
        {
            lstVendedor.DataSource = null;
            Array.Sort(vendedores);
            lstVendedor.DataSource= vendedores;
        }

        private void btnOrdDes_Click(object sender, EventArgs e)
        {
            lstVendedor.DataSource = null;
            Array.Reverse(vendedores);
            lstVendedor.DataSource = vendedores;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //forma dificil
            //string[] temp = new string[vendedores.Length];
            //int n = 0;
            //for (int i = 0; i < vendedores.Length; i++)
            //{
            //    if (i != lstVendedor.SelectedIndex)
            //    {
            //        temp[n] = vendedores[i];
            //        n++;
            //    }
            //}
            //vendedores = temp;
            //lstVendedor.DataSource = vendedores;

            ////metodo lista

            //if (lstVendedor.SelectedIndex >=0)
            //{
            //    List<string> lista = new List<String>(vendedores);
            //    lista.RemoveAt(lstVendedor.SelectedIndex);
            //    vendedores = lista.ToArray();
            //    lstVendedor.DataSource = vendedores;
            //    lstVendedor.SelectedIndex = -1;
            //}

            //metodo Linq
            if (lstVendedor.SelectedIndex>0)
            {
                vendedores = vendedores.Where((item, index) => index != lstVendedor.SelectedIndex).ToArray();
                lstVendedor.DataSource = vendedores;
                lstVendedor.SelectedIndex = -1;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarNom.TextLength>0)
            {
                int i = Array.IndexOf(vendedores, txtBuscarNom.Text);
                if (i>=0)
                {
                    lstVendedor.SelectedIndex = i;
                }
                else
                {
                    MessageBox.Show("No esta en la lista...");
                }
            }
            else
            {
                MessageBox.Show("Escriba el nombre a buscar");
                txtBuscarNom.Focus();
            }
        }
    }
}
