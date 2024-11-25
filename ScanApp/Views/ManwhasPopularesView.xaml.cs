namespace ScanApp.Views;
using ScanApp.ViewModels;

public partial class ManwhasPopularesView : ContentPage
{
	public ManwhasPopularesView()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewModel = this.BindingContext as ManwhasPopularesViewModel;
        viewModel.GetManwhasCommand.Execute(null);
    }
}