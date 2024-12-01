using Microsoft.Reporting.WinForms;
using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanDesktop.ViewsReport
{
    public partial class TraduccionReportView : Form
    {
        ReportViewer reporte;
        private DetallesTraduccion? nuevatraduccion;
        public TraduccionReportView()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }
        public TraduccionReportView(DetallesTraduccion? nuevatraduccion)
        {
            this.nuevatraduccion = nuevatraduccion;
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void TraduccionReportView_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ScanDesktop.Reports.DetallesTraduccionReport.rdlc";
            List<object> detallesTraduccion = new List<object> { new {Id=nuevatraduccion.Id,Manwha=nuevatraduccion.Manwha,EmpleadoTraductor=nuevatraduccion.EmpleadoTraductor,
            EmpleadoTyper=nuevatraduccion.EmpleadoTyper, EmpleadoCleaner=nuevatraduccion.EmpleadoCleaner,CapituloTraducido=nuevatraduccion.CapituloTraducido, Fecha=nuevatraduccion.Fecha} };

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesTraduccion", detallesTraduccion));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
