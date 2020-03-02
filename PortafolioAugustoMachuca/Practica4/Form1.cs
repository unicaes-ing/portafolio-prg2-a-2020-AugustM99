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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        int num1, num2, num3, num4;

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum1.Text, out num1) && int.TryParse(txtNum2.Text, out num2) && int.TryParse(txtNum3.Text, out num3) && int.TryParse(txtNum4.Text, out num4))
            {
                lblResul.Text = (MisFunciones.SumarNum(num1, num2, num3, num4)).ToString();
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum3.Clear();
                txtNum4.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese números válidos.");
            }
                

            

           
        }
    }
}
