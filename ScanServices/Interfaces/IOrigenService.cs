using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanServices.Interfaces
{
    public interface IOrigenService : IGenericService<Origen>
    {
        public Task<List<Origen>?> GetAllAsync(string? filtro);
    }
}
