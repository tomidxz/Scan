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
				_=FilterManwha();
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
        private Manwha selectedManwha;



        public Command GetManwhasCommand { get; }
        public Command FilterManwhasCommand { get; }

        public ManwhasViewModel()
        {
            GetManwhasCommand = new Command (async () => await GetManwhas());
            FilterManwhasCommand = new Command(async () => await FilterManwha());
            GetManwhas();
        }


        private async Task FilterManwha()
        {
            var manwhasFiltrados = manwhasListToFilter.Where(p => p.Nombre.ToUpper().Contains(filterManwhas.ToUpper()));
            
            Manwhas = new ObservableCollection<Manwha>(manwhasFiltrados);
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
