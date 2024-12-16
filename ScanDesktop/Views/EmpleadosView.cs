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
    public partial class EmpleadosView : Form
    {
        IGenericService<Empleado> empleadoService = new GenericService<Empleado>();
        BindingSource listaEmpleados = new BindingSource();
        List<Empleado> empleadosFiltrar = new List<Empleado>();
        Empleado empleadoCurrent;
        public EmpleadosView()
        {
            InitializeComponent();
            dataGridEmpleados.DataSource = listaEmpleados;
            CargarGrilla();
            CargarCombo();
            FiltrarEmpleados();
        }

        private async Task CargarCombo()
        {
            comboPuesto.DisplayMember = "Nombre";
            comboPuesto.ValueMember = "Id";
            comboPuesto.DataSource = Enum.GetValues(typeof(PuestoEmpleadoEnum));
        }

        private async Task CargarGrilla()
        {
            {
                dataGridEmpleados.DataSource = await empleadoService.GetAllAsync();
                empleadosFiltrar = (List<Empleado>)dataGridEmpleados.DataSource;
            }
        }

        private void iconAgregarEmpleado_Click(object sender, EventArgs e)
        {
            tabEmpleados.SelectedTab = tabAgregarEditarEmpleados;
        }

        private void iconEditarEmpleado_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtén el empleado seleccionado desde la fila seleccionada
            var selectedRow = dataGridEmpleados.SelectedRows[0];
            empleadoCurrent = (Empleado)selectedRow.DataBoundItem;

            // Llena los controles con la información del empleado
            txtNombre.Text = empleadoCurrent.Nombre;
            txtTelefonos.Text = empleadoCurrent.Telefonos;
            txtCorreo.Text = empleadoCurrent.Correo;
            dateTimeFecha.Value = empleadoCurrent.FechaNacimiento;
            comboPuesto.SelectedItem = empleadoCurrent.PuestoEmpleado;

            tabEmpleados.SelectedTab = tabAgregarEditarEmpleados;
        }

        private async void iconGuardar_Click(object sender, EventArgs e)
        {
            if (empleadoCurrent != null)
            {
                empleadoCurrent.Nombre = txtNombre.Text;
                empleadoCurrent.Telefonos = txtTelefonos.Text;
                empleadoCurrent.Correo = txtCorreo.Text;
                empleadoCurrent.FechaNacimiento = dateTimeFecha.Value;
                empleadoCurrent.PuestoEmpleado = (PuestoEmpleadoEnum)comboPuesto.SelectedItem;
                empleadoService.UpdateAsync(empleadoCurrent);
            }
            else
            {
                Empleado empleado = new Empleado
                {
                    Nombre = txtNombre.Text,
                    Telefonos = txtTelefonos.Text,
                    Correo = txtCorreo.Text,
                    FechaNacimiento = dateTimeFecha.Value,
                    PuestoEmpleado = (PuestoEmpleadoEnum)comboPuesto.SelectedItem
                };
                empleadoService.AddAsync(empleado);
            }
            await CargarGrilla();


            txtNombre.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            dateTimeFecha.Value = DateTime.Now;

            tabEmpleados.SelectedTab = tabListaEmpleados;
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            dateTimeFecha.Value = DateTime.Now;
            tabEmpleados.SelectedTab = tabListaEmpleados;
        }

        private async void iconEliminarEmpleado_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtén el empleado seleccionado desde la fila seleccionada
            var selectedRow = dataGridEmpleados.SelectedRows[0];
            var empleadoSeleccionado = (Empleado)selectedRow.DataBoundItem;

            // Confirmación del usuario
            var result = MessageBox.Show("¿Está seguro que desea eliminar el Empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Llama al servicio para eliminar al empleado
                    await empleadoService.DeleteAsync(empleadoSeleccionado.Id);

                    // Recarga la grilla
                    await CargarGrilla();

                    MessageBox.Show("Empleado eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private async void FiltrarEmpleados()
        {
            var empleadosFiltrados = empleadosFiltrar.Where(x => x.Nombre.ToUpper().Contains(txtBuscarEmpleado.Text.ToUpper())).ToList();
            listaEmpleados.DataSource = empleadosFiltrados;
            dataGridEmpleados.DataSource = listaEmpleados;
        }
        private void iconBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }
    }
}
