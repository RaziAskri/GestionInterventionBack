using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MediatR;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.IRepository;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Queries;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Handler;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Command;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Models;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Data;
using Ms_panne.Domain.Poulina.MSpanne.Domain.Models.Handler;
using System.Net.Http;
using Poulina.MSpanne.Domain.DTO;
using Microsoft.EntityFrameworkCore;

namespace Ms_Intervention.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class InterventionController : ControllerBase
    {
        private readonly PoulinaDbContext _context;

        private readonly IGenericRepository<Intervention> GenericRepository;

        private readonly HttpClient _httpClient = new HttpClient();
        private readonly IMediator mediator;
        private readonly IMapper mapper;







        public InterventionController(PoulinaDbContext context, IGenericRepository<Intervention> repository, IMapper mapper, IMediator mediator)
        {
            this.GenericRepository = repository;
            _context = context;
            this.mediator = mediator;
            this.mapper = mapper;
        }

        // GET: api/Projet
        [HttpGet("GetIntervention")]
        public async Task<IEnumerable<Intervention>> GetIntervention()
        {
            var query = new GetListGenericQuery<Intervention>(condition: null, includes: null);
            var Handler = new GetListGenericHandler<Intervention>(GenericRepository);
            return await Handler.Handle(query, new CancellationToken());
        }

        // GET: api/Actione/5
        [HttpGet("GetInterventionById")]
        public async Task<Intervention> GetMachineById(Guid id) =>
            await (new GetByIdGenericHandler<Intervention>(GenericRepository)).Handle(new GetByIdGenericQuery<Intervention>(condition: x => x.id_intervention.Equals(id), null), new CancellationToken());

        // PUT: api/Actione/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.

        [HttpPut("PutIntervention")]
        public async Task<string> PutIntervention([FromBody] Intervention projet) =>
            await (new PutGenericHandler<Intervention>(GenericRepository)).Handle(new PutGenericCommand<Intervention>(projet), new CancellationToken());

        // POST: api/Actione
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("PostIntervention")]
        public async Task<string> PostIntervention([FromBody] Intervention action) =>
            await (new PostGenericHandler<Intervention>(GenericRepository)).Handle(new PostGenericCommand<Intervention>(action), new CancellationToken());

        // DELETE: api/Actione/5
        [HttpDelete("RemoveIntervention")]
        public async Task<string> DeleteIntervention(Guid id) =>
            await (new RemoveGenericHandler<Intervention>(GenericRepository)).Handle(new RemoveGenericCommand<Intervention>(id), new CancellationToken());


        [HttpGet("GetInterventionDTO")]
        public async Task<IEnumerable<InterventionDTO>> GetInterventionDTO()
        {


            var listtype =
                 mediator.Send(new GetListGenericQuery<Intervention>
                    (null, includes: a => a
                    .Include(Intervention => Intervention.Panne)
                    .Include(Intervention => Intervention.Type_intervention))
                    ).Result.Select(v => mapper.Map<InterventionDTO>(v)
              );

            return listtype;
        }
    }
}
