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
            #region carga de combos

            // Usar await directamente sin Task.Run
            var donadores = await donadorService.GetAllAsync();
            var empleados = await empleadoService.GetAllAsync();

            // Actualizar los comboboxes en el hilo principal
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

            // Obtener las donaciones y asignarlas a la data grid
            var donaciones = await donacionService.GetAllAsync();
            dataGridDonaciones.DataSource = donaciones;
        }

        private async void btnAgregarDonacion_Click(object sender, EventArgs e)
        {
            var nuevadonacion = new Donacion
            {
                DonadorId = (int)comboDonador.SelectedValue,
                Fecha = dateTimeFecha.Value,
                FormaPago = (FormaDePagoEnum)comboMetodoPago.SelectedValue,
                Total = numericTotal.Value,
            };

            await donacionService.AddAsync(nuevadonacion);

            // Refrescar los datos de la grilla después de agregar la donación
            var donaciones = await donacionService.GetAllAsync();
            dataGridDonaciones.DataSource = donaciones;

            numericTotal.Value = 0;
        }
    }
}
