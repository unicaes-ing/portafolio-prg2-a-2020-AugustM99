using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Practica_9
{
    public partial class rvMascotas : Form
    {
        public rvMascotas()
        {
            InitializeComponent();
        }
        public List<Mascota> listaMascotas = new List<Mascota>();

        private void rvMascotas_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DisplayName = "Reporte de mascotas";
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMascotas", listaMascotas));
            this.reportViewer1.RefreshReport();
        }
    }
}
