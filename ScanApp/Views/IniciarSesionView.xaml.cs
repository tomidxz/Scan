using CommunityToolkit.Mvvm.Messaging;
using ScanApp.Class;
using ScanApp.ViewModels;

namespace ScanApp.Views;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
        //BindingContext = new IniciarSesionViewModel();
        /////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceibedMessage(mensaje);
        });
    }
    private async void OnReceibedMessage(Message mensaje)
    {
    }
}