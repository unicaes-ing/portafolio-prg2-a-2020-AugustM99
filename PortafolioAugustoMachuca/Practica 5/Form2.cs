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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int[,] MathOp(int[,] matriz1, int[,] matriz2, RadioButton op)
        {
            int[,] result = new int[5, 5];
            if (op.Checked)
            {
                for (int fil = 0; fil < result.GetLength(0); fil++)
                {
                    for (int col = 0; col < result.GetLength(1); col++)
                    {
                        result[fil, col] = matriz1[fil, col] + matriz2[fil, col];
                    }
                }
            }     
            return result;
        }

        public static int[,] MathOp2(int[,] matriz1, int[,] matriz2, RadioButton op)
        {
            int[,] result = new int[5, 5];
            if (op.Checked)
            {
                for (int fil = 0; fil < result.GetLength(0); fil++)
                {
                    for (int col = 0; col < result.GetLength(1); col++)
                    {
                        result[fil, col] = matriz1[fil, col] * matriz2[fil, col];
                    }
                }
            }
            return result;
        }

        int[,] MatrizA = new int[5, 5];
        int[,] MatrizB = new int[5, 5];
       
        int fil, col;
        private void Form2_Load(object sender, EventArgs e)
        {
            Random num = new Random();

            dgvA.AllowUserToAddRows = false;
            dgvA.ScrollBars = ScrollBars.Both;
            dgvA.ColumnCount = 5;
            dgvA.ColumnHeadersVisible = false;
            dgvA.RowHeadersVisible = false;
            dgvA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvB.AllowUserToAddRows = false;
            dgvB.ScrollBars = ScrollBars.Both;
            dgvB.ColumnCount = 5;
            dgvB.ColumnHeadersVisible = false;
            dgvB.RowHeadersVisible = false;
            dgvB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (fil = 0; fil < MatrizA.GetLength(0); fil++)
            {
                dgvA.Rows.Add();
                dgvB.Rows.Add();
                for (col = 0; col < MatrizA.GetLength(1); col++)
                {
                    MatrizA[fil, col] = num.Next(10, 91);
                    MatrizB[fil, col] = num.Next(10, 91);
                    dgvA.Rows[fil].Cells[col].Value = MatrizA[fil, col];
                    dgvB.Rows[fil].Cells[col].Value = MatrizB[fil, col];
                }
            }
            dgvA.ClearSelection();
            dgvB.ClearSelection();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvResul.Rows.Clear();
            dgvResul.Columns.Clear();
            dgvResul.AllowUserToAddRows = false;
            dgvResul.ScrollBars = ScrollBars.Both;
            dgvResul.ColumnCount = 5;
            dgvResul.ColumnHeadersVisible = false;
            dgvResul.RowHeadersVisible = false;
            dgvResul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int[,] res = new int[5, 5];
            
            if (rdoSum.Checked)
            {
                res= MathOp(MatrizA, MatrizB, rdoSum);
                for (fil = 0; fil < MatrizA.GetLength(0); fil++)
                {
                    dgvResul.Rows.Add();
                    for (col = 0; col < MatrizA.GetLength(1); col++)
                    {
                        dgvResul.Rows[fil].Cells[col].Value = res[fil, col];
                    }
                }
            }
            else
            {
                res = MathOp2(MatrizA, MatrizB, rdoMulti);
                for (fil = 0; fil < MatrizA.GetLength(0); fil++)
                {
                    dgvResul.Rows.Add();
                    for (col = 0; col < MatrizA.GetLength(1); col++)
                    {
                        dgvResul.Rows[fil].Cells[col].Value = res[fil, col];
                    }
                }

            }
            dgvResul.ClearSelection();
        }
    }
}
