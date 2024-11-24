using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanServices.Interfaces
{
    public interface IDonadorService : IGenericService<Donador>
    {
        public Task<List<Donador>> GetAllAsync(string? filtro);
    }
}
