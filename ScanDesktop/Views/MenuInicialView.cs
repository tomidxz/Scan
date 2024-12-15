using ScanDesktop.Views;

namespace ScanDesktop
{
    public partial class MenuInicialView : Form
    {
        public MenuInicialView()
        {
            InitializeComponent();
        }

        private void btnAgregarEditarIcon_Click(object sender, EventArgs e)
        {
            ManwhaAgregarEditarView manwhaAgregarEditarView = new ManwhaAgregarEditarView();
            manwhaAgregarEditarView.Show();
        }

        private void btnDonaciones_Click(object sender, EventArgs e)
        {
        }

        private void btnDetallesTraducIcon_Click(object sender, EventArgs e)
        {

        }

        private void btnTraduccionIcon_Click(object sender, EventArgs e)
        {
            TraduccionesView traduccionesView = new TraduccionesView();
            traduccionesView.Show();
        }

        private void IconBtnEmpleados_Click(object sender, EventArgs e)
        {
            EmpleadosView empleadosView = new EmpleadosView();
            empleadosView.Show();
        }

        private void iconMenuDonador_Click(object sender, EventArgs e)
        {
            DonadorView donadorView = new DonadorView();
            donadorView.Show();
        }

        private void iconMenuSolicitudes_Click(object sender, EventArgs e)
        {
            SolicitudesView solicitudesView = new SolicitudesView();
            solicitudesView.Show();
        }

        private void iconMenuAgregarDonacion_Click(object sender, EventArgs e)
        {
            DonacionView donacionView = new DonacionView();
            donacionView.Show();
        }

        private void iconMenuHistorialD_Click(object sender, EventArgs e)
        {
            HistorialDonacionesView historialDonacionesView = new HistorialDonacionesView();
            historialDonacionesView.Show();
        }
    }
}
