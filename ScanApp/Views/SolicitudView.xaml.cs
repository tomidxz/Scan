using ScanApp.ViewModels;

namespace ScanApp.Views;

public partial class SolicitudView : ContentPage
{
	public SolicitudView()
	{
        InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as SolicitudViewModel;
        //if (viewmodel.NotaSeleccionada != null)
        //{
        viewmodel.GetSolicitudes();
        viewmodel.SelectedSolicitud = null;
        //}
    }
}