using ScanServices.Interfaces;
using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanServices.Interfaces
{
    public interface IManwhaService : IGenericService<Manwha>
    {
        public Task<List<Manwha>?> GetAllInOfferAsync();
    }
}
