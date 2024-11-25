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
    public class ManwhasPopularesViewModel : ObjectNotification
    {
        private ManwhaService manwhaService = new ManwhaService();
        private string filterManwhas;

        public string FilterManwhas
        {
            get { return filterManwhas; }
            set
            {
                filterManwhas = value;
                OnPropertyChanged();
                FiltrarManwhas();
            }
        }

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
        public Command FilterManwhasCommand { get; }

        public ManwhasPopularesViewModel()
        {
            GetManwhasCommand = new Command(async () => await GetManwhas());
            FilterManwhasCommand = new Command(async () => await FiltrarManwhas());
            GetManwhas();
        }

        public async Task FiltrarManwhas()
        {
            var manwhasLeaked = ManwhaListToFilter.Where(p => p.Nombre.ToLower().Contains(filterManwhas.ToLower()));
            Manwhas = new ObservableCollection<Manwha>(manwhasLeaked);
        }

        public async Task GetManwhas()
        {
            FilterManwhas = string.Empty;
            ActivityStart = true;
            ManwhaListToFilter = await manwhaService.GetAllAsync();
            Manwhas = new ObservableCollection<Manwha>(ManwhaListToFilter);
            ActivityStart = false;
        }
    }
}
