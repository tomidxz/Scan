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
    public partial class HistorialDonacionesReportView : Form
    {
        ReportViewer reporte;
        private List<Donacion> listaDonaciones;
        private string tituloReporte;

        public HistorialDonacionesReportView(List<Donacion>donaciones,string TituloReporte)
        {
            InitializeComponent();
            listaDonaciones = donaciones;
            this.tituloReporte = TituloReporte;
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void HistorialDonacionesReportView_Load(object sender, EventArgs e)
        {
            //
            reporte.LocalReport.ReportEmbeddedResource = "ScanDesktop.Report.HistorialDonacionesReport.rdlc";
            //armamos la lista de donaciones
            var donaciones = listaDonaciones.
                OrderBy(donaciones=> donaciones.FormaPago).
                Select(donaciones => new
                {
                    Id = donaciones.Id,
                    Fecha = donaciones.Fecha,
                    Donador = donaciones.Donador.Nombre,
                    FormaPago = donaciones.FormaPago.ToString(),
                    Total = donaciones.Total,
                    Empleado = donaciones.Empleado.Nombre
                }).ToList();

            reporte.LocalReport.SetParameters(new ReportParameter("TituloReporte", tituloReporte));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDonaciones", donaciones));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
