using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.IRepository;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Queries;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Handler;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Command;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Models;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Data;
using Ms_panne.Domain.Poulina.MSpanne.Domain.Models.Handler;
using Poulina.MSpanne.Domain.DTO;
using Poulina.MSpanne.Data.Repository;

namespace Ms_Panne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PanneController : ControllerBase
    {
        private readonly PoulinaDbContext _context;
        private readonly IMediator mediator;
        private readonly IGenericRepository<Panne> GenericRepository;
        private readonly MachineRepository _machineRepository;
        private readonly IMapper mapper;
        public PanneController(PoulinaDbContext context, IGenericRepository<Panne> repository, IMediator mediator, MachineRepository machinerepository, IMapper mapper)
        {
            this.mediator = mediator;
            this.GenericRepository = repository;
            _context = context;
            _machineRepository = machinerepository;
            this.mapper = mapper;
        }

        // GET: api/Projet
        [HttpGet("GetPanne")]
        public async Task<IEnumerable<Panne>> GetPanne()
        {
            var query = new GetListGenericQuery<Panne>(condition: null, includes: null);
            var Handler = new GetListGenericHandler<Panne>(GenericRepository);
            return await Handler.Handle(query, new CancellationToken());
        }

        // GET: api/Actione/5
        [HttpGet("GetPanneById")]
        public async Task<Panne> GetMachineById(Guid id) =>
            await (new GetByIdGenericHandler<Panne>(GenericRepository)).Handle(new GetByIdGenericQuery<Panne>(condition: x => x.id_panne.Equals(id), null), new CancellationToken());

        // PUT: api/Actione/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.


        [HttpPut("PutPanne")]
        public async Task<string> PutPanne([FromBody] Panne projet) =>
            await (new PutGenericHandler<Panne>(GenericRepository)).Handle(new PutGenericCommand<Panne>(projet), new CancellationToken());

        // POST: api/Actione
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("PostPanne")]
        public async Task<string> PostPanne([FromBody] Panne action) =>
            await (new PostGenericHandler<Panne>(GenericRepository)).Handle(new PostGenericCommand<Panne>(action), new CancellationToken());

        // DELETE: api/Actione/5
        [HttpDelete("RemovePanne")]
        public async Task<string> DeletePanne(Guid id) =>
            await (new RemoveGenericHandler<Panne>(GenericRepository)).Handle(new RemoveGenericCommand<Panne>(id), new CancellationToken());


        [HttpGet("GetPanneDTO")]
        public IEnumerable<PanneDTO> GetPanneDTO()
        {

           var listpanne =  mediator.Send(new GetListGenericQuery<Panne>
               (condition: null, includes: null)).Result.Select(v => mapper.Map<PanneDTO>(v));
            var machines= _machineRepository.GetMachines().Result.ToList();
            var list = new List<PanneDTO>();

            foreach(var item in listpanne)
            {
                MachineDTO machine = machines.Find(x => x.id_machine == item.id_machine);
                item.labelMachine = machine.label;
                list.Add(item);

            }


            return list;
        }
    }
    }