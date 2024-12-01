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
        IDonadorService donadorService = new DonadorService();
        BindingSource listaDonadores = new BindingSource();
        List<Donador> donadoresFiltrar = new List<Donador>();
        Donador donadorCurrent;
        public DonadorView()
        {
            InitializeComponent();
            CargarDatosAGrilla();
        }

        private async void CargarDatosAGrilla()
        {
            listaDonadores.DataSource = await donadorService.GetAllAsync();
            donadoresFiltrar = (List<Donador>)listaDonadores.DataSource;
            dataGridDonadores.Columns["Eliminado"].Visible = false;
        }
    }
}
