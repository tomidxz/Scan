using ScanDesktop.ViewsReport;
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
    public partial class HistorialDonacionesView : Form
    {
        GenericService<Donacion> donacionService = new GenericService<Donacion>();
        List<Donacion> donaciones = new List<Donacion>();
        public HistorialDonacionesView()
        {
            InitializeComponent();
            LoadDatos();
            LoadDonaciones();
        }

        private async void LoadDatos()
        {
            donaciones = await donacionService.GetAllAsync();
            LoadDonaciones();
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (checkBoxFiltro.Checked)
            {
                numericTotal.Value = donaciones.Where(d => d.Fecha >= dateTimeDesde.Value && d.Fecha <= dateTimeHasta.Value).Sum(d => d.Total);
            }
            else
            {
                numericTotal.Value = donaciones.Sum(d => d.Total);
            }
        }

        private async void LoadDonaciones()
        {
            dataGridDonacionesH.DataSource = donaciones;
            dataGridDonacionesH.Columns["Eliminado"].Visible = false;
            dataGridDonacionesH.Columns["DonadorId"].Visible = false;
            dataGridDonacionesH.Columns["EmpleadoId"].Visible = false;
            dataGridDonacionesH.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridDonacionesH.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void checkBoxFiltro_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltro.Enabled = checkBoxFiltro.Checked;
            if (checkBoxFiltro.Checked)
            {
                dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimeHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                LoadDonacionesFiltro();
                CalcularTotal();
            }
            else
            {
                LoadDonaciones();
                CalcularTotal();
            }
        }

        private void LoadDonacionesFiltro()
        {
            dataGridDonacionesH.DataSource = donaciones.Where(d => d.Fecha >= dateTimeDesde.Value && d.Fecha <= dateTimeHasta.Value).ToList();
            dataGridDonacionesH.Columns["Eliminado"].Visible = false;
            dataGridDonacionesH.Columns["DonadorId"].Visible = false;
            dataGridDonacionesH.Columns["EmpleadoId"].Visible = false;
            dataGridDonacionesH.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridDonacionesH.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void iconFiltrarDataGrid_Click(object sender, EventArgs e)
        {
            LoadDonacionesFiltro();
            CalcularTotal();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var TituloReporte = "Historial de Donaciones";
            var donacionesImprimir = donaciones;

            if (checkBoxFiltro.Checked)
            {
                donacionesImprimir = donaciones.Where(donacion => donacion.Fecha >= dateTimeDesde.Value && donacion.Fecha <= dateTimeHasta.Value).ToList();
                TituloReporte = $"Donaciones del {dateTimeDesde.Value.ToString("dd/MM/yyyy")} al {dateTimeHasta.Value.ToString("dd/MM/yyyy")}";
            }
             var HistorialDonacionesReport = new HistorialDonacionesReportView(donaciones,TituloReporte);
             HistorialDonacionesReport.ShowDialog();

        }

        private void iconBtnImprimir_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridDonacionesH.SelectedRows.Count > 0)
            {
                // Obtén el DonadorId de la fila seleccionada
                int donadorIdSeleccionado = (int)dataGridDonacionesH.SelectedRows[0].Cells["DonadorId"].Value;

                // Filtra las donaciones para el donador seleccionado
                var donacionesDonador = donaciones.Where(d => d.DonadorId == donadorIdSeleccionado).ToList();

                if (donacionesDonador.Any())
                {
                    // Construye el título del reporte
                    string TituloReporte = $"Donaciones de {donacionesDonador[0].Donador.Nombre}";

                    // Crea y muestra el reporte con las donaciones del donador seleccionado
                    var reporteDonador = new HistorialDonacionesReportView(donacionesDonador, TituloReporte);
                    reporteDonador.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El donador seleccionado no tiene donaciones registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una donación para generar el reporte del donador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
