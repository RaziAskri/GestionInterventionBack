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

namespace Ms_Panne.Controllers
{
    public class InterneController
    {
        private readonly PoulinaDbContext _context;

        private readonly IGenericRepository<Interne> GenericRepository;

        public InterneController(PoulinaDbContext context, IGenericRepository<Interne> repository)
        {
            this.GenericRepository = repository;
            _context = context;
        }

        // GET: api/Projet
        [HttpGet("GetInterne")]
        public async Task<IEnumerable<Interne>> GetInterne()
        {
            var query = new GetListGenericQuery<Interne>(condition: null, includes: null);
            var Handler = new GetListGenericHandler<Interne>(GenericRepository);
            return await Handler.Handle(query, new CancellationToken());
        }

        // GET: api/Actione/5
        [HttpGet("GetInterneById")]
        public async Task<Interne> GetMachineById(Guid id) =>
            await (new GetByIdGenericHandler<Interne>(GenericRepository)).Handle(new GetByIdGenericQuery<Interne>(condition: x => x.id_interne.Equals(id), null), new CancellationToken());

        // PUT: api/Actione/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.


        [HttpPut("PutInterne")]
        public async Task<string> PutInterne([FromBody] Interne projet) =>
            await (new PutGenericHandler<Interne>(GenericRepository)).Handle(new PutGenericCommand<Interne>(projet), new CancellationToken());

        // POST: api/Actione
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("PostInterne")]
        public async Task<string> PostInterne([FromBody] Interne action) =>
            await (new PostGenericHandler<Interne>(GenericRepository)).Handle(new PostGenericCommand<Interne>(action), new CancellationToken());

        // DELETE: api/Actione/5
        [HttpDelete("RemoveInterne")]
        public async Task<string> DeleteInterne(Guid id) =>
            await (new RemoveGenericHandler<Interne>(GenericRepository)).Handle(new RemoveGenericCommand<Interne>(id), new CancellationToken());

    }
}
 
