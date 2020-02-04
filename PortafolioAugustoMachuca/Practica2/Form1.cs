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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConver_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNum.Text);
                string rom ="";

                if (num>=1 && num<=10)
                {
                    if (num==1)
                    {
                        rom = "I";
                    }
                    else if (num==2)
                    {
                        rom = "II";
                    }
                    else if (num==3)
                    {
                        rom = "III";
                    }
                    else if (num==4)
                    {
                        rom = "IV";
                    }
                    else if (num==5)
                    {
                        rom = "V";
                    }
                    else if (num==6)
                    {
                        rom = "VI";
                    }
                    else if (num==7)
                    {
                        rom = "VII";
                    }
                    else if (num==8)
                    {
                        rom = "VIII";
                    }
                    else if (num==9)
                    {
                        rom = "IX";
                    }
                    else
                    {
                        rom = "X";
                    }

                    txtNum.Focus();
                    txtNum.SelectAll();
                    lblRes.Text = "Equivale a " + rom + " en romano";
                }
                else
                {
                    txtNum.Focus();
                    txtNum.SelectAll();
                    lblRes.Text = "Ingrese un número entre 1 y 10";
                }
            }
            catch (Exception)
            {
                txtNum.Focus();
                txtNum.SelectAll();
                lblRes.Text = "Ingrese solo números";
            }
        }
    }
}
