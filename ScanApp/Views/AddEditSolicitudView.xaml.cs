using ScanApp.ViewModels;
using ScanServices.Models;

namespace ScanApp.Views;
[QueryProperty(nameof(Solicitude), "SolicitudAEditar")]
public partial class AddEditSolicitudView : ContentPage
{
    public Solicitud Solicitude
    {
        set
        {
            var producto = value;
            var viewModel = this.BindingContext as AddEditSolicitudViewModel;
            viewModel.EditSolicitud = producto;
        }
    }
	public AddEditSolicitudView()
	{
		InitializeComponent();
	}

    public AddEditSolicitudView(Solicitud solicitud)
    {
        InitializeComponent();
        var viewmodel = this.BindingContext as AddEditSolicitudViewModel;
        viewmodel.EditSolicitud = solicitud;
    }
}