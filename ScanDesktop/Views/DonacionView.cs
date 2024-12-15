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
                Donador = (Donador)comboDonador.SelectedItem,
                EmpleadoId = (int)comboEmpleado.SelectedValue,
                Empleado = (Empleado)comboEmpleado.SelectedItem,
                Fecha = DateTime.Now,
                FormaPago = (FormaDePagoEnum)comboMetodoPago.SelectedValue,
                Total = (decimal)numericTotal.Value,
            };

            donacions.Add(nuevaDonacion);
            dataGridDonaciones.DataSource = donacions.ToList();
            // Resetear los valores del formulario
        }


        private async void btnFinalizarDonacion_Click_1(object sender, EventArgs e)
        {
            donacion.DonadorId = (int)comboDonador.SelectedValue;
            donacion.Donador = (Donador)comboDonador.SelectedItem;
            donacion.EmpleadoId = (int)comboEmpleado.SelectedValue;
            donacion.Empleado = (Empleado)comboEmpleado.SelectedItem;
            donacion.FormaPago = (FormaDePagoEnum)comboMetodoPago.SelectedValue;
            donacion.Total = numericTotal.Value;
            donacion.Fecha = DateTime.Now;

            var nuevadonacion = await donacionService.AddAsync(donacion);

            var reporteDonacion = new DonacionReportView(nuevadonacion);
            reporteDonacion.ShowDialog();
        }
    }
}
