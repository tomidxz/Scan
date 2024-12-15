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
    public partial class DonacionReportView : Form
    {
        ReportViewer reporte;
        private Donacion? nuevadonacion;

        public DonacionReportView()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        public DonacionReportView(Donacion? nuevadonacion)
        {
            this.nuevadonacion = nuevadonacion;
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }


        private void DonacionReportView_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ScanDesktop.Report.DonacionReport.rdlc";
            List<object> donaciones = new List<object> { new { Id = nuevadonacion.Id, Fecha = nuevadonacion.Fecha, Donador = nuevadonacion.Donador.Nombre, FormaPago = nuevadonacion.FormaPago, Total = nuevadonacion.Total, Empleado=nuevadonacion.Empleado.Nombre } };
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDonacion", donaciones));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
