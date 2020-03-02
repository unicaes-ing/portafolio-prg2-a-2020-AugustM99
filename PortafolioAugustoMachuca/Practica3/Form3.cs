using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            int cont= 0, numero;
            Random num = new Random();
            lstNum.Items.Clear();
            for (int ite = 1; ite <=5000 ; ite++)
            {
                numero = num.Next(1,7);

                if (numero==6)
                {
                    cont++;
                }
                lstNum.Items.Add(numero);
            }
            MessageBox.Show("Cantidad de veces que obtuvo el número 6: " + cont);
        }
    }
}
