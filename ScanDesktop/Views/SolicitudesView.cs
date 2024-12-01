using ScanServices.Interfaces;
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
    public partial class SolicitudesView : Form
    {
        IGenericService<Solicitud> solicitudService = new GenericService<Solicitud>();
        BindingSource listaSolicitudes = new BindingSource();
        public SolicitudesView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridSolicitudes.DataSource = await solicitudService.GetAllAsync();
        }

        private async void iconEliminarSolicitud_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un solicitud para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtén el manwha seleccionado desde la fila seleccionada
            var selectedRow = dataGridSolicitudes.SelectedRows[0];
            var solicitudSeleccionada = (Solicitud)selectedRow.DataBoundItem;

            // Confirmación del usuario
            var result = MessageBox.Show("¿Está seguro que desea eliminar la solicitud?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Llama al servicio para eliminar el manwha
                    await solicitudService.DeleteAsync(solicitudSeleccionada.Id);

                    // Recarga la grilla
                    await CargarGrilla();

                    MessageBox.Show("La solicitud ha sido eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
