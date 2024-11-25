using ScanApp.Views;

namespace ScanApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ManwhasView();
        }
    }
}
