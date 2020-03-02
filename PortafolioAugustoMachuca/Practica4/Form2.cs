using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int BuscarNum(int num, ListBox list1)
        {
            int cont = 0;
            foreach (int numero in list1.Items)
            {
                if (numero == num)
                {
                    cont++;
                }
            }
            return cont;
        }




        int num = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAdd.Text, out num) || num < 0)
            {
                MessageBox.Show("Ha ingresado un dato no válido.");
                txtAdd.Clear();
                txtAdd.Focus();
            }
            else
            {
                lstNumero.Items.Add(num);
                txtAdd.Clear();
                txtAdd.Focus();
            } 
            
        }
        
        
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtBuscar.Text);
                int cant = BuscarNum(num, lstNumero);
                MessageBox.Show("Se encuentra " + cant + " veces.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
                txtBuscar.SelectAll();
                txtBuscar.Focus();
            }

        }
    }
}
