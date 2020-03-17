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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[][] ventas = new string[6][];

        private void Form3_Load(object sender, EventArgs e)
        {
            ventas[0] = new string[5] { "3", "11", "1", "7", "20" };
            ventas[1] = new string[2] { "4", "6" };
            ventas[2] = new string[5] { "30", "16", "10", "8", "20" };
            ventas[3] = new string[4] { "2", "6", "14", "23" };
            ventas[4] = new string[6] { "3", "7", "17", "9", "23", "11" };
            ventas[5] = new string[2] { "10", "6" };
            lst1.Items.Clear();

            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                lst1.Items.Add("Sucursal #" + (i + 1));
            }

        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;

            if (lst1.SelectedIndex>=0)
            {
                lst2.Items.Clear();
                foreach(string ven in ventas[lst1.SelectedIndex])
                {
                    lst2.Items.Add(ven);
                    total = total + Convert.ToInt32(ven);
                }
            }
            lblTot.Text = total.ToString();

        }
    }
}
