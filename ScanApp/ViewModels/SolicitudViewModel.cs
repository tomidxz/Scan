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
    public class SolicitudViewModel : ObjectNotification
    {
        private GenericService<Solicitud> solicitudService= new GenericService<Solicitud>();
		private string filterSolicituds;

		public string FilterSolicitudes
		{
			get { return filterSolicituds; }
			set { filterSolicituds = value; 
				OnPropertyChanged();
				_=FilterSolicitud();
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


        private ObservableCollection<Solicitud> solicitudes;

        public ObservableCollection<Solicitud> Solicitudes
        {
            get { return solicitudes; }
            set {
                solicitudes = value;
                OnPropertyChanged();}

        }

        private List<Solicitud>? solicitudesListToFilter;
        private Solicitud selectedSolicitud;

        public Solicitud SelectedSolicitud
        {
            get { return selectedSolicitud; }
            set {
                selectedSolicitud = value; 
            OnPropertyChanged();
            EditarSolicitudCommand.ChangeCanExecute();
            }
        }


        public Command GetSolicitudesCommand { get; }
        public Command FilterSolicitudesCommand { get; }
        public Command AddSolicitudCommand { get; }
        public Command EditarSolicitudCommand { get; }  

        public SolicitudViewModel()
        {
            GetSolicitudesCommand = new Command (async () => await GetSolicitudes());
            FilterSolicitudesCommand = new Command(async () => await FilterSolicitud());
            AddSolicitudCommand = new Command (async () => await AddSolicitud());
            EditarSolicitudCommand = new Command(async (obj) => await EditarSolicitud(),PermitirEditar);
            GetSolicitudes();
        }

        private bool PermitirEditar(object arg)
        {
            return SelectedSolicitud != null;
        }

        private async Task EditarSolicitud()
        {
            var navigationParameters = new ShellNavigationQueryParameters
            {
                { "SolicitudAEditar", SelectedSolicitud }
            };
            await Shell.Current.GoToAsync("AddEditSolicitud", navigationParameters);
        }

        private async Task AddSolicitud()
        {
            var navigationParameters = new ShellNavigationQueryParameters
            {
                { "SolicitudAEditar", null }
            };
            await Shell.Current.GoToAsync("AddEditSolicitud", navigationParameters);
        }

        private async Task FilterSolicitud()
        {
            var solicitudesFiltradas = solicitudesListToFilter.Where(p => p.ManwhaPedido.ToUpper().Contains(filterSolicituds.ToUpper()));
            
            Solicitudes = new ObservableCollection<Solicitud>(solicitudesFiltradas);
        }

        public async Task GetSolicitudes()
        {
            FilterSolicitudes = string.Empty;
            IsRefreshing= true;
            solicitudesListToFilter= await solicitudService.GetAllAsync();
            Solicitudes = new ObservableCollection<Solicitud>(solicitudesListToFilter);
            IsRefreshing = false;
        } 
    }


}
