using ScanServices.Interfaces;
using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanServices.Interfaces
{
    public interface ISolicitudService : IGenericService<Solicitud>
    {
        public Task<List<Solicitud>?> GetAllInOfferAsync();
    }
}
