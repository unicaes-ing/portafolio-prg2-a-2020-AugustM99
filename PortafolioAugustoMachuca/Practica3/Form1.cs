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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum.Text, out Int32 numero))
            {
                lstTabla.Items.Clear();
                for (int ite = 1; ite <=10; ite++)
                {
                    lstTabla.Items.Add(numero + " * " + ite + " = " + numero * ite);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero");
            }
        }
    }
}
