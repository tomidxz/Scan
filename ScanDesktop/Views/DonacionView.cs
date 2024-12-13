using ScanServices.Enums;
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
    public partial class DonacionView : Form
    {
        IDonadorService donadorService = new DonadorService();
        IGenericService<Donacion> donacionService = new GenericService<Donacion>();
        IGenericService<Empleado> empleadoService = new GenericService<Empleado>();

        Donacion donacion = new Donacion();

        public DonacionView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            #region Carga de combos

            // Obtener los datos de los servicios
            var donadores = await donadorService.GetAllAsync();
            var empleados = await empleadoService.GetAllAsync();

            // Configurar los comboboxes
            comboDonador.DataSource = donadores;
            comboEmpleado.DataSource = empleados;

            comboDonador.DisplayMember = "Nombre";
            comboDonador.ValueMember = "Id";
            comboDonador.SelectedIndex = -1;

            comboEmpleado.DisplayMember = "Nombre";
            comboEmpleado.ValueMember = "Id";
            comboEmpleado.SelectedIndex = -1;

            comboMetodoPago.DisplayMember = "Nombre";
            comboMetodoPago.ValueMember = "Id";
            comboMetodoPago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));

            #endregion

            numericTotal.Value = 0;

            // Cargar y transformar las donaciones para mostrar el nombre del donador
            await CargarDonaciones();
        }

        private async Task CargarDonaciones()
        {
            var donaciones = await donacionService.GetAllAsync();
            var donadores = await donadorService.GetAllAsync();

            // Crear una lista con datos transformados
            var datos = donaciones.Select(d => new
            {
                Fecha = d.Fecha,
                Donador = donadores.FirstOrDefault(don => don.Id == d.DonadorId)?.Nombre ?? "Desconocido",
                FormaDePago = d.FormaPago.ToString(),
                Total = d.Total
            }).ToList();

            dataGridDonaciones.DataSource = datos;
        }

        private async void btnAgregarDonacion_Click(object sender, EventArgs e)
        {
            // Crear una nueva donación a partir de los datos del formulario
            var nuevaDonacion = new Donacion
            {
                DonadorId = (int)comboDonador.SelectedValue,
                Fecha = dateTimeFecha.Value,
                FormaPago = (FormaDePagoEnum)comboMetodoPago.SelectedValue,
                Total = numericTotal.Value,
            };

            // Agregar la donación al servicio
            await donacionService.AddAsync(nuevaDonacion);

            // Refrescar los datos del DataGridView
            await CargarDonaciones();

            // Resetear los valores del formulario
            numericTotal.Value = 0;
            comboDonador.SelectedIndex = -1;
            comboMetodoPago.SelectedIndex = -1;
        }

        private async void btnFinalizarDonacion_Click(object sender, EventArgs e)
        {
            // Validar que los datos requeridos estén completos
            if (comboDonador.SelectedIndex == -1 || comboMetodoPago.SelectedIndex == -1 || numericTotal.Value <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de finalizar la donación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear la donación con los datos del formulario
            var nuevaDonacion = new Donacion
            {
                DonadorId = (int)comboDonador.SelectedValue,
                Fecha = dateTimeFecha.Value,
                FormaPago = (FormaDePagoEnum)comboMetodoPago.SelectedValue,
                Total = numericTotal.Value
            };

            // Guardar la donación utilizando el servicio
            var donacionGuardada = await donacionService.AddAsync(nuevaDonacion);

            // Mostrar mensaje de éxito
            MessageBox.Show("La donación se ha registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // (Opcional) Mostrar un reporte o vista de confirmación
            // var reporteDonacion = new ReporteDonacionView(donacionGuardada);
            // reporteDonacion.ShowDialog();

            // Limpiar el formulario para nuevas entradas
            comboDonador.SelectedIndex = -1;
            comboMetodoPago.SelectedIndex = -1;
            numericTotal.Value = 0;

            // Refrescar los datos en el DataGridView
            await CargarDonaciones();
        }
    }
}
