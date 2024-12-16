using Microsoft.VisualBasic.Logging;
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
    public partial class DonadorView : Form
    {
        IGenericService<Donador> donadorService = new GenericService<Donador>();
        BindingSource listaDonadores = new BindingSource();
        List<Donador> donadoresFiltrar = new List<Donador>();
        Donador donadorCurrent;
        public DonadorView()
        {
            InitializeComponent();
            dataGridDonadores.DataSource = listaDonadores;
            CargarDatosAGrilla();
            FiltrarDonadores();
        }

        private async Task CargarDatosAGrilla()
        {
            listaDonadores.DataSource = await donadorService.GetAllAsync();
            donadoresFiltrar = (List<Donador>)listaDonadores.DataSource;
        }

        private void iconAgregarDonador_Click(object sender, EventArgs e)
        {
            tabDonadores.SelectedTab = tabAgregarEditarDonador;
        }

        private void iconEditarDonador_Click(object sender, EventArgs e)
        {
            donadorCurrent = (Donador)listaDonadores.Current;

            if (donadorCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un donador para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llena los controles con la información del donador
            txtNombreDonador.Text = donadorCurrent.Nombre;
            txtPaisDonador.Text = donadorCurrent.Pais;
            txtTelefonoDonador.Text = donadorCurrent.Telefonos;
            numericTotalDonado.Value = (decimal)donadorCurrent.TotalDonado;

            // Cambia al tab de edición
            tabDonadores.SelectedTab = tabAgregarEditarDonador;

        }

        private async void iconEliminarDonador_Click(object sender, EventArgs e)
        {
            donadorCurrent = (Donador)listaDonadores.Current;

            if (donadorCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un donador para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario
            var result = MessageBox.Show($"¿Está seguro que desea eliminar al donador {donadorCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Llama al servicio para eliminar al empleado
                    await donadorService.DeleteAsync(donadorCurrent.Id);

                    MessageBox.Show("Donador eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarga la grilla
                    await CargarDatosAGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el donador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void iconGuardarDonador_Click(object sender, EventArgs e)
        {
            if (donadorCurrent != null)
            {
                donadorCurrent.Nombre = txtNombreDonador.Text;
                donadorCurrent.Pais = txtPaisDonador.Text;
                donadorCurrent.Telefonos = txtTelefonoDonador.Text;
                donadorCurrent.TotalDonado = (decimal)numericTotalDonado.Value;
                await donadorService.UpdateAsync(donadorCurrent);
                donadorCurrent = null;
            }
            else
            {
                var donador = new Donador
                {
                    Nombre = txtNombreDonador.Text,
                    Pais = txtPaisDonador.Text,
                    Telefonos = txtTelefonoDonador.Text,
                    TotalDonado = (decimal)numericTotalDonado.Value
                };
                await donadorService.AddAsync(donador);
            }
            await CargarDatosAGrilla();
            txtNombreDonador.Text = string.Empty;
            txtPaisDonador.Text = string.Empty;
            txtTelefonoDonador.Text = string.Empty;
            numericTotalDonado.Value = 0;
            tabDonadores.SelectedTab = tabListaDonadores;
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            txtNombreDonador.Text = string.Empty;
            txtPaisDonador.Text = string.Empty;
            txtTelefonoDonador.Text = string.Empty;
            numericTotalDonado.Value = 0;
            tabDonadores.SelectedTab = tabListaDonadores;
        }


        private async void FiltrarDonadores()
        {
            // Filtra los donadores basándote en el texto de búsqueda
            var donadoresFiltrados = donadoresFiltrar
            .Where(d => d.Nombre.ToUpper().Contains(txtBuscarDonador.Text.ToUpper()))
            .ToList();

            // Actualiza el BindingSource y asigna al DataGridView
            listaDonadores.DataSource = donadoresFiltrados;
            dataGridDonadores.DataSource = listaDonadores;
        }
        private void iconBuscarDonador_Click(object sender, EventArgs e)
        {
            FiltrarDonadores();
        }
    }
}
