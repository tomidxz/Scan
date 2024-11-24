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
    public class ManwhaService : GenericService<Manwha>, IManwhaService
    {
        public async Task<List<Manwha>?> GetAllInOfferAsync()
        {
            var response = await client.GetAsync($"{_endpoint}/getInOffer");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Manwha>>(content, options);
        }
    }
}
