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
    public class ManwhasFavoritosViewModel : ObjectNotification
    {
        private ManwhaService manwhaService = new ManwhaService();

        private ObservableCollection<Manwha> manwhas;

        public ObservableCollection<Manwha> Manwhas
        {
            get { return manwhas; }
            set
            {
                manwhas = value;
                OnPropertyChanged();
            }
        }

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



        private List<Manwha>? ManwhaListToFilter;

        private bool activityStart;

        public bool ActivityStart
        {
            get { return activityStart; }
            set
            {
                activityStart = value;
                OnPropertyChanged();
            }
        }


        public Command GetManwhasCommand { get; }

        public ManwhasFavoritosViewModel()
        {
            GetManwhasCommand = new Command(async () => await GetManwhas());
            GetManwhas();
        }

        public async Task GetManwhas()
        {
            IsRefreshing = true;
            ActivityStart = true;
            ManwhaListToFilter = await manwhaService.GetAllFavoritosAsync();
            Manwhas = new ObservableCollection<Manwha>(ManwhaListToFilter);
            ActivityStart = false;
            IsRefreshing = false;
        }
    }
}
