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

namespace Ms_Externe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExterneController
    {

        private readonly PoulinaDbContext _context;

        private readonly IGenericRepository<Externe> GenericRepository;

        public ExterneController(PoulinaDbContext context, IGenericRepository<Externe> repository)
        {
            this.GenericRepository = repository;
            _context = context;
        }

        // GET: api/Projet
        [HttpGet("GetExterne")]
        public async Task<IEnumerable<Externe>> GetExterne()
        {
            var query = new GetListGenericQuery<Externe>(condition: null, includes: null);
            var Handler = new GetListGenericHandler<Externe>(GenericRepository);
            return await Handler.Handle(query, new CancellationToken());
        }

        // GET: api/Actione/5
        [HttpGet("GetExterneById")]
        public async Task<Externe> GetMachineById(Guid id) =>
            await (new GetByIdGenericHandler<Externe>(GenericRepository)).Handle(new GetByIdGenericQuery<Externe>(condition: x => x.id_externe.Equals(id), null), new CancellationToken());

        // PUT: api/Actione/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.


        [HttpPut("PutExterne")]
        public async Task<string> PutExterne([FromBody] Externe projet) =>
            await (new PutGenericHandler<Externe>(GenericRepository)).Handle(new PutGenericCommand<Externe>(projet), new CancellationToken());

        // POST: api/Actione
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("PostExterne")]
        public async Task<string> PostExterne([FromBody] Externe action) =>
            await (new PostGenericHandler<Externe>(GenericRepository)).Handle(new PostGenericCommand<Externe>(action), new CancellationToken());

        // DELETE: api/Actione/5
        [HttpDelete("RemoveExterne")]
        public async Task<string> DeleteExterne(Guid id) =>
            await (new RemoveGenericHandler<Externe>(GenericRepository)).Handle(new RemoveGenericCommand<Externe>(id), new CancellationToken());
    
}
}
