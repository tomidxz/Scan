using Microsoft.Reporting.WinForms;
using ScanServices.Enums;
using ScanServices.Models;
using ScanServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanDesktop.Views
{
    public partial class SplashView : Form
    {
        bool dataExitosa = false;
        bool printExitosa = false;
        public SplashView()
        {
            InitializeComponent();
        }

        private async void SplashView_Activated(object sender, EventArgs e)
        {
            var conectarDbTask = ConectarConDb();
            var imprimirReporteTask = ImprimirReporte();
            await Task.WhenAll(conectarDbTask, imprimirReporteTask);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 98)
                progressBar.Value += 4;
            if (dataExitosa && printExitosa)
            {
                timer.Enabled = false;
                this.Visible = false;
                var frmMenuInicial = new MenuInicialView();
                frmMenuInicial.ShowDialog();
                this.Close();
            }
        }

        private async Task ImprimirReporte()
        {
            await Task.Run(() =>
            {
                ReportViewer reporte = new ReportViewer();
                reporte.LocalReport.ReportEmbeddedResource = "ScanDesktop.Report.DonacionReport.rdlc";
                var donaciones = new List<Donacion> { new Donacion() { Id = 1, DonadorId=2, EmpleadoId=3, Fecha=DateTime.Now, Total=1000, FormaPago=FormaDePagoEnum.Transferencia } };
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDonacion", donaciones));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.RefreshReport();
                printExitosa = true;
            });
        }
        private async Task ConectarConDb()
        {
            await Task.Run(async () =>
            {
                DonadorService donadorService = new DonadorService();
                var donadores = await donadorService.GetAllAsync();
                dataExitosa = true;
            });
        }


    }
}
