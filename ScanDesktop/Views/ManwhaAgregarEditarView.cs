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
    public partial class ManwhaAgregarEditarView : Form
    {
        IGenericService<Manwha> manwhaService = new GenericService<Manwha>();
        BindingSource listaManwhas = new BindingSource();
        List<Manwha> manwhasFiltrar = new List<Manwha>();
        Manwha manwhaCurrent;

        public ManwhaAgregarEditarView()
        {

            InitializeComponent();
            dataGridManwhas.DataSource = listaManwhas;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            {
                listaManwhas.DataSource = await manwhaService.GetAllAsync();
                manwhasFiltrar = (List<Manwha>)listaManwhas.DataSource;
            }
        }

        private void btnAgregarIcon_Click(object sender, EventArgs e)
        {
            tabControlManwha.SelectedTab = tabPageAgregarEditar;
        }

        private void btnEditarIcon_Click(object sender, EventArgs e)
        {
            manwhaCurrent = (Manwha)listaManwhas.Current;
            txtNombreManwha.Text = manwhaCurrent.Nombre;
            numericCapManwha.Value = (decimal)manwhaCurrent.Capitulos;
            txtSinopsisManwha.Text = manwhaCurrent.Sinopsis;
            txtUrl.Text = manwhaCurrent.ImagenUrl;
            picturePortada.ImageLocation = manwhaCurrent.ImagenUrl;
            checkBoxPopular.Checked = manwhaCurrent.Popular;

            tabControlManwha.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnEliminarIcon_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que que desea eliminar el Manwha?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var manwhaCurrent = (Manwha)listaManwhas.Current;
                await manwhaService.DeleteAsync(manwhaCurrent.Id);
                CargarGrilla();
            }
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (manwhaCurrent != null)
            {
                manwhaCurrent.Nombre = txtNombreManwha.Text;
                manwhaCurrent.Capitulos = (int)numericCapManwha.Value;
                manwhaCurrent.Sinopsis = txtSinopsisManwha.Text;
                manwhaCurrent.ImagenUrl = txtUrl.Text;
                manwhaCurrent.Popular = checkBoxPopular.Checked;
                await manwhaService.UpdateAsync(manwhaCurrent);
                manwhaCurrent = null;
            }
            else
            {
                var manwha = new Manwha
                {
                    Nombre = txtNombreManwha.Text,
                    Capitulos = (int)numericCapManwha.Value,
                    Sinopsis = txtSinopsisManwha.Text,
                    ImagenUrl = txtUrl.Text,
                    Popular = checkBoxPopular.Checked
                };
                await manwhaService.AddAsync(manwha);
            }
            await CargarGrilla();
            txtNombreManwha.Text = string.Empty;
            numericCapManwha.Value = 0;
            txtSinopsisManwha.Text = string.Empty;
            txtUrl.Text = string.Empty;
            checkBoxPopular.Checked = false;
            tabControlManwha.SelectedTab = tabPageLista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreManwha.Text = string.Empty;
            numericCapManwha.Value = 0;
            txtSinopsisManwha.Text = string.Empty;
            txtUrl.Text = string.Empty;
            checkBoxPopular.Checked = false;
            tabControlManwha.SelectedTab = tabPageLista;
        }
    }
}
