using ScanApp.ViewModels;
using ScanApp.Views;

namespace ScanApp
{
    public partial class ScanShell : Shell
    {
        public ScanShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false;  // Oculta el menú lateral
            RegisterRouter(); // Registra el router de mensajes
            AddEditRouter(); // Registra el router de addeditsolicitud
            ListaRouter(); // Registra el router de solicitudes
        }
        private void RegisterRouter()
        {
            Routing.RegisterRoute("Registrarse", typeof(RegistrarseView)); // Registra la ruta de la página de registro
        }

        private void AddEditRouter()
        {
            Routing.RegisterRoute("AddEditSolicitud", typeof(AddEditSolicitudView)); // Registra la ruta de la página de addeditsolicitud

        }
        private void ListaRouter()
        {
            Routing.RegisterRoute("ListaSolicitudes", typeof(SolicitudView)); // Registra la ruta de la página de addeditsolicitud

        }


        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as ScanShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
    }
}
