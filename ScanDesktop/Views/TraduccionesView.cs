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
    public partial class TraduccionesView : Form
    {
        IGenericService<Empleado> empleadoService = new GenericService<Empleado>();
        IGenericService<DetallesTraduccion> traduccionService = new GenericService<DetallesTraduccion>();
        IGenericService<Manwha> manwhaService = new GenericService<Manwha>();

        BindingSource listaTraduccion = new BindingSource();
        List<DetallesTraduccion> traduccions = new List<DetallesTraduccion>();
        DetallesTraduccion detallesTraduccion = new DetallesTraduccion();
        public TraduccionesView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async Task AjustePantalla()
        {
            #region carga de combos

            var manwhasTask = manwhaService.GetAllAsync();
            var empleadosTask = empleadoService.GetAllAsync();

            await Task.WhenAll(manwhasTask, empleadosTask);

            // Obtén los resultados de las tareas
            var manwhas = manwhasTask.Result;
            var empleados = empleadosTask.Result;

            // Filtra los empleados para cada puesto específico
            var empleadosCleaner = empleados.Where(e => e.PuestoEmpleado == PuestoEmpleadoEnum.Cleaner).ToList();
            var empleadosTraductor = empleados.Where(e => e.PuestoEmpleado == PuestoEmpleadoEnum.Traductor).ToList();
            var empleadosTyper = empleados.Where(e => e.PuestoEmpleado == PuestoEmpleadoEnum.Typer).ToList();

            // Asigna los datos filtrados a cada ComboBox
            comboManwhas.DataSource = manwhas;
            comboManwhas.DisplayMember = "Nombre";
            comboManwhas.ValueMember = "Id";
            comboManwhas.SelectedIndex = -1;

            comboCleaner.DataSource = empleadosCleaner;
            comboCleaner.DisplayMember = "Nombre";
            comboCleaner.ValueMember = "Id";
            comboCleaner.SelectedIndex = -1;

            comboTraductor.DataSource = empleadosTraductor;
            comboTraductor.DisplayMember = "Nombre";
            comboTraductor.ValueMember = "Id";
            comboTraductor.SelectedIndex = -1;

            comboTyper.DataSource = empleadosTyper;
            comboTyper.DisplayMember = "Nombre";
            comboTyper.ValueMember = "Id";
            comboTyper.SelectedIndex = -1;



            #endregion
            {
                numericCapitulo.Value = 0;
                dataGridTraducciones.DataSource = traduccions.ToList();
                #region Ajuste de columnas
                dataGridTraducciones.Columns["ManwhaId"].Visible = false;
                dataGridTraducciones.Columns["EmpleadoEncargadoId"].Visible = false;
                dataGridTraducciones.Columns["Eliminado"].Visible = false;
                #endregion
            }
        }

        private async void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            var traduccion = new DetallesTraduccion
            {
                ManwhaId = (int)comboManwhas.SelectedValue,
                EmpleadoCleanerId = (int)comboCleaner.SelectedValue,
                EmpleadoCleaner = (Empleado)comboCleaner.SelectedItem,
                EmpleadoTraductorId = (int)comboTraductor.SelectedValue,
                EmpleadoTraductor = (Empleado)comboTraductor.SelectedItem,
                EmpleadoTyperId = (int)comboTyper.SelectedValue,
                EmpleadoTyper = (Empleado)comboTyper.SelectedItem,
                CapituloTraducido = (decimal)numericCapitulo.Value,
                Fecha = DateTime.Now
            };
            traduccions.Add(traduccion);
            dataGridTraducciones.DataSource = traduccions.ToList();

        }

        private void iconBtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridTraducciones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una traducción para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detalleTraduccion = (DetallesTraduccion)dataGridTraducciones.CurrentRow.DataBoundItem;
            traduccions.Remove(detalleTraduccion);
            dataGridTraducciones.DataSource = traduccions.ToList();
        }

        private async void iconBtnFinalizar_Click(object sender, EventArgs e)
        {
            detallesTraduccion.ManwhaId = (int)comboManwhas.SelectedValue;
            detallesTraduccion.Manwha = (Manwha)comboManwhas.SelectedItem;
            detallesTraduccion.EmpleadoCleanerId = (int)comboCleaner.SelectedValue;
            detallesTraduccion.EmpleadoCleaner = (Empleado)comboCleaner.SelectedItem;
            detallesTraduccion.EmpleadoTraductorId = (int)comboTraductor.SelectedValue;
            detallesTraduccion.EmpleadoTraductor = (Empleado)comboTraductor.SelectedItem;
            detallesTraduccion.EmpleadoTyperId = (int)comboTyper.SelectedValue;
            detallesTraduccion.EmpleadoTyper = (Empleado)comboTyper.SelectedItem;
            detallesTraduccion.CapituloTraducido = (decimal)numericCapitulo.Value;
            detallesTraduccion.Fecha = DateTime.Now;
            var nuevatraduccion = await traduccionService.AddAsync(detallesTraduccion);
            var reporteTraduccion = new TraduccionReportView(nuevatraduccion);
            reporteTraduccion.ShowDialog();

        }
    }
}
