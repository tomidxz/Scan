using CommunityToolkit.Mvvm.Messaging.Messages;
using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.Class
{
    ////CLASE QUE PORTA EL MENSAJE

    public class Message : ValueChangedMessage<string>
    {
        public Solicitud SolicitudAEditar { get; set; }

        public Message(string value) : base(value)
        {

        }
    }
}
