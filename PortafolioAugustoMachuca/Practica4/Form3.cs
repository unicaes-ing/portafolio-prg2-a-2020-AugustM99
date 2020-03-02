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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int Fibo(int num)
        {
            if (num < 2)

                return num;

            else

                return Fibo(num - 1) + Fibo(num - 2);

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int fibonacci = Fibo(numero);
            txtFibonacci.Text = string.Format("{0}", fibonacci);
        }
    }
}
