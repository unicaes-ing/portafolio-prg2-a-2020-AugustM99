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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstLetra.ForeColor = Color.Blue;
            lstLetra.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic);
            lstLetra.Items.Clear();

            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                lstLetra.Items.Add(letra);
            }

            lstLetra.Items.Insert(14, 'Ñ');
        }
    }
}
