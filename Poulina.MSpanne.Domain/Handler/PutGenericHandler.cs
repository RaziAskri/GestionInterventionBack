using MediatR;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Command;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ms_panne.Domain.Poulina.MSpanne.Domain.Models.Handler
{
    public class PutGenericHandler<TEntity> : IRequestHandler<PutGenericCommand<TEntity>, string> where TEntity : class
    {
        public IGenericRepository<TEntity> GenericRepository { get; set; }
        public PutGenericHandler(IGenericRepository<TEntity> genericRepository)
        {
            GenericRepository = genericRepository;
        }
        public Task<string> Handle(PutGenericCommand<TEntity> request, CancellationToken cancellationToken)
        {
            var result = GenericRepository.Update(request.Entity);
            return Task.FromResult(result);
        }

    }
}
