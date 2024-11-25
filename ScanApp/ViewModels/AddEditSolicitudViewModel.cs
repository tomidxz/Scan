using CommunityToolkit.Mvvm.Messaging;
using ScanApp.Class;
using ScanServices.Models;
using ScanServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.ViewModels
{
    internal class AddEditSolicitudViewModel : ObjectNotification
    {
        SolicitudService solicitudService = new SolicitudService();
        private Solicitud editSolicitud;

        public Solicitud EditSolicitud
        {
            get { return editSolicitud; }
            set {
                editSolicitud = value;
                OnPropertyChanged();
                SettingData();
            }
        }

        private void SettingData()
        {
            if (editSolicitud != null)
            {
                ManwhaPedido = editSolicitud.ManwhaPedido;
                CantidadCapitulos = editSolicitud.CantidadCapitulos;
                Comentario = editSolicitud.Comentario; 
                
            }
            else
            {
                ManwhaPedido = string.Empty;
                CantidadCapitulos = 0;
                Comentario = string.Empty;
                return;
            }
        }

        private string manwhaPedido;

        public string ManwhaPedido
        {
            get { return manwhaPedido; }
            set
            {
                manwhaPedido = value;
                OnPropertyChanged();
            }
        }

        private decimal cantidadCapitulos;

        public decimal CantidadCapitulos

        {
            get { return cantidadCapitulos; }
            set
            {
                cantidadCapitulos = value;
                OnPropertyChanged();
            }
        }
        private string comentario;

        public string Comentario
        {
            get { return comentario; }
            set
            {
                comentario = value;
                OnPropertyChanged();
            }
        }


        public Command SaveSolicitudCommand { get; }
        public Command CancelarCommand { get; }

        public AddEditSolicitudViewModel()
        {
            SaveSolicitudCommand = new Command(async () => await SaveSolicitud());
            CancelarCommand = new Command(async () => await cancelarSolicitud());
        }

        private async Task cancelarSolicitud()
        {
            await Shell.Current.GoToAsync("ListaSolicitudes");
        }


        private async Task SaveSolicitud()
        {
          
            if (EditSolicitud != null)
            {

                EditSolicitud.ManwhaPedido = ManwhaPedido;
                EditSolicitud.CantidadCapitulos = CantidadCapitulos;
                EditSolicitud.Comentario = Comentario;
                    await solicitudService.UpdateAsync(editSolicitud);
            }
            else
            {
                var solicitud = new Solicitud()
                {
                    ManwhaPedido = ManwhaPedido,
                    CantidadCapitulos = CantidadCapitulos,
                    Comentario = Comentario
                };

                await solicitudService.AddAsync(solicitud);
            }

            await Shell.Current.GoToAsync("ListaSolicitudes");
        }
    }
}
