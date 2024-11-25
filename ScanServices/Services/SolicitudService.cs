using ScanServices.Interfaces;
using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScanServices.Services
{
    public class SolicitudService : GenericService<Solicitud>, ISolicitudService
    {
        public async Task<List<Solicitud>?> GetAllInOfferAsync()
        {
            var response = await client.GetAsync($"{_endpoint}/getInOffer");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Solicitud>>(content, options);
        }
    }
}
