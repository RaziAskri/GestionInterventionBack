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

namespace Ms_Type_panne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class Type_panneController : ControllerBase
    {
        private readonly PoulinaDbContext _context;

        private readonly IGenericRepository<Type_panne> GenericRepository;

        public Type_panneController(PoulinaDbContext context, IGenericRepository<Type_panne> repository)
        {
            this.GenericRepository = repository;
            _context = context;
        }

        // GET: api/Projet
        [HttpGet("GetType_panne")]
        public async Task<IEnumerable<Type_panne>> GetType_panne()
        {
            var query = new GetListGenericQuery<Type_panne>(condition: null, includes: null);
            var Handler = new GetListGenericHandler<Type_panne>(GenericRepository);
            return await Handler.Handle(query, new CancellationToken());
        }

        // GET: api/Actione/5
        [HttpGet("GetType_panneById")]
        public async Task<Type_panne> GetMachineById(Guid id) =>
            await (new GetByIdGenericHandler<Type_panne>(GenericRepository)).Handle(new GetByIdGenericQuery<Type_panne>(condition: x => x.id_type_panne.Equals(id), null), new CancellationToken());

        // PUT: api/Actione/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.

        [HttpPut("PutType_panne")]
        public async Task<string> PutType_panne([FromBody] Type_panne projet) =>
            await (new PutGenericHandler<Type_panne>(GenericRepository)).Handle(new PutGenericCommand<Type_panne>(projet), new CancellationToken());

        // POST: api/Actione
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("PostType_panne")]
        public async Task<string> PostType_panne([FromBody] Type_panne action) =>
            await (new PostGenericHandler<Type_panne>(GenericRepository)).Handle(new PostGenericCommand<Type_panne>(action), new CancellationToken());

        // DELETE: api/Actione/5
        [HttpDelete("RemoveType_panne")]
        public async Task<string> DeleteType_panne(Guid id) =>
            await (new RemoveGenericHandler<Type_panne>(GenericRepository)).Handle(new RemoveGenericCommand<Type_panne>(id), new CancellationToken());
    }
}