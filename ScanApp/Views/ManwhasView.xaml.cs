using ScanApp.ViewModels;

namespace ScanApp.Views;

public partial class ManwhasView : ContentPage
{
	public ManwhasView()
	{
        InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as ManwhasViewModel;
        //if (viewmodel.NotaSeleccionada != null)
        //{
        viewmodel.GetManwhas();
        //}
    }
}