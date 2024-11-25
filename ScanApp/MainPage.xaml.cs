using ScanApp.ViewModels;

namespace ScanApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var viewModel = this.BindingContext as ManwhasFavoritosViewModel;
            viewModel.GetManwhasCommand.Execute(null);
        }
    }
}

