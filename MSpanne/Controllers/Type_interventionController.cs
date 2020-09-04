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


namespace Ms_Type_intervention.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class Type_interventionController : ControllerBase
    {
        private readonly PoulinaDbContext _context;

        private readonly IGenericRepository<Type_intervention> GenericRepository;

        public Type_interventionController(PoulinaDbContext context, IGenericRepository<Type_intervention> repository)
        {
            this.GenericRepository = repository;
            _context = context;
        }

        // GET: api/Projet
        [HttpGet("GetType_intervention")]
        public async Task<IEnumerable<Type_intervention>> GetType_intervention()
        {
            var query = new GetListGenericQuery<Type_intervention>(condition: null, includes: null);
            var Handler = new GetListGenericHandler<Type_intervention>(GenericRepository);
            return await Handler.Handle(query, new CancellationToken());
        }

        // GET: api/Actione/5
        [HttpGet("GetType_interventionById")]
        public async Task<Type_intervention> GetMachineById(Guid id) =>
            await (new GetByIdGenericHandler<Type_intervention>(GenericRepository)).Handle(new GetByIdGenericQuery<Type_intervention>(condition: x => x.id_type_intervention.Equals(id), null), new CancellationToken());

        // PUT: api/Actione/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.

        [HttpPut("PutType_intervention")]
        public async Task<string> PutType_intervention([FromBody] Type_intervention projet) =>
            await (new PutGenericHandler<Type_intervention>(GenericRepository)).Handle(new PutGenericCommand<Type_intervention>(projet), new CancellationToken());

        // POST: api/Actione
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("PostType_intervention")]
        public async Task<string> PostType_intervention([FromBody] Type_intervention action) =>
            await (new PostGenericHandler<Type_intervention>(GenericRepository)).Handle(new PostGenericCommand<Type_intervention>(action), new CancellationToken());

        // DELETE: api/Actione/5
        [HttpDelete("RemoveType_intervention")]
        public async Task<string> DeleteType_intervention(Guid id) =>
            await (new RemoveGenericHandler<Type_intervention>(GenericRepository)).Handle(new RemoveGenericCommand<Type_intervention>(id), new CancellationToken());
    }
}