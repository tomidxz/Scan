using ScanDesktop.ViewsReport;
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

        BindingSource listaDonacion = new BindingSource();
        List<Donacion> donacions = new List<Donacion>();
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
            {
                numericTotal.Value = 0;
                dataGridDonaciones.DataSource = donacions.ToList();
            }

            // Cargar y transformar las donaciones para mostrar el nombre del donador
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

            donacions.Add(nuevaDonacion);
            dataGridDonaciones.DataSource = donacions.ToList();
            // Resetear los valores del formulario
        }

        private async void btnFinalizarDonacion_Click(object sender, EventArgs e)
        {
            donacion.Fecha = DateTime.Now;
            donacion.DonadorId = (int)comboDonador.SelectedValue;
            donacion.FormaPago = (FormaDePagoEnum)comboMetodoPago.SelectedValue;
            donacion.Total = numericTotal.Value;
            donacion.EmpleadoId = (int)comboEmpleado.SelectedValue;

            // Guardar la donación utilizando el servicio
            var donacionGuardada = await donacionService.AddAsync(donacion);

            // Actualizar el TotalDonado del donador seleccionado
            //var donadorSeleccionado = await donadorService.GetByIdAsync(donacion.DonadorId);
            //if (donadorSeleccionado != null)
            //{
            //    donadorSeleccionado.TotalDonado += donacion.Total;
            //    await donadorService.UpdateAsync(donadorSeleccionado);
            //}

            //Mostrar un reporte o vista de confirmación
            var reporteDonacion = new DonacionReportView(donacionGuardada);
            reporteDonacion.ShowDialog();
        }
    }
}
