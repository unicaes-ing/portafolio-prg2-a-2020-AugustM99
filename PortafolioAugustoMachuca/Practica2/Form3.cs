using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (lstConv1.SelectedItem != lstConv2.SelectedItem)
            {
                if (lstConv1.SelectedItem.Equals("Pulgadas") && lstConv2.SelectedItem.Equals("Pies"))
                {
                    double resul;

                    resul = Convert.ToDouble(txtCant.Text) / 12;

                    txtConver.Text = resul.ToString("N2");
                }
                else if (lstConv1.SelectedItem.Equals("Pulgadas") && lstConv2.SelectedItem.Equals("Yardas"))
                {
                    double resul;

                    resul = Convert.ToDouble(txtCant.Text) / 36;

                    txtConver.Text = resul.ToString("N2");
                }
                else if (lstConv1.SelectedItem.Equals("Pies") && lstConv2.SelectedItem.Equals("Pulgadas"))
                {
                    double resul;

                    resul = Convert.ToDouble(txtCant.Text) * 12;

                    txtConver.Text = resul.ToString("N2");
                }
                else if (lstConv1.SelectedItem.Equals("Pies") && lstConv2.SelectedItem.Equals("Yardas"))
                {
                    double resul;

                    resul = Convert.ToDouble(txtCant.Text) / 3;

                    txtConver.Text = resul.ToString("N2");
                }
                else if (lstConv1.SelectedItem.Equals("Yardas") && lstConv2.SelectedItem.Equals("Pulgadas"))
                {
                    double resul;

                    resul = Convert.ToDouble(txtCant.Text) * 36;

                    txtConver.Text = resul.ToString("N2");
                }
                else if (lstConv1.SelectedItem.Equals("Yardas") && lstConv2.SelectedItem.Equals("Pies"))
                {
                    double resul;

                    resul = Convert.ToDouble(txtCant.Text) * 3;

                    txtConver.Text = resul.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Para convertir debe seleccionar longitudes diferentes.", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtConver.Clear();
            txtCant.Focus();
        }
    }
}
