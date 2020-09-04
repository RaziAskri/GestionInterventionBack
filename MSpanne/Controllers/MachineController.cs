using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Data;

using Poulina.MSpanne.Data.Repository;
using Poulina.MSpanne.Domain.DTO;

namespace Ms_Panne.Controllers
{
    public class MachineController
    {

        private readonly PoulinaDbContext _context;


        private readonly HttpClient _httpClient = new HttpClient();
        private readonly MachineRepository _machineRepository;

        public MachineController(PoulinaDbContext context, MachineRepository repository)
        {
            _machineRepository = repository;
            _context = context;
        }
        [HttpGet("GetMachine")]
        public async Task<IEnumerable<MachineDTO>> GetMachines()
        {

            return _machineRepository.GetMachines().Result.ToList();
        }

    }
}
