using CommunityToolkit.Mvvm.Messaging;
using ScanApp.Class;
using ScanServices.Models;
using ScanServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ScanApp.ViewModels
{
    public class ManwhasViewModel : ObjectNotification
    {
        private GenericService<Manwha> manwhaService= new GenericService<Manwha>();
		private string filterManwhas;

		public string FilterManwhas
		{
			get { return filterManwhas; }
			set {
                filterManwhas = value; 
				OnPropertyChanged();
			}
		}
        //porque hacemos esto, porque lo dijo Gabriel
        //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<Manwha> manwhas;
        
        public ObservableCollection<Manwha> Manwhas
        {
            get { return manwhas; }
            set { manwhas = value;
                OnPropertyChanged();}

        }

        private List<Manwha>? manwhasListToFilter;



        public Command GetManwhasCommand { get; } 
        public ICommand AgregarFavoritosCommand { get; set; }



        public ManwhasViewModel()
        {

            GetManwhasCommand = new Command (async () => await GetManwhas());
            // Comando para manejar el evento de Long Press
            AgregarFavoritosCommand = new Command<Manwha>(OnLongPress);
            GetManwhas();
        }

        private async void OnLongPress(Manwha manwha)
        {
            // Verifica si el manga ya es favorito para decidir qué acción tomar
            if (manwha.Favoritos)
            {
                // Si ya es favorito, preguntar si desea quitarlo
                var result = await App.Current.MainPage.DisplayAlert(
                    "Opciones",
                    $"¿Deseas quitar '{manwha.Nombre}' de favoritos?",
                    "Sí",
                    "No");

                if (result)
                {
                    // Lógica para quitarlo de favoritos
                    manwha.Favoritos = false;
                    await App.Current.MainPage.DisplayAlert("Favoritos", $"{manwha.Nombre} ha sido quitado de favoritos.", "OK");
                }
            }
            else
            {
                // Si no es favorito, preguntar si desea agregarlo
                var result = await App.Current.MainPage.DisplayAlert(
                    "Opciones",
                    $"¿Deseas agregar '{manwha.Nombre}' a favoritos?",
                    "Sí",
                    "No");

                if (result)
                {
                    // Lógica para agregarlo a favoritos
                    manwha.Favoritos = true;
                    await App.Current.MainPage.DisplayAlert("Favoritos", $"{manwha.Nombre} ha sido agregado a favoritos.", "OK");
                }
            }

            // Actualizar el estado del manga en la base de datos
            await manwhaService.UpdateAsync(manwha);
        }


        private async void OnLongPressQuitar(Manwha manwha)
        {
            // Mostrar ventana emergente con opciones
            var result = await App.Current.MainPage.DisplayAlert(
                "Opciones",
                $"¿Deseas quitar '{manwha.Nombre}' de favoritos?",
                "Sí",
                "No");

            if (result)
            {
                // Aquí agregas la lógica para marcar como favorito
                manwha.Favoritos = true;
                await App.Current.MainPage.DisplayAlert("Favoritos", $"{manwha.Nombre} ha sido quitado de favoritos.", "OK");
            }
            await manwhaService.UpdateAsync(manwha);
        }

        public async Task GetManwhas()
        {
            FilterManwhas = string.Empty;
            IsRefreshing= true;
            manwhasListToFilter= await manwhaService.GetAllAsync();
            Manwhas = new ObservableCollection<Manwha>(manwhasListToFilter);
            IsRefreshing = false;
        } 
    }


}
