using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Command;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.IRepository;
using System.Threading;
using System.Threading.Tasks;

namespace Ms_panne.Domain.Poulina.MSpanne.Domain.Models.Handler
{
    public class PostIdGenericHandler<TEntity> : IRequestHandler<PostIDGenericCommand<TEntity>, TEntity> where TEntity : class
    {
        public IGenericRepository<TEntity> GenericRepository { get; set; }
        public PostIdGenericHandler(IGenericRepository<TEntity> genericRepository)
        {
            GenericRepository = genericRepository;
        }

        public Task<TEntity> Handle(PostIDGenericCommand<TEntity> request, CancellationToken cancellationToken)
        {
            var result = GenericRepository.AddId(request.Entity);
            return Task.FromResult(result);
        }
    }
}
