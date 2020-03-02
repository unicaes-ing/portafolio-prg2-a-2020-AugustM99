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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.ColumnCount = 10;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Random num = new Random();
            for (int col = 0; col < 10; col++)
            {
                dataGridView1.Rows.Add();
                for (int fil = 0; fil < 10; fil++)
                {
                    dataGridView1.Rows[col].Cells[fil].Value = num.Next(10, 100);
                }
            }
            dataGridView1.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtNum.Text);
            for (int fil = 0; fil < 10; fil++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (dataGridView1.Rows[fil].Cells[col].Value.Equals(num))
                    {
                        dataGridView1.Rows[fil].Cells[col].Style.BackColor = Color.Yellow;
                    }

                }
            }
        }
    }
}
