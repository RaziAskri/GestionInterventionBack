using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Poulina.MSpanne.Domain.DTO;

namespace Poulina.MSpanne.Data.Repository
{
    public class MachineRepository
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public MachineRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public async Task<IEnumerable<MachineDTO>> GetMachines()
        {
            var httpClient = _httpClientFactory.CreateClient("Machines");
            var response = await httpClient.GetAsync($"Machine/GetMachine");
            string responseStream = response.Content.ReadAsStringAsync().Result;

            try
            {
                var machines = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MachineDTO>>(responseStream);

                return await Task<List<MachineDTO>>.FromResult(machines);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
